using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BigBrotherFacade
{
    /// <summary>
    /// This class implements the client side of the BB protocol. (http://www.bb4.com)
    /// By default, it will send messages to port 1984 on localhost unless the
    /// port and host are over-ridden.
    /// setting testOnly to true will output the test results to stdout
    /// and not send them to the remote server.
    /// 04/14/2005 FPE:  Modified to throw exceptions when it would otherwise write to stdout.
    /// </summary>
    public class BBMessage
    {
        enum MessageTypes { STATUS, PAGE, SUMMARY, ACK, DISABLE, ENABLE, DATA, NOTES };

        const double _keepAliveTimeout = 1.5; // keep-alives will be sent on this recurring basis, expressed in milliweeks
        private bool _keepAlivesStarted = false;
        public bool _testOnly = false;
        private Hashtable _lastMessages,
                            _signalledTests;
        private int _port = 1984;
        private int _type;
        private string _server = "gsmonitor";
        private System.Threading.Timer _keepAliveTimer;

        delegate void ExpireDelegate(int delay, string remoteTest, string info);

        public BBMessage(string server) : this(server, 1984) { }
        public BBMessage(string server, int port)
            : this()
        {
            this._server = server;
            this.Port = port;
        }
        public BBMessage()
        {
            this._lastMessages = new Hashtable();
            this._signalledTests = new Hashtable();
        }
        ~BBMessage()
        {
            // If there are any pending 'expire' messages that haven't timed out,
            // force them to expire now.
            lock (_lastMessages)
            {
                IDictionaryEnumerator myEnum = _lastMessages.GetEnumerator();
                while (myEnum.MoveNext())
                {
                    sendStatusMessage((string)myEnum.Key, Status.BLUE, "Autoexpire due to client shutdown.", true);
                }
                _lastMessages.Clear();
            }
            if (_keepAlivesStarted) _keepAliveTimer.Dispose();
        }
        /// <summary>
        /// Send keep-alive messages to all signalled Tests with the last sent status.
        /// </summary>
        /// <param name="state"></param>
        private void KeepAlive(object state)
        {
            lock (_lastMessages)
            {
                IDictionaryEnumerator myEnum = _signalledTests.GetEnumerator();
                while (myEnum.MoveNext())
                {
                    sendStatusMessage((string)myEnum.Key, ((BBInfo)myEnum.Value).Status, ((BBInfo)myEnum.Value).Message, false);
                }
            }
        }

        public void Expire(int delay, string remoteTest, string info)
        {
            // Send delay as # of seconds.
            Thread.Sleep(delay * 1000);
            DateTime lastMessage;
            DateTime d = DateTime.Now;
            d.AddSeconds(-1 * delay);
            lock (_lastMessages)
            {
                if (_lastMessages.ContainsKey(remoteTest))
                {
                    lastMessage = (DateTime)_lastMessages[remoteTest];
                    if (d >= lastMessage)
                    {
                        // There have not been any changes to the status of this remoteTest
                        // since the expiring message that initiated this thread.
                        _lastMessages.Remove(remoteTest);
                        sendStatusMessage(remoteTest, Status.GREEN, info, true);
                    }
                }
            }
        }

        public void ExpireCallback(IAsyncResult ar)
        {
            ExpireDelegate dlgt = (ExpireDelegate)ar.AsyncState;
            dlgt.EndInvoke(ar);
            return;
        }
        /// <summary>
        /// Sends two messages, where the second one is always green and occurs <paramref name="longevity"/> seconds after the first.
        /// Use same as function sendStatusMessage, but add parameter longevity, which is the number of seconds to wait before sending a green status,
        /// assuming no other status messages have been sent to this remoteTest in the meantime and assuming that you don't call this function 
        /// with an initial green status.
        /// The second message uses <paramref name="expiredMsg"/> as its info.  
        /// THIS IS NOT THREADSAFE!
        /// </summary>
        /// <param name="remoteTest"></param>
        /// <param name="status"></param>
        /// <param name="info"></param>
        /// <param name="expiredMsg"></param>
        /// <param name="longevity"></param>
        public void sendExpiringStatusMessage(string remoteTest, Status status, string info, string expiredMsg, int longevity)
        {
            sendStatusMessage(remoteTest, status, info, true);
            if (status != Status.GREEN)
            {
                lock (_lastMessages)
                {
                    _lastMessages[remoteTest] = DateTime.Now;
                }
                ExpireDelegate dlgt = new ExpireDelegate(this.Expire);
                dlgt.BeginInvoke(longevity, remoteTest, expiredMsg, new AsyncCallback(this.ExpireCallback), dlgt);
            }
        }
        /// <summary>
        /// This method implements a form of keep-alive functionality by storing the parameters in a 
        /// hash table and resending the status message via a timer thread.  I don't feel this is an
        /// adequate solution to the issue of "message starvation" causing Hobbit to go purple, because
        /// that thread really has no knowledge of whether the rest of the system is still operating 
        /// or not.  It's just sending the last known status over and over.  The <see cref="Heartbeat"/> 
        /// functionality is a better solution, in my opinion, as it actively checks the system health
        /// before sending out a message.  
        /// 
        /// So, this method is now private, as it is used internally.
        /// </summary>
        /// <param name="remoteTest">Something that tells NetOps what it is you monitor. Example test names -- cpu, disk, conn. Short is better -- "rt-elig" is short and tells us what it is.  It becomes a column on the Hobbit status page.</param>
        /// <param name="status">Severity messages defined by Hobbit.  Similar to log4net levels.</param>
        /// <param name="info">The actual data to display</param>
        /// <param name="updateSignalledTests">If true, the status message will be automatically resent periodically by a Timer thread.</param>
        private void sendStatusMessage(string remoteTest, Status status, string info, bool updateSignalledTests)
        {
            /* a status message looks like this:
            * status www,bb4,com.disk red Wed Mar  7 21:16:33 EST 2001 Disk partitions on www,bb4,com OK
            * /dev/wd0s1a    496053    25081   431288     5%    /
            * /dev/wd0s4e   1998122  1094955   743318    60%    /home
            * /dev/wd0s2e   1489830  1094928   275716    80%    /usr 
            */
            string msg = string.Format("status {0}.{1} {2} {3} {4}\r\n", this.ClientName, remoteTest, this.getStatus(status), DateTime.Now.ToString("F"), info);
            doSend(msg);
            if (updateSignalledTests) _signalledTests[remoteTest] = new BBInfo(status, info);

            if (!_keepAlivesStarted)
            {
                // If a message is sent to a Test on the BB server, regardless of the status,
                // and then no followup messages are sent in a certain timeout period defined
                // on the server, then the server will go purple.  Because of this, every
                // Test that we send will need keep-alive messages sent forever.
                _keepAlivesStarted = true;
                _keepAliveTimer = new System.Threading.Timer(new TimerCallback(KeepAlive), null,
                    (int)_keepAliveTimeout * 604800, (int)_keepAliveTimeout * 604800);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="remoteTest">Something that tells NetOps what it is you monitor. 
        /// Example test names -- cpu, disk, conn. Short is better -- "rt-elig" is short and tells us what it is.  
        /// It becomes a column on the Hobbit status page.</param>
        /// <param name="status">Severity messages defined by Hobbit.  Similar to log4net levels.</param>
        /// <param name="info">The actual data to display</param>
        public void sendStatusMessage(string remoteTest, Status status, string info)
        {
            sendStatusMessage(remoteTest, status, info, false);
        }
        public void sendAlarm(string remoteTest, Status status, string info)
        {
            /* An alarm looks like this:
            * page www,bb4,com.cpu red Thu Jan 25 17:36:30 EST 2001 up: 16 mins, 3 users, 105 procs, load=363 
            */
            string msg = "page " + this.ClientName + "." + remoteTest + " " + getStatus(status) +
                " " + DateTime.Now.ToLongDateString() + " " + info;
            doSend(msg);
        }

        public void sendDisable(string remoteTest, string duration, string info)
        {
            /*A disable command looks like:
            * disable www.bb4.com* 120 Disk Removal
            */
            if (remoteTest == null) { remoteTest = "*"; };
            string msg = "disable " + this.ClientName + "." + remoteTest + " " + duration + " " + info;
            doSend(msg);
        }

        public void sendEnable(string remoteTest)
        {
            /* an enable command looks like:
            * enable www.bb4.com*
            */
            if (remoteTest == null) { remoteTest = "*"; };
            string msg = "enable " + this.ClientName + "." + remoteTest;
            doSend(msg);
        }

        public void sendData(string info)
        {
            /* standard data message:
            * data www.bb4.com.data ....
            */
            string msg = "data " + this.ClientName + ".data " + info;
            doSend(msg);
        }

        public void sendNotes(string info)
        {
            /* a standard notes message:
            * notes www.bb4.com.html ....
            */
            string msg = "notes " + this.ClientName + ".html " + info;
            doSend(msg);
        }

        private void doSend(string message)
        {
            NetworkStream stream = null;
            TcpClient client;

            if (this.testOnly)
            {
                throw new Exception("Test only.  Here's the message:  " + message);
            }
            //actually open up the tcp socket & ship it out.
            try
            {
                client = new TcpClient(this._server, this.Port);
            }
            catch (SocketException e)
            {
                StringBuilder sb = new StringBuilder("Couldn't create TCP client connection to port ");
                sb.Append(this.Port.ToString());
                sb.Append(" on host ");
                sb.Append(this._server.ToString());
                sb.Append(".  The socket error code is ");
                sb.Append(e.ErrorCode.ToString());
                sb.Append(".  Error was [");
                sb.Append(e.ToString());
                sb.Append("].");
                throw new Exception(sb.ToString());
            }
            try
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                client.NoDelay = true;
                stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                //couldn't send data...
                StringBuilder sb = new StringBuilder("Couldn't write message to port ");
                sb.Append(this.Port.ToString());
                sb.Append(" on host ");
                sb.Append(this._server.ToString());
                sb.Append(".  Error was [");
                sb.Append(e.ToString());
                sb.Append("].");
                throw new Exception(sb.ToString());
            }
            finally
            {
                client.Close();
                if (stream != null) stream.Close();
            }
        }

        private string replacePeriods(string hostname)
        {
            hostname = hostname.Replace(".", ",");
            return hostname;
        }

        private string getStatus(Status myStatus)
        {
            return myStatus.ToString().ToLower();
        }

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool testOnly
        {
            get { return _testOnly; }
            set { _testOnly = value; }
        }
        /// <summary>
        /// The server to locate Hobbit at.  Defaults to 'gsmonitor'.
        /// </summary>
        public string Server
        {
            get
            {
                if (_server == null)
                    throw new Exception("Server property not set");
                return this._server;
            }
            set { this._server = value; }
        }
        /// <summary>
        /// The port that Hobbit is listening on.  Defaults to 1984.
        /// </summary>
        public int Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        /// <summary>
        /// The name of the system that hobbit is monitoring.  For example, gsrtcl1.gatewayedi.com.  
        /// It <b>is</b> case sensitive, and must match how Hobbit has it configured.
        /// </summary>
        public string ClientName
        {
            get
            {
                return Environment.MachineName.ToLower() + ".gatewayedi.com";
            }
        }
    }
    
}
