using System;

namespace GatewayEDI.Logging
{
    /// <summary> Simple <see cref="ILog" /> implementation that decorates an existing log implementation and allows to transform and/or filter logged messages. </summary>
    public class DecoratorLog : LogBase
    {
        /// <summary> Creates a named logger with a decorated <see cref="ILog" /> implementation and a filter function that can be used to update or discard the message before delegating the actual logging to
        ///     the decorated <paramref name="log" />. </summary>
        /// <param name="name"> The log name. </param>
        /// <param name="logger"> A decorated log. </param>
        /// <param name="filter"> A filter message that can be used to transform a submitted <see cref="LogItem" /> before getting it logged by the underlying log, or to ignore it completely (if the function
        ///     returns false). </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="log" /> is a null reference. </exception>
        /// <exception cref="ArgumentNullException"> If <paramref name="filter" /> is a null reference. </exception>
        public DecoratorLog(string name, ILog log, LogFilter filter)
            : base(name)
        {
            if (log == null) throw new ArgumentNullException("log");
            if (filter == null) throw new ArgumentNullException("filter");

            Filter = filter;
            this.Log = log;
        }

        /// <summary> Creates a log with a decorated <see cref="ILog" /> implementation and a filter function that can be used to update or discard the message before delegating the actual logging to the
        ///     decorated <paramref name="log" />. </summary>
        /// <param name="log"> A decorated log. </param>
        /// <param name="filter"> A filter message that can be used to transform a submitted <see cref="LogItem" /> before getting it logged by the underlying log, or to ignore it completely (if the function
        ///     returns false). </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="log" /> is a null reference. </exception>
        /// <exception cref="ArgumentNullException"> If <paramref name="filter" /> is a null reference. </exception>
        public DecoratorLog(ILog log, LogFilter filter)
            : base()
        {
            if (log == null) throw new ArgumentNullException("log");
            if (filter == null) throw new ArgumentNullException("filter");

            Filter = filter;
            this.Log = log;
        }

        /// <summary> A filtering mechanism that allows to programmatically intercept or transform a given <see cref="LogItem" /> before having it logged through the underyling <see cref="WriteLog" />. </summary>
        public LogFilter Filter { get; private set; }

        /// <summary> The decorated <see cref="ILog" /> instance. This log's <see cref="ILogger.Log" /> method is being invoked if the <see cref="Filter" /> function returns true. </summary>
        public ILog Log { get; private set; }

        /// <summary> Creates a new log entry based on a given log item. </summary>
        /// <param name="item"> Encaspulates log information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");

            //submit the item to the filter / transformator, then write to delegated logger
            if (Filter(item))
            {
                this.Log.Write(item);
            }
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            return this.Log.Push(message);
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            return this.Log.Pop();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            this.Log.ClearNdc();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            this.Log.Set(key, value);
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            return this.Log.Get(key);
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public override void Remove(string key)
        {
            this.Log.Remove(key);
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public override void ClearMdc()
        {
            this.Log.ClearMdc();
        }

        #endregion
    }
}