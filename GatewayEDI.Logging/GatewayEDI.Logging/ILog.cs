using System;

namespace GatewayEDI.Logging
{
    public interface ILog
    {
        /// <summary> Creates a new log entry based on a given log item. </summary>
        /// <param name="item"> Encaspulates logging information. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="item" />
        ///     is a null reference. </exception>
        void Write(LogItem item);

        #region Debug

        /// <summary> Logs an arbitrary object with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="obj"> The message object to log, which will be converted into a string during logging. </param>
        void Debug(object obj);

        /// <summary> Logs a debug message (<see cref="LogLevel.Debug" />). </summary>
        /// <param name="message"> The message to log. </param>
        void Debug(string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Debug(string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Debug(string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Debug(string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Debug(string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Debug(IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Debug(IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Debug(IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Debug(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs an exception with a logging level of <see cref="LogLevel.Debug" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        void Debug(Exception exception);

        /// <summary> Logs an exception and an additional message with a logging level of <see cref="LogLevel.Debug" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        void Debug(Exception exception, string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Debug(Exception exception, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Debug(Exception exception, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Debug(Exception exception, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Debug(Exception exception, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Debug(Exception exception, IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Debug(Exception exception, IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Debug" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Debug(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        #endregion

        #region Info

        /// <summary> Logs an arbitrary object with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="obj"> The message object to log, which will be converted into a string during logging. </param>
        void Info(object obj);

        /// <summary> Logs an informational message (<see cref="LogLevel.Info" />). </summary>
        /// <param name="message"> The message to log. </param>
        void Info(string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Info(string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Info(string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Info(string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Info(string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Info(IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Info(IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Info(IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Info(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs an exception with a logging level of <see cref="LogLevel.Info" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        void Info(Exception exception);

        /// <summary> Logs an exception and an additional message with a logging level of <see cref="LogLevel.Info" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        void Info(Exception exception, string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Info(Exception exception, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Info(Exception exception, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Info(Exception exception, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Info(Exception exception, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Info(Exception exception, IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Info(Exception exception, IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Info" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Info(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        #endregion

        #region Warn

        /// <summary> Logs an arbitrary object with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="obj"> The message object to log, which will be converted into a string during logging. </param>
        void Warn(object obj);

        /// <summary> Logs a warning message (<see cref="LogLevel.Warn" />). </summary>
        /// <param name="message"> The message to log. </param>
        void Warn(string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Warn(string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Warn(string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Warn(string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Warn(string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Warn(IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Warn(IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Warn(IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Warn(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs an exception with a logging level of <see cref="LogLevel.Warn" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        void Warn(Exception exception);

        /// <summary> Logs an exception and an additional message with a logging level of <see cref="LogLevel.Warn" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        void Warn(Exception exception, string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Warn(Exception exception, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Warn(Exception exception, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Warn(Exception exception, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Warn(Exception exception, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Warn(Exception exception, IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Warn(Exception exception, IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Warn" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Warn(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        #endregion

        #region Error

        /// <summary> Logs an arbitrary object with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="obj"> The message object to log, which will be converted into a string during logging. </param>
        void Error(object obj);

        /// <summary> Logs an error message (<see cref="LogLevel.Error" />). </summary>
        /// <param name="message"> The message to log. </param>
        void Error(string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Error(string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Error(string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Error(string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Error(string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Error(IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Error(IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Error(IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Error(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs an exception with a logging level of <see cref="LogLevel.Error" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        void Error(Exception exception);

        /// <summary> Logs an exception and an additional message with a logging level of <see cref="LogLevel.Error" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        void Error(Exception exception, string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Error(Exception exception, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Error(Exception exception, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Error(Exception exception, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Error(Exception exception, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Error(Exception exception, IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Error(Exception exception, IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Error" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Error(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        #endregion

        #region Fatal

        /// <summary> Logs an arbitrary object with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="obj"> The message object to log, which will be converted into a string during logging. </param>
        void Fatal(object obj);

        /// <summary> Logs a fatal error message (<see cref="LogLevel.Fatal" />). </summary>
        /// <param name="message"> The message to log. </param>
        void Fatal(string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Fatal(string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Fatal(string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Fatal(string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Fatal(string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Fatal(IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Fatal(IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="provider" An
        /// <see cref="IFormatProvider" />
        /// which provides culture-specific formatting capabilities.>
        /// </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Fatal(IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Fatal(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs an exception with a logging level of <see cref="LogLevel.Fatal" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        void Fatal(Exception exception);

        /// <summary> Logs an exception and an additional message with a logging level of <see cref="LogLevel.Fatal" />. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="message"> Additional information regarding the logged exception. </param>
        void Fatal(Exception exception, string message);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Fatal(Exception exception, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Fatal(Exception exception, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Fatal(Exception exception, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Fatal(Exception exception, string format, object arg0, object arg1, object arg2);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="args"> An <see cref="object" /> array containing zero or more objects to format. </param>
        void Fatal(Exception exception, IFormatProvider provider, string format, params object[] args);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> A System.Object to format. </param>
        void Fatal(Exception exception, IFormatProvider provider, string format, object arg0);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1);

        /// <summary> Logs a formatted message string with the <see cref="LogLevel.Fatal" /> level. </summary>
        /// <param name="exception"> The exception to log. </param>
        /// <param name="provider"> An <see cref="IFormatProvider" /> which provides culture-specific formatting capabilities. </param>
        /// <param name="format"> A composite format string that contains placeholders for the arguments. </param>
        /// <param name="arg0"> The first System.Object to format. </param>
        /// <param name="arg1"> The second System.Object to format. </param>
        /// <param name="arg2"> The third System.Object to format. </param>
        void Fatal(Exception exception, IFormatProvider provider, string format, object arg0, object arg1, object arg2);

        #endregion

        #region Logging Level Checks

        /// <summary> Can be used to decide whether or not to write <see cref="LogLevel.Debug" /> level messages. </summary>
        bool IsDebugEnabled { get; }

        /// <summary> Can be used to decide whether or not to write <see cref="LogLevel.Info" /> level messages. </summary>
        bool IsInfoEnabled { get; }

        /// <summary> Can be used to decide whether or not to write <see cref="LogLevel.Warn" /> level messages. </summary>
        bool IsWarnEnabled { get; }

        /// <summary> Can be used to decide whether or not to write <see cref="LogLevel.Error" /> level messages. </summary>
        bool IsErrorEnabled { get; }

        /// <summary> Can be used to decide whether or not to write <see cref="LogLevel.Fatal" /> level messages. </summary>
        bool IsFatalEnabled { get; }

        #endregion

        #region NDC

        /// <summary> Pushes a new context message on to the stack implementation of the underlying logger. </summary>
        /// <param name="message"> The new context message. </param>
        /// <returns> An IDisposable reference to the stack. </returns>
        IDisposable Push(string message);

        /// <summary> Pops a context message off of the stack implementation of the underlying logger. </summary>
        /// <returns> The context message that was on the top of the stack. </returns>
        string Pop();

        /// <summary> Clears all the contextual information held on the stack implementation of the underlying logger. </summary>
        void ClearNdc();

        #endregion

        #region MDC

        /// <summary> Add an entry to the contextual properties of the underlying logger. </summary>
        /// <param name="key"> The key to store the value under. </param>
        /// <param name="value"> The value to store. </param>
        void Set(string key, string value);

        /// <summary> Gets the context value identified by the <paramref name="key" /> parameter. </summary>
        /// <param name="key"> The key to lookup in the underlying logger. </param>
        /// <returns> The value of the named context property. </returns>
        string Get(string key);

        /// <summary> Removes the key value mapping for the key specified. </summary>
        /// <param name="key"> The key to remove. </param>
        void Remove(string key);

        /// <summary> Clear all entries in the underlying logger. </summary>
        void ClearMdc();

        #endregion
    }
}