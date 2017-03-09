using System;

namespace GatewayEDI.Logging
{
    /// <summary> An <see cref="ILog" /> implementation that delegates the actual logging to an <see cref="Action{T}" /> delegate. </summary>
    public class DelegateLog : LogBase
    {
        /// <summary> Creates a named log with the action to be invoked for logged items. </summary>
        /// <param name="logAction"> The action delegate that is being invoked for every <see cref="LogItem" /> to be logged. </param>
        /// <param name="name"> The log name. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="logAction" /> is a null reference. </exception>
        public DelegateLog(string name, Action<LogItem> logAction)
            : base(name)
        {
            if (logAction == null) throw new ArgumentNullException("logAction");
            this.LogAction = logAction;
        }

        /// <summary> Creates a log with the action to be invoked for logged items. </summary>
        /// <param name="logAction"> The action delegate that is being invoked for every <see cref="LogItem" /> to be logged. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="logAction" /> is a null reference. </exception>
        public DelegateLog(Action<LogItem> logAction)
            : base()
        {
            if (logAction == null) throw new ArgumentNullException("logAction");
            this.LogAction = logAction;
        }

        /// <summary> The action delegate that is being invoked for every <see cref="LogItem" /> to be logged. </summary>
        protected Action<LogItem> LogAction { get; private set; }

        /// <summary> Invokes the <see cref="LogAction" /> for a given <see cref="LogItem" />. </summary>
        /// <param name="item"> Encaspulates logging information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");
            LogAction(item);
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public override void Remove(string key)
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public override void ClearMdc()
        {
            //TODO: Figure out a way to work this in to the delegate.  It needs to know the context messages.
            throw new NotImplementedException();
        }

        #endregion
    }
}