using System;
using GatewayEDI.Logging;
using GatewayEDI.Logging.Formatters;

namespace RealtimeLoggingFacade
{
    /// <summary>
    /// An implementation of the <see cref="ILog"/> interface which logs messages via the log4net framework.
    /// </summary>
    public class Log4netLog : FormattableLogBase
    {
        /// <summary>
        /// The log4net log which this class wraps.
        /// </summary>
        private readonly log4net.ILog log;

        /// <summary>
        /// Constructs an instance of <see cref="Log4netLog"/> by wrapping a log4net log.
        /// </summary>
        /// <param name="log">The log4net log to wrap</param>
        internal Log4netLog(log4net.ILog log)
            : base(SingleLineFormatter.Instance)
        {
            this.log = log;
        }

        /// <summary>
        /// Logs the given message. 
        /// Output depends on the associated log4net configuration.
        /// </summary>
        /// <param name="item">A <see cref="LogItem"/> which encapsulates information to be logged.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="item"/> is a null reference.</exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");

            string message = FormatItem(item);

            switch (item.LogLevel)
            {
                case LogLevel.Fatal:
                    log.Fatal(message, item.Exception);
                    break;
                case LogLevel.Error:
                    log.Error(message, item.Exception);
                    break;
                case LogLevel.Warn:
                    log.Warn(message, item.Exception);
                    break;
                case LogLevel.Info:
                    log.Info(message, item.Exception);
                    break;
                case LogLevel.Debug:
                    log.Debug(message, item.Exception);
                    break;
                default:
                    log.Info(message, item.Exception);
                    break;
            }
        }

        /// <summary>
        /// Overriden to delegate to the log4net IsXxxEnabled properties.
        /// </summary>
        protected override bool IsLogLevelEnabled(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return log.IsDebugEnabled;
                case LogLevel.Error:
                    return log.IsErrorEnabled;
                case LogLevel.Fatal:
                    return log.IsFatalEnabled;
                case LogLevel.Info:
                    return log.IsInfoEnabled;
                case LogLevel.Warn:
                    return log.IsWarnEnabled;
                default:
                    return true;
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
            return log4net.ThreadContext.Stacks["NDC"].Push(message);
        }

        /// <summary>
        /// Pops a context message off of the stack implementation of the underlying logger.
        /// </summary>
        /// <returns>The context message that was on the top of the stack.</returns>
        public override string Pop()
        {
            return log4net.ThreadContext.Stacks["NDC"].Pop();
        }

        /// <summary>
        /// Clears all the contextual information held on the stack implementation of the underlying logger.
        /// </summary>
        public override void ClearNdc()
        {
            log4net.ThreadContext.Stacks["NDC"].Clear();
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
            log4net.ThreadContext.Properties[key] = value;
        }

        /// <summary>
        /// Gets the context value identified by the <paramref name="key" /> parameter.
        /// </summary>
        /// <param name="key">The key to lookup in the underlying logger.</param>
        /// <returns>The value of the named context property.</returns>
        public override string Get(string key)
        {
            object obj = log4net.ThreadContext.Properties[key];
            if (obj == null)
            {
                return null;
            }
            return obj.ToString();
        }

        /// <summary>
        /// Removes the key value mapping for the key specified.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public override void Remove(string key)
        {
            log4net.ThreadContext.Properties.Remove(key);
        }

        /// <summary>
        /// Clear all entries in the underlying logger.
        /// </summary>
        public override void ClearMdc()
        {
            log4net.ThreadContext.Properties.Clear();
        }
        #endregion
    }
}
