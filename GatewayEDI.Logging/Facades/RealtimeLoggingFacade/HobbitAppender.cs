using System;
using log4net.Appender;
using log4net.Core;

namespace RealtimeLoggingFacade
{
    /// <summary>
    /// Sends a status message to a Hobbit server.  
    /// Any messages sent are automatically assumed to be of status RED.
    /// </summary>
    public class HobbitAppender : AppenderSkeleton
    {
        #region Property defs
        private BBMessage bb_message = new BBMessage();

        public string RemoteTest
        {
            get
            {
                if (this.remoteTest == null)
                    throw new ArgumentException("must have a value for Hobbit", "RemoteTest");
                return this.remoteTest;
            }
            set { this.remoteTest = value; }
        }

        public BBMessage BBMessage
        {
            get { return this.bb_message; }
            set { this.bb_message = value; }
        }

        private string remoteTest;
        #endregion

        protected override void Append(LoggingEvent loggingEvent)
        {
            string rendered_msg = this.RenderLoggingEvent(loggingEvent);
            //Commented out until I can test that Hobbit is actually receiving these, although I don't see why it wouldn't.
            //this.BBMessage.sendStatusMessage(this.RemoteTest, Status.RED, rendered_msg);
            Console.Out.WriteLine(rendered_msg);
        }
    }
}
