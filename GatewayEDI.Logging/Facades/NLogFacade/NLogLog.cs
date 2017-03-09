using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.Logging;
using GatewayEDI.Logging.Formatters;

namespace NLogFacade
{
    /// <summary>
    /// An implementation of the <see cref="ILog"/> interface which logs messages via the NLog framework.
    /// </summary>
    public class NLogLog : FormattableLogBase
    {
        /// <summary>
        /// The NLog logger which this class wraps.
        /// </summary>
        private NLog.Logger log;

        /// <summary>
        /// Constructs an instance of <see cref="NLogLogger"/> by wrapping a NLog logger
        /// </summary>
        /// <param name="log">The NLog logger to wrap</param>
        internal NLogLog(NLog.Logger log)
            : base(SingleLineFormatter.Instance)
        {
            this.log = log;
        }

        /// <summary>
        /// Logs the given message. 
        /// Output depends on the associated NLog configuration.
        /// </summary>
        /// <param name="item">A <see cref="LogItem"/> which encapsulates information to be logged.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="item"/> is a null reference.</exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");

            string message = FormatItem(item);

            if (item.Exception != null)
            {
                switch (item.LogLevel)
                {
                    case LogLevel.Fatal:
                        log.FatalException(message, item.Exception);
                        break;
                    case LogLevel.Error:
                        log.ErrorException(message, item.Exception);
                        break;
                    case LogLevel.Warn:
                        log.WarnException(message, item.Exception);
                        break;
                    case LogLevel.Info:
                        log.InfoException(message, item.Exception);
                        break;
                    case LogLevel.Debug:
                        log.DebugException(message, item.Exception);
                        break;
                    default:
                        log.InfoException(message, item.Exception);
                        break;
                }
            }
            else
            {
                switch (item.LogLevel)
                {
                    case LogLevel.Fatal:
                        log.Fatal(message);
                        break;
                    case LogLevel.Error:
                        log.Error(message);
                        break;
                    case LogLevel.Warn:
                        log.Warn(message);
                        break;
                    case LogLevel.Info:
                        log.Info(message);
                        break;
                    case LogLevel.Debug:
                        log.Debug(message);
                        break;
                    default:
                        log.Info(message);
                        break;
                }
            }
        }

        /// <summary>
        /// Overriden to delegate to the NLog IsXxxEnabled properties.
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
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pops a context message off of the stack implementation of the underlying logger.
        /// </summary>
        /// <returns>The context message that was on the top of the stack.</returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears all the contextual information held on the stack implementation of the underlying logger.
        /// </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Nlog Logger.
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
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the context value identified by the <paramref name="key" /> parameter.
        /// </summary>
        /// <param name="key">The key to lookup in the underlying logger.</param>
        /// <returns>The value of the named context property.</returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the key value mapping for the key specified.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public override void Remove(string key)
        {
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clear all entries in the underlying logger.
        /// </summary>
        public override void ClearMdc()
        {
            //TODO: This needs to be added to the Nlog Logger.
            throw new NotImplementedException();
        }
        #endregion
    }
}
