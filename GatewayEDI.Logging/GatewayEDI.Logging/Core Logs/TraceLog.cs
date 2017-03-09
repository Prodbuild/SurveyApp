using System;
using System.Diagnostics;

namespace GatewayEDI.Logging
{
    /// <summary> Log implementation that writes trace messages. </summary>
    public class TraceLog : FormattableLogBase
    {
        /// <summary> Creates a named log. </summary>
        /// <param name="name"> The log name. </param>
        public TraceLog(string name) : base(name)
        {
        }

        /// <summary> Creates an un-named log. </summary>
        public TraceLog() : base()
        {
        }

        /// <summary> Creates a new log entry based on a given log item. </summary>
        /// <param name="item"> Encaspulates log information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");
            Trace.WriteLine(FormatItem(item));
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            //TODO: This needs to be added to the Trace.WriteLine call in Write.
            throw new NotImplementedException();
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public override void Remove(string key)
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public override void ClearMdc()
        {
            //TODO: This needs to be added to the Trace Logger.
            throw new NotImplementedException();
        }

        #endregion
    }
}