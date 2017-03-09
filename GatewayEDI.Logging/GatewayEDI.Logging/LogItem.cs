using System;
using System.Xml.Serialization;

namespace GatewayEDI.Logging
{
    /// <summary> Encapsulates logging data that can be submitted to any given <see cref="ILog" /> implementation. </summary>
    public class LogItem
    {
        /// <summary> Inits an new <see cref="LogItem" /> instance which is initialized with default values. </summary>
        public LogItem()
        {
            Title = String.Empty;
            Message = String.Empty;
            LogLevel = LogLevel.Info;
            LogName = String.Empty;
            Timestamp = DateTimeOffset.Now;
        }

        #region clone

        /// <summary> Creates a new <see cref="LogItem" /> that is a copy of the current instance. </summary>
        /// <returns> A new <c> LogItem </c> that is a copy of the current instance. </returns>
        public LogItem Clone()
        {
            LogItem clone = new LogItem
            {
                Title = this.Title,
                Message = this.Message,
                Exception = this.Exception,
                EventId = this.EventId,
                LogLevel = this.LogLevel,
                Timestamp = this.Timestamp,
                LogName = this.LogName
            };
            return clone;
        }

        #endregion

        #region properties

        /// <summary> The logging level, which defaults to <see cref="LogLevel.Info" />. </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary> Date and time of the log entry. If not explicitly set, this property provides the timestamp of the object's creation. </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary> A summarizing title for the logged entry. Defaults to <c> String.Empty </c>. </summary>
        public string Title { get; set; }

        /// <summary> The logged message body. Defaults to <c> String.Empty </c>. </summary>
        public string Message { get; set; }

        /// <summary> The name of the log used to log this item. </summary>
        public string LogName { get; set; }

        /// <summary> Allows to attach an exception to the message. Defaults to <c> null </c>. </summary>
        [XmlIgnore]
        public Exception Exception { get; set; }

        /// <summary> Event number or identifier. Defaults to null. </summary>
        public int? EventId { get; set; }

        #endregion
    }
}