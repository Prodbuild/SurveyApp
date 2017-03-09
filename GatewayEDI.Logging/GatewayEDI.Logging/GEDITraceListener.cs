using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace GatewayEDI.Logging
{
    /// <summary> A trace listener that redirect logging information from Trace to GatewayEDI.Logging. </summary>
    public class GEDITraceListener : TraceListener
    {
        /// <summary> Logs a message to the underlying logger framework. </summary>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <param name="builder"> StringBuilder containing the message to emit. </param>
        protected static void Log(TraceEventType eventType, StringBuilder builder)
        {
            LogLevel level = GetLevel(eventType);
            Log(level, builder.ToString());
        }

        /// <summary> Logs a message to the underlying logger framework. </summary>
        /// <param name="level"> One of the LogLevel enumerator action levels. </param>
        /// <param name="message"> The message to emit. </param>
        protected static void Log(LogLevel level, string message)
        {
            var item = new LogItem { LogLevel = level, Message = message };
            LogManager.GetLog().Write(item);
        }

        #region fail

        /// <summary> Redirects Trace Fail messages to the underlying logging Error implementation. </summary>
        /// <param name="message"> A message to emit. </param>
        /// <param name="detailMessage"> A detailed message to emit. </param>
        public override void Fail(string message, string detailMessage)
        {
            string msg = message + Environment.NewLine + detailMessage;
            Fail(msg);
        }

        /// <summary> Redirects Trace Fail messages to the underlying logging Error implementation. </summary>
        /// <param name="message"> A message to emit. </param>
        public override void Fail(string message)
        {
            Log(LogLevel.Error, message);
        }

        #endregion

        #region write

        /// <summary> Forwards a given message as an information to GatewayEDI.Logging. </summary>
        /// <param name="message"> A message to write. </param>
        public override void Write(string message)
        {
            Log(LogLevel.Info, message);
        }

        /// <summary> Forwards a given message as an information to GatewayEDI.Logging. </summary>
        /// <param name="message"> A message to write. </param>
        public override void WriteLine(string message)
        {
            Log(LogLevel.Info, message + Environment.NewLine);
        }

        #endregion

        #region trace data

        /// <summary> Writes trace information, a data object and event information to the underlying listener specific output. </summary>
        /// <param name="eventCache"> A System.Diagnostics.TraceEventCache object that contains the current process ID, thread ID, and stack trace information. </param>
        /// <param name="source"> A name used to identify the output, typically the name of the application that generated the trace event. </param>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <param name="id"> A numeric identifier for the event. </param>
        /// <param name="data"> The trace data to emit. </param>
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            TraceData(eventCache, source, eventType, id, new[] { data });
        }

        /// <summary> Writes trace information, a data object and event information to the underlying listener specific output. </summary>
        /// <param name="eventCache"> A System.Diagnostics.TraceEventCache object that contains the current process ID, thread ID, and stack trace information. </param>
        /// <param name="source"> A name used to identify the output, typically the name of the application that generated the trace event. </param>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <param name="id"> A numeric identifier for the event. </param>
        /// <param name="data"> An array of objects to emit as data. </param>
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
        {
            if ((Filter == null) || Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
            {
                StringBuilder builder = new StringBuilder();

                //create header
                CreateHeader(builder, source, eventType, id);

                //append data
                if (data != null)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i != 0)
                            builder.Append(", ");
                        if (data[i] != null)
                            builder.Append(data[i].ToString());
                    }
                }

                //create footer
                CreateFooter(builder, eventCache);

                //log full message
                Log(eventType, builder);
            }
        }

        #endregion

        #region trace event

        /// <summary> Writes trace and event information to the underlying listener specific output. </summary>
        /// <param name="eventCache"> A System.Diagnostics.TraceEventCache object that contains the current process ID, thread ID, and stack trace information. </param>
        /// <param name="source"> A name used to identify the output, typically the name of the application that generated the trace event. </param>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <param name="id"> A numeric identifier for the event. </param>
        /// <param name="message"> A message to write. </param>
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
            if ((Filter == null) || Filter.ShouldTrace(eventCache, source, eventType, id, message, null, null, null))
            {
                StringBuilder builder = new StringBuilder();
                CreateHeader(builder, source, eventType, id);
                builder.AppendLine(message);
                CreateFooter(builder, eventCache);

                Log(eventType, builder);
            }
        }

        /// <summary> Writes trace and event information to the underlying listener specific output. </summary>
        /// <param name="eventCache"> A System.Diagnostics.TraceEventCache object that contains the current process ID, thread ID, and stack trace information. </param>
        /// <param name="source"> A name used to identify the output, typically the name of the application that generated the trace event. </param>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <param name="id"> A numeric identifier for the event. </param>
        /// <param name="format"> A format string that contains zero or more format items, which correspond to objects in the args array. </param>
        /// <param name="args"> An object array containing zero or more objects to format. </param>
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
        {
            if ((Filter == null) || Filter.ShouldTrace(eventCache, source, eventType, id, format, args, null, null))
            {
                StringBuilder builder = new StringBuilder();
                CreateHeader(builder, source, eventType, id);
                if (args != null)
                {
                    builder.AppendFormat(CultureInfo.InvariantCulture, format, args);
                    builder.AppendLine();
                }
                else
                {
                    builder.AppendLine(format);
                }
                CreateFooter(builder, eventCache);
                Log(eventType, builder);
            }
        }

        #endregion

        #region create message header / footer

        private static void CreateHeader(StringBuilder builder, string source, TraceEventType eventType, int id)
        {
            builder.AppendFormat(CultureInfo.InvariantCulture, "{0} {1}: {2} : ", new object[] { source, eventType, id });
        }

        private void CreateFooter(StringBuilder builder, TraceEventCache eventCache)
        {
            if (eventCache != null)
            {
                if (IsOptionEnabled(TraceOptions.ProcessId))
                {
                    builder.AppendLine("ProcessId=" + eventCache.ProcessId);
                }

                if (IsOptionEnabled(TraceOptions.LogicalOperationStack))
                {
                    builder.Append("LogicalOperationStack=");
                    Stack logicalOperationStack = eventCache.LogicalOperationStack;
                    bool flag = true;
                    foreach (object obj2 in logicalOperationStack)
                    {
                        if (!flag)
                        {
                            builder.Append(", ");
                        }
                        else
                        {
                            flag = false;
                        }
                        builder.Append(obj2.ToString());
                    }
                    builder.AppendLine(string.Empty);
                }
                if (IsOptionEnabled(TraceOptions.ThreadId))
                {
                    builder.AppendLine("ThreadId=" + eventCache.ThreadId);
                }
                if (IsOptionEnabled(TraceOptions.DateTime))
                {
                    builder.AppendLine("DateTime=" + eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
                }
                if (IsOptionEnabled(TraceOptions.Timestamp))
                {
                    builder.AppendLine("Timestamp=" + eventCache.Timestamp);
                }
                if (IsOptionEnabled(TraceOptions.Callstack))
                {
                    builder.AppendLine("Callstack=" + eventCache.Callstack);
                }
            }
        }

        #endregion

        #region helpers

        /// <summary> Determines if a TraceOptions object is enabled. </summary>
        /// <param name="opts"> TraceOptions object to check. </param>
        /// <returns> True if the option is enabled, otherwise it returns false. </returns>
        private bool IsOptionEnabled(TraceOptions opts)
        {
            return ((opts & TraceOutputOptions) != TraceOptions.None);
        }

        /// <summary> Translate the TraceEventType object to a LogLevel object. </summary>
        /// <param name="eventType"> One of the System.Diagnostics.TraceEventType values specifying the type of event that has caused the trace. </param>
        /// <returns> The equivalent LogLevel </returns>
        private static LogLevel GetLevel(TraceEventType eventType)
        {
            switch (eventType)
            {
                case TraceEventType.Critical:
                    return LogLevel.Fatal;
                case TraceEventType.Error:
                    return LogLevel.Error;
                case TraceEventType.Warning:
                    return LogLevel.Warn;
                case TraceEventType.Verbose:
                    return LogLevel.Debug;
                case TraceEventType.Information:
                case TraceEventType.Start:
                case TraceEventType.Stop:
                case TraceEventType.Suspend:
                case TraceEventType.Resume:
                case TraceEventType.Transfer:
                    return LogLevel.Info;
                default:
                    throw new ArgumentOutOfRangeException("eventType");
            }
        }

        #endregion
    }
}