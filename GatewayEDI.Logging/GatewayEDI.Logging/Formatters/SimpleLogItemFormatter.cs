using System;
using System.Text;

namespace GatewayEDI.Logging
{
    public class SimpleLogItemFormatter : ILogItemFormatter
    {
        /// <summary> Creates a string representation of a given <see cref="LogItem" />. </summary>
        /// <param name="item"> The item to be processed. </param>
        /// <returns> A string representation of the submitted <paramref name="item" />. </returns>
        public string FormatItem(LogItem item)
        {
            StringBuilder builder = new StringBuilder();

            //init entry
            builder.AppendLine();

            int titleLength = Math.Max((item.Title ?? "").Length, 20);
            builder.AppendLine("".PadRight(titleLength, '*'));

            if (!String.IsNullOrEmpty(item.LogName))
            {
                builder.Append(item.LogName + ": ");
            }
            if (!String.IsNullOrEmpty(item.Title))
            {
                builder.AppendLine(item.Title);
            }

            //write timestamp
            builder.AppendLine(item.Timestamp.ToString("G"));

            //write log level
            builder.AppendLine(String.Format("Log Level: {0}\n", item.LogLevel));

            //write IDs
            if (item.EventId.HasValue) builder.AppendLine(String.Format("Event ID = {0}", item.EventId));

            //write message
            builder.AppendLine(item.Message);

            //write error message, if any
            if (item.Exception != null)
            {
                builder.AppendLine("\n--\n");
                builder.AppendLine(item.Exception.ToString());
            }

            //close entry
            builder.AppendLine("".PadRight(titleLength, '*'));
            builder.AppendLine("");

            return builder.ToString();
        }

        #region Singleton

        /// <summary> Singleton instance. </summary>
        private static readonly SimpleLogItemFormatter instance = new SimpleLogItemFormatter();

        /// <summary> Provides access to the singleton instance of the class. </summary>
        public static SimpleLogItemFormatter Instance
        {
            get { return instance; }
        }

        /// <summary> Private constructor. A reference to the Singleton instance of this class is available through the static <see cref="Instance" /> property. </summary>
        private SimpleLogItemFormatter()
        {
        }

        /// <summary> Explicit static constructor to tell C# compiler not to mark type as beforefieldint </summary>
        static SimpleLogItemFormatter()
        {
        }

        #endregion
    }
}