using System.Text;

namespace GatewayEDI.Logging.Formatters
{
    /// <summary> Simple formatter class, which represents the contents of a given <see cref="LogItem" /> as single-line string. </summary>
    public class SingleLineFormatter : ILogItemFormatter
    {
        /// <summary> Creates a string representation of a given <see cref="LogItem" />. </summary>
        /// <param name="item"> The item to be processed. </param>
        /// <returns> A string representation of the submitted <paramref name="item" />. </returns>
        public string FormatItem(LogItem item)
        {
            StringBuilder message = new StringBuilder();

            if (!string.IsNullOrEmpty(item.LogName))
            {
                message.Append(item.LogName + ": ");
            }

            // if the ILog.Write() methods has been used, EventId and Title may have been set - if so, format these into a single string message.
            if (item.EventId != null)
            {
                message.Append(string.Format("[{0}] ", item.EventId.Value));
            }
            if (!string.IsNullOrEmpty(item.Title))
            {
                message.Append(item.Title).Append(" - ");
            }

            message.Append(item.Message);
            return message.ToString();
        }

        #region Singleton

        /// <summary> Singleton instance. </summary>
        private static readonly SingleLineFormatter instance = new SingleLineFormatter();

        /// <summary> Provides access to the singleton instance of the class. </summary>
        public static SingleLineFormatter Instance
        {
            get { return instance; }
        }

        /// <summary> Private constructor. A reference to the Singleton instance of this class is available through the static <see cref="Instance" /> property. </summary>
        private SingleLineFormatter()
        {
        }

        /// <summary> Explicit static constructor to tell C# compiler not to mark type as beforefieldint </summary>
        static SingleLineFormatter()
        {
        }

        #endregion
    }
}