using System;
using System.Collections.Generic;

namespace GatewayEDI.Logging
{
    /// <summary> A log decorator that forwards logging messages to an arbitrary number of underlying logs. </summary>
    public class CompositeLog : LogBase
    {
        /// <summary> Creates a named empty log that does not produce any output as long as the <see cref="Logs" /> list does not contain and <see cref="ILog" /> instances. </summary>
        /// <param name="name"> The logger name. </param>
        public CompositeLog(string name)
            : base(name)
        {
            Logs = new List<ILog>();
        }

        /// <summary> Creates an empty logger that does not produce any output as long as the <see cref="Loggers" /> list does not contain and <see cref="ILogger" /> instances. </summary>
        public CompositeLog()
            : base()
        {
            Logs = new List<ILog>();
        }

        /// <summary> Inits a named log with a number of underlying logs that are supposed to receive log messages. </summary>
        /// <param name="name"> The log name. </param>
        /// <param name="logs"> The logs that will all receive the logged messages </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="logs" /> is a null reference. </exception>
        public CompositeLog(string name, params ILog[] logs)
            : base(name)
        {
            if (logs == null) throw new ArgumentNullException("logs");
            Logs = new List<ILog>(logs);
        }

        /// <summary> Inits a log with a number of underlying logs that are supposed to receive logging messages. </summary>
        /// <param name="logs"> The logs that will all receive the logged messages </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="logs" /> is a null reference. </exception>
        public CompositeLog(params ILog[] logs)
            : base()
        {
            if (logs == null) throw new ArgumentNullException("logs");
            Logs = new List<ILog>(logs);
        }

        /// <summary> The underlying logs that receive logging messages. </summary>
        public List<ILog> Logs { get; private set; }

        /// <summary> Forwards a given log entry to the underlying <see cref="Logs" />. </summary>
        /// <param name="item"> Encaspulates logging information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");

            foreach (var log in Logs)
            {
                log.Write(item);
            }
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            //TODO: Figure out how this would work. Can't return more than one IDisposable and there can be more than one underlying log.
            return null;
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Composite Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Composite Logger.
            throw new NotImplementedException();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            //TODO: This needs to be added to the Composite Logger.
            throw new NotImplementedException();
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Composite Logger.
            throw new NotImplementedException();
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public override void Remove(string key)
        {
            //TODO: This needs to be added to the Console Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public override void ClearMdc()
        {
            //TODO: This needs to be added to the Composite Logger.
            throw new NotImplementedException();
        }

        #endregion
    }
}