using System;

namespace GatewayEDI.Logging
{
    public abstract class LogBase : ILog
    {
        private const string EmptyLogMessage = "null";

        /// <summary> Constructs a named log. </summary>
        /// <param name="logName"> </param>
        protected LogBase(string logName)
        {
            Name = logName;
        }

        /// <summary> Constructs a log with no name. </summary>
        protected LogBase()
        {
        }

        public string Name { get; private set; }

        #region Debug

        public void Debug(object obj)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, obj != null ? obj.ToString() : EmptyLogMessage);
        }

        public void Debug(string message)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, message);
        }

        public void Debug(string format, params object[] args)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, format, args);
        }

        public void Debug(string format, object arg0)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, format, arg0);
        }

        public void Debug(string format, object arg0, object arg1)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, format, arg0, arg1);
        }

        public void Debug(string format, object arg0, object arg1, object arg2)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, format, arg0, arg1, arg2);
        }

        public void Debug(IFormatProvider provider, string format, params object[] args)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, provider, format, args);
        }

        public void Debug(IFormatProvider provider, string format, object arg0)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, provider, format, arg0);
        }

        public void Debug(IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, provider, format, arg0, arg1);
        }

        public void Debug(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, provider, format, arg0, arg1, arg2);
        }

        public void Debug(Exception exception)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception);
        }

        public void Debug(Exception exception, string message)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, message);
        }

        public void Debug(Exception exception, string format, params object[] args)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, format, args);
        }

        public void Debug(Exception exception, string format, object arg0)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, format, arg0);
        }

        public void Debug(Exception exception, string format, object arg0, object arg1)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, format, arg0, arg1);
        }

        public void Debug(Exception exception, string format, object arg0, object arg1, object arg2)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, format, arg0, arg1, arg2);
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, provider, format, args);
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, provider, format, arg0);
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, provider, format, arg0, arg1);
        }

        public void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsDebugEnabled)
                Write(LogLevel.Debug, exception, provider, format, arg0, arg1, arg2);
        }

        #endregion

        #region Info

        public void Info(object obj)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, obj != null ? obj.ToString() : EmptyLogMessage);
        }

        public void Info(string message)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, message);
        }

        public void Info(string format, params object[] args)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, format, args);
        }

        public void Info(string format, object arg0)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, format, arg0);
        }

        public void Info(string format, object arg0, object arg1)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, format, arg0, arg1);
        }

        public void Info(string format, object arg0, object arg1, object arg2)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, format, arg0, arg1, arg2);
        }

        public void Info(IFormatProvider provider, string format, params object[] args)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, provider, format, args);
        }

        public void Info(IFormatProvider provider, string format, object arg0)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, provider, format, arg0);
        }

        public void Info(IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, provider, format, arg0, arg1);
        }

        public void Info(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, provider, format, arg0, arg1, arg2);
        }

        public void Info(Exception exception)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception);
        }

        public void Info(Exception exception, string message)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, message);
        }

        public void Info(Exception exception, string format, params object[] args)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, format, args);
        }

        public void Info(Exception exception, string format, object arg0)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, format, arg0);
        }

        public void Info(Exception exception, string format, object arg0, object arg1)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, format, arg0, arg1);
        }

        public void Info(Exception exception, string format, object arg0, object arg1, object arg2)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, format, arg0, arg1, arg2);
        }

        public void Info(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, provider, format, args);
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, provider, format, arg0);
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, provider, format, arg0, arg1);
        }

        public void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsInfoEnabled)
                Write(LogLevel.Info, exception, provider, format, arg0, arg1, arg2);
        }

        #endregion

        #region Warn

        public void Warn(object obj)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, obj != null ? obj.ToString() : EmptyLogMessage);
        }

        public void Warn(string message)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, message);
        }

        public void Warn(string format, params object[] args)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, format, args);
        }

        public void Warn(string format, object arg0)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, format, arg0);
        }

        public void Warn(string format, object arg0, object arg1)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, format, arg0, arg1);
        }

        public void Warn(string format, object arg0, object arg1, object arg2)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, format, arg0, arg1, arg2);
        }

        public void Warn(IFormatProvider provider, string format, params object[] args)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, provider, format, args);
        }

        public void Warn(IFormatProvider provider, string format, object arg0)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, provider, format, arg0);
        }

        public void Warn(IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, provider, format, arg0, arg1);
        }

        public void Warn(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, provider, format, arg0, arg1, arg2);
        }

        public void Warn(Exception exception)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception);
        }

        public void Warn(Exception exception, string message)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, message);
        }

        public void Warn(Exception exception, string format, params object[] args)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, format, args);
        }

        public void Warn(Exception exception, string format, object arg0)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, format, arg0);
        }

        public void Warn(Exception exception, string format, object arg0, object arg1)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, format, arg0, arg1);
        }

        public void Warn(Exception exception, string format, object arg0, object arg1, object arg2)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, format, arg0, arg1, arg2);
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, provider, format, args);
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, provider, format, arg0);
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, provider, format, arg0, arg1);
        }

        public void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsWarnEnabled)
                Write(LogLevel.Warn, exception, provider, format, arg0, arg1, arg2);
        }

        #endregion

        #region Error

        public void Error(object obj)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, obj != null ? obj.ToString() : EmptyLogMessage);
        }

        public void Error(string message)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, message);
        }

        public void Error(string format, params object[] args)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, format, args);
        }

        public void Error(string format, object arg0)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, format, arg0);
        }

        public void Error(string format, object arg0, object arg1)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, format, arg0, arg1);
        }

        public void Error(string format, object arg0, object arg1, object arg2)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, format, arg0, arg1, arg2);
        }

        public void Error(IFormatProvider provider, string format, params object[] args)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, provider, format, args);
        }

        public void Error(IFormatProvider provider, string format, object arg0)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, provider, format, arg0);
        }

        public void Error(IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, provider, format, arg0, arg1);
        }

        public void Error(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, provider, format, arg0, arg1, arg2);
        }

        public void Error(Exception exception)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception);
        }

        public void Error(Exception exception, string message)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, message);
        }

        public void Error(Exception exception, string format, params object[] args)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, format, args);
        }

        public void Error(Exception exception, string format, object arg0)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, format, arg0);
        }

        public void Error(Exception exception, string format, object arg0, object arg1)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, format, arg0, arg1);
        }

        public void Error(Exception exception, string format, object arg0, object arg1, object arg2)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, format, arg0, arg1, arg2);
        }

        public void Error(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, provider, format, args);
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, provider, format, arg0);
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, provider, format, arg0, arg1);
        }

        public void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsErrorEnabled)
                Write(LogLevel.Error, exception, provider, format, arg0, arg1, arg2);
        }

        #endregion

        #region Fatal

        public void Fatal(object obj)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, obj != null ? obj.ToString() : EmptyLogMessage);
        }

        public void Fatal(string message)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, message);
        }

        public void Fatal(string format, params object[] args)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, format, args);
        }

        public void Fatal(string format, object arg0)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, format, arg0);
        }

        public void Fatal(string format, object arg0, object arg1)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, format, arg0, arg1);
        }

        public void Fatal(string format, object arg0, object arg1, object arg2)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, format, arg0, arg1, arg2);
        }

        public void Fatal(IFormatProvider provider, string format, params object[] args)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, provider, format, args);
        }

        public void Fatal(IFormatProvider provider, string format, object arg0)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, provider, format, arg0);
        }

        public void Fatal(IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, provider, format, arg0, arg1);
        }

        public void Fatal(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, provider, format, arg0, arg1, arg2);
        }

        public void Fatal(Exception exception)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception);
        }

        public void Fatal(Exception exception, string message)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, message);
        }

        public void Fatal(Exception exception, string format, params object[] args)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, format, args);
        }

        public void Fatal(Exception exception, string format, object arg0)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, format, arg0);
        }

        public void Fatal(Exception exception, string format, object arg0, object arg1)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, format, arg0, arg1);
        }

        public void Fatal(Exception exception, string format, object arg0, object arg1, object arg2)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, format, arg0, arg1, arg2);
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, provider, format, args);
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, provider, format, arg0);
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, provider, format, arg0, arg1);
        }

        public void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (IsFatalEnabled)
                Write(LogLevel.Fatal, exception, provider, format, arg0, arg1, arg2);
        }

        #endregion

        #region Logging Level Checks

        /// <summary> Indicates whether the given log level is enabled in the underlying logging framework. </summary>
        /// <param name="level"> The log level to query </param>
        /// <returns> Whether the given level is enabled. </returns>
        protected virtual bool IsLogLevelEnabled(LogLevel level)
        {
            return true;
        }

        /// <summary> Indicates whether the debug level is enabled in the underlying logging framework. </summary>
        /// <returns> Whether debug level is enabled. </returns>
        public bool IsDebugEnabled
        {
            get { return IsLogLevelEnabled(LogLevel.Debug); }
        }

        /// <summary> Indicates whether the info level is enabled in the underlying logging framework.
        ///     <returns> Whether info level is enabled. </returns>
        public bool IsInfoEnabled
        {
            get { return IsLogLevelEnabled(LogLevel.Info); }
        }

        /// <summary> Indicates whether the warn level is enabled in the underlying logging framework. </summary>
        /// <returns> Whether warn level is enabled. </returns>
        public bool IsWarnEnabled
        {
            get { return IsLogLevelEnabled(LogLevel.Warn); }
        }

        /// <summary> Indicates whether the error level is enabled in the underlying logging framework. </summary>
        /// <returns> Whether error level is enabled. </returns>
        public bool IsErrorEnabled
        {
            get { return IsLogLevelEnabled(LogLevel.Error); }
        }

        /// <summary> Indicates whether the fatal level is enabled in the underlying logging framework. </summary>
        /// <returns> Whether fatal level is enabled. </returns>
        public bool IsFatalEnabled
        {
            get { return IsLogLevelEnabled(LogLevel.Fatal); }
        }

        #endregion

        #region Write

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        public virtual void Write(LogLevel level, string format, params object[] args)
        {
            Write(level, String.Format(format, args));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        public virtual void Write(LogLevel level, string format, object arg0)
        {
            Write(level, string.Format(format, arg0));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        public virtual void Write(LogLevel level, string format, object arg0, object arg1)
        {
            Write(level, string.Format(format, arg0, arg1));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        public virtual void Write(LogLevel level, string format, object arg0, object arg1, object arg2)
        {
            Write(level, string.Format(format, arg0, arg1, arg2));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        public virtual void Write(LogLevel level, IFormatProvider provider, string format, params object[] args)
        {
            Write(level, String.Format(provider, format, args));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        public virtual void Write(LogLevel level, IFormatProvider provider, string format, object arg0)
        {
            Write(level, String.Format(provider, format, arg0));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        public virtual void Write(LogLevel level, IFormatProvider provider, string format, object arg0, object arg1)
        {
            Write(level, String.Format(provider, format, arg0, arg1));
        }

        /// <summary> Logs a formatted message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        public virtual void Write(LogLevel level, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            Write(level, String.Format(provider, format, arg0, arg1, arg2));
        }

        /// <summary> Logs a message on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="message"> The message to log. </param>
        public virtual void Write(LogLevel level, string message)
        {
            LogItem item = new LogItem { LogLevel = level, Message = message, LogName = Name };
            Write(item);
        }

        /// <summary> Logs an exception with on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        public virtual void Write(LogLevel level, Exception exception)
        {
            Write(level, exception, String.Empty);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        public virtual void Write(LogLevel level, Exception exception, string format, params object[] args)
        {
            string message = String.Format(format, args);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, string format, object arg0)
        {
            string message = String.Format(format, arg0);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, string format, object arg0, object arg1)
        {
            string message = String.Format(format, arg0, arg1);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, string format, object arg0, object arg1, object arg2)
        {
            string message = String.Format(format, arg0, arg1, arg2);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        public virtual void Write(LogLevel level, Exception exception, IFormatProvider provider, string format, params object[] args)
        {
            string message = String.Format(provider, format, args);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, IFormatProvider provider, string format, object arg0)
        {
            string message = String.Format(provider, format, arg0);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, IFormatProvider provider, string format, object arg0, object arg1)
        {
            string message = String.Format(provider, format, arg0, arg1);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a formatted message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        public virtual void Write(LogLevel level, Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            string message = String.Format(provider, format, arg0, arg1, arg2);
            Write(level, exception, message);
        }

        /// <summary> Logs an exception along with a message string on a given logging level. </summary>
        /// <param name="level"> The logging level which is used to indicate severity, or for filtering the information. </param>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        public virtual void Write(LogLevel level, Exception exception, string message)
        {
            LogItem item = new LogItem { LogLevel = level, Message = message, LogName = this.Name };
            item.Exception = exception;
            Write(item);
        }

        /// <summary> Creates a new log entry based on a given log item. </summary>
        /// <param name="item"> Encapsulates logging information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" /> is a null reference. </exception>
        public abstract void Write(LogItem item);

        #endregion

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An <see cref="IDisposable" /> that can be used to clean up the underlying context stack. </returns>
        public abstract IDisposable Push(string message);

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        public abstract string Pop();

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        public abstract void ClearNdc();

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        public abstract void Set(string key, string value);

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> </returns>
        public abstract string Get(string key);

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        public abstract void Remove(string key);

        /// <summary> Clear all entries in the underlying logger. </summary>
        public abstract void ClearMdc();

        #endregion
    }
}