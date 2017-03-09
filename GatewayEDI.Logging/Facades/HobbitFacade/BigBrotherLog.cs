using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.Logging;

namespace BigBrotherFacade
{
    /// <summary>
    /// An implementation of the <see cref="ILog"/> interface which logs messages to a Big Brother Server.
    /// </summary>
    public class BigBrotherLog : FormattableLogBase
    {
        private BBMessage message = new BBMessage();
        private string server = "gsmonitor";
        private string port = "1984";
        private LogLevel threshold = LogLevel.Error;
        private string remoteTest;
        public string RemoteTest
        {
            get
            {
                if (string.IsNullOrEmpty(this.remoteTest))
                    throw new ArgumentNullException("RemoteTest");
                return this.remoteTest;
            }
            set
            {
                this.remoteTest = value;
            }
        }

        internal BigBrotherLog(string server, string port, string remoteTest, string threshold)
        {
            this.server = server;
            this.port = port;
            this.RemoteTest = remoteTest;
            this.threshold = GetLogLevel(threshold);
            message = new BBMessage(this.server, Convert.ToInt32(this.port));
        }

        public override void Write(LogItem item)
        {
            //this.message.sendStatusMessage(this.RemoteTest, Status.RED, item.LogLevel + " " + item.Message);
            Console.WriteLine("{0} - {1} {2}", this.RemoteTest, Status.RED.ToString(), item.LogLevel + " " + item.Message);
        }

        /// <summary>
        /// Overriden to delegate to the IsXxxEnabled properties.
        /// </summary>
        protected override bool IsLogLevelEnabled(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return (threshold == LogLevel.Debug);
                case LogLevel.Info:
                    return (threshold == LogLevel.Debug || threshold == LogLevel.Info);
                case LogLevel.Warn:
                    return (threshold == LogLevel.Debug || threshold == LogLevel.Info || threshold == LogLevel.Warn);
                case LogLevel.Error:
                    return (threshold == LogLevel.Debug || threshold == LogLevel.Info || threshold == LogLevel.Warn || threshold == LogLevel.Error);
                case LogLevel.Fatal:
                    return (threshold == LogLevel.Debug || threshold == LogLevel.Info || threshold == LogLevel.Warn || threshold == LogLevel.Error || threshold == LogLevel.Fatal);
                default:
                    return false;
            }
        }

        private LogLevel GetLogLevel(string threshold)
        {
            switch (threshold.ToUpper())
            {
                case "DEBUG":
                    return LogLevel.Debug;
                case "ERROR":
                    return LogLevel.Error;
                case "FATAL":
                    return LogLevel.Fatal;
                case "INFO":
                    return LogLevel.Info;
                case "WARN":
                    return LogLevel.Warn;
                default:
                    return LogLevel.Undefined;
            }
        }
        
        #region NDC
        /// <summary>
        /// Pushes a new context message on to the stack implementation of the underlying logger.
        /// </summary>
        /// <param name="message">The new context message.</param>
        /// <returns>An IDisposable reference to the stack.</returns>
        public override IDisposable Push(string message)
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pops a context message off of the stack implementation of the underlying logger.
        /// </summary>
        /// <returns>The context message that was on the top of the stack.</returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears all the contextual information held on the stack implementation of the underlying logger.
        /// </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }
        #endregion

        #region MDC
        /// <summary>
        /// Add an entry to the contextual properties of the underlying logger.
        /// </summary>
        /// <param name="key">The key to store the value under.</param>
        /// <param name="value">The value to store.</param>
        public override void Set(string key, string value)
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the context value identified by the <paramref name="key" /> parameter.
        /// </summary>
        /// <param name="key">The key to lookup in the underlying logger.</param>
        /// <returns>The value of the named context property.</returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the key value mapping for the key specified.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public override void Remove(string key)
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clear all entries in the underlying logger.
        /// </summary>
        public override void ClearMdc()
        {
            //TODO: This needs to be added to the Hobbit Logger.
            throw new NotImplementedException();
        }
        #endregion
    }
}
