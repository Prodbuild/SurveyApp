using System;
using System.Collections.Generic;

namespace GatewayEDI.Logging
{
    /// <summary> A <see cref="ILog" /> implementation which is intended for the purposes of unit testing the messages logged by the unit under test. The <see cref="LoggedItems" /> property of this class
    ///     contains all messages logged to this logger. </summary>
    public class TestLog : LogBase
    {
        /// <summary> All the LogItems which have been sent to this test log. </summary>
        private List<LogItem> logItems = new List<LogItem>();

        /// <summary> Constructs a TestLog instance. </summary>
        public TestLog() : base()
        {
        }

        /// <summary> Constructs a named TestLog instance. </summary>
        public TestLog(string name) : base(name)
        {
        }

        /// <summary> Returns an independent list of all messages logged to this log. </summary>
        public List<LogItem> LoggedItems
        {
            get { return new List<LogItem>(logItems); }
        }

        /// <summary> Records the given log item. </summary>
        /// <param name="item"> The item being logged. </param>
        public override void Write(LogItem item)
        {
            logItems.Add(item);
        }

        /// <summary> Clears all the items logged to this test logger. </summary>
        public void Reset()
        {
            logItems.Clear();
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            //TODO: Add this to the item being logged in Write()
            return null;
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public override void Remove(string key)
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public override void ClearMdc()
        {
            //TODO: This needs to be added to the Test Logger.
            throw new NotImplementedException();
        }

        #endregion
    }
}