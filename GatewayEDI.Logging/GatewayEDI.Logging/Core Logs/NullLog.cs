using System;

namespace GatewayEDI.Logging
{
    public sealed class NullLog : ILog
    {
        /// <summary> Always returns <see cref="LogManager.DefaultLogName" />
        /// </summary>
        public string Name
        {
            get { return LogManager.DefaultLogName; }
        }

        public void Write(LogItem item)
        {
        }

        #region Singleton

        private static readonly NullLog instance = new NullLog();

        /// <summary> Explicit static constructor to tell C# compiler not to mark type as beforefieldint </summary>
        static NullLog()
        {
        }

        /// <summary> Private constructor. A reference to the Singleton instance of this class is available through the static <see cref="Instance" /> property. </summary>
        private NullLog()
        {
        }

        /// <summary> Provides access to the singleton instance of the class. </summary>
        public static NullLog Instance
        {
            get { return instance; }
        }

        #endregion

        #region Debug

        public void Debug(object obj)
        {
        }

        public void Debug(string message)
        {
        }

        public void Debug(string format, params object[] args)
        {
        }

        public void Debug(string format, object arg0)
        {
        }

        public void Debug(string format, object arg0, object arg1)
        {
        }

        public void Debug(string format, object arg0, object arg1, object arg2)
        {
        }

        public void Debug(IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Debug(IFormatProvider provider, string format, object arg0)
        {
        }

        public void Debug(IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Debug(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Debug(Exception exception)
        {
        }

        public void Debug(Exception exception, string message)
        {
        }

        public void Debug(Exception exception, string format, params object[] args)
        {
        }

        public void Debug(Exception exception, string format, object arg0)
        {
        }

        public void Debug(Exception exception, string format, object arg0, object arg1)
        {
        }

        public void Debug(Exception exception, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0)
        {
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        #endregion

        #region Info

        public void Info(object obj)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string format, params object[] args)
        {
        }

        public void Info(string format, object arg0)
        {
        }

        public void Info(string format, object arg0, object arg1)
        {
        }

        public void Info(string format, object arg0, object arg1, object arg2)
        {
        }

        public void Info(IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Info(IFormatProvider provider, string format, object arg0)
        {
        }

        public void Info(IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Info(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Info(Exception exception)
        {
        }

        public void Info(Exception exception, string message)
        {
        }

        public void Info(Exception exception, string format, params object[] args)
        {
        }

        public void Info(Exception exception, string format, object arg0)
        {
        }

        public void Info(Exception exception, string format, object arg0, object arg1)
        {
        }

        public void Info(Exception exception, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Info(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0)
        {
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        #endregion

        #region Warn

        public void Warn(object obj)
        {
        }

        public void Warn(string message)
        {
        }

        public void Warn(string format, params object[] args)
        {
        }

        public void Warn(string format, object arg0)
        {
        }

        public void Warn(string format, object arg0, object arg1)
        {
        }

        public void Warn(string format, object arg0, object arg1, object arg2)
        {
        }

        public void Warn(IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Warn(IFormatProvider provider, string format, object arg0)
        {
        }

        public void Warn(IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Warn(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Warn(Exception exception)
        {
        }

        public void Warn(Exception exception, string message)
        {
        }

        public void Warn(Exception exception, string format, params object[] args)
        {
        }

        public void Warn(Exception exception, string format, object arg0)
        {
        }

        public void Warn(Exception exception, string format, object arg0, object arg1)
        {
        }

        public void Warn(Exception exception, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0)
        {
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        #endregion

        #region Error

        public void Error(object obj)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string format, params object[] args)
        {
        }

        public void Error(string format, object arg0)
        {
        }

        public void Error(string format, object arg0, object arg1)
        {
        }

        public void Error(string format, object arg0, object arg1, object arg2)
        {
        }

        public void Error(IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Error(IFormatProvider provider, string format, object arg0)
        {
        }

        public void Error(IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Error(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Error(Exception exception)
        {
        }

        public void Error(Exception exception, string message)
        {
        }

        public void Error(Exception exception, string format, params object[] args)
        {
        }

        public void Error(Exception exception, string format, object arg0)
        {
        }

        public void Error(Exception exception, string format, object arg0, object arg1)
        {
        }

        public void Error(Exception exception, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Error(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0)
        {
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        #endregion

        #region Fatal

        public void Fatal(object obj)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string format, params object[] args)
        {
        }

        public void Fatal(string format, object arg0)
        {
        }

        public void Fatal(string format, object arg0, object arg1)
        {
        }

        public void Fatal(string format, object arg0, object arg1, object arg2)
        {
        }

        public void Fatal(IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Fatal(IFormatProvider provider, string format, object arg0)
        {
        }

        public void Fatal(IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Fatal(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Fatal(Exception exception)
        {
        }

        public void Fatal(Exception exception, string message)
        {
        }

        public void Fatal(Exception exception, string format, params object[] args)
        {
        }

        public void Fatal(Exception exception, string format, object arg0)
        {
        }

        public void Fatal(Exception exception, string format, object arg0, object arg1)
        {
        }

        public void Fatal(Exception exception, string format, object arg0, object arg1, object arg2)
        {
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0)
        {
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
        }

        #endregion

        #region Logging Level Checks

        public bool IsDebugEnabled
        {
            get { return false; }
        }

        public bool IsInfoEnabled
        {
            get { return false; }
        }

        public bool IsWarnEnabled
        {
            get { return false; }
        }

        public bool IsErrorEnabled
        {
            get { return false; }
        }

        public bool IsFatalEnabled
        {
            get { return false; }
        }

        #endregion

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        public IDisposable Push(string message)
        {
            //Figure out what to do with a null log when I'm not logging anything.
            return null;
        }

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public string Pop()
        {
            return null;
        }

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public void ClearNdc()
        {
        }

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public void Set(string key, string value)
        {
        }

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        public string Get(string key)
        {
            return null;
        }

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public void Remove(string key)
        {
        }

        /// <summary> Clear all entries in the underlying logger. </summary>
        public void ClearMdc()
        {
        }

        #endregion
    }
}