using System;

namespace GatewayEDI.Logging
{
    /// <summary> A very simple implementation of <see cref="ILog" /> that outputs all messages to the system console. </summary>
    public class ConsoleLog : FormattableLogBase
    {
        /// <summary> Creates a named logger. </summary>
        /// <param name="name"> The logger name. </param>
        public ConsoleLog(string name) : base(name)
        {
        }

        /// <summary> Creates an un-named logger. </summary>
        public ConsoleLog()
        {
        }

        /// <summary> Logs a given item to the console. </summary>
        /// <param name="item"> The item to be logged. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public override void Write(LogItem item)
        {
            if (item == null) throw new ArgumentNullException("item");
            Console.Out.WriteLine(FormatItem(item));
        }

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public override IDisposable Push(string message)
        {
            //TODO: This needs to be added to the Console.WriteLine call in Write.
            throw new NotImplementedException();
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public override string Pop()
        {
            //TODO: This needs to be added to the Console Logger.
            throw new NotImplementedException();
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public override void ClearNdc()
        {
            //TODO: This needs to be added to the Console Logger.
            throw new NotImplementedException();
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public override void Set(string key, string value)
        {
            //TODO: This needs to be added to the Console Logger.
            throw new NotImplementedException();
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public override string Get(string key)
        {
            //TODO: This needs to be added to the Console Logger.
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
            //TODO: This needs to be added to the Console Logger.
            throw new NotImplementedException();
        }

        #endregion
    }
}