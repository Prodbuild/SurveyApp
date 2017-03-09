using System;

namespace GatewayEDI.Logging.Formatters
{
    /// <summary> A simple formatter that forwards formatting requests to its <see cref="FormatHandler" /> delegate. </summary>
    public class DelegateLogItemFormatter : ILogItemFormatter
    {
        private FormatRequestHandler formatHandler;

        /// <summary> Creates the formatter with the delegate that is used to forward formatting requests for <see cref="LogItem" /> instances. </summary>
        /// <param name="formatHandler"> The delegate which is being invoked in order to perform the actual formatting. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="formatHandler" /> is a null reference. </exception>
        public DelegateLogItemFormatter(FormatRequestHandler formatHandler)
        {
            if (formatHandler != null) throw new ArgumentNullException("formatHandler");
            this.FormatHandler = formatHandler;
        }

        /// <summary> The delegate which is being invoked in order to perform the actual formatting for <see cref="LogItem" /> instances. </summary>
        public FormatRequestHandler FormatHandler
        {
            get { return formatHandler; }
            private set { formatHandler = value; }
        }

        /// <summary> Creates a string representation of a given <see cref="LogItem" />. </summary>
        /// <param name="item"> The item to be processed. </param>
        /// <returns> A string representation of the submitted <paramref name="item" />. </returns>
        public string FormatItem(LogItem item)
        {
            return FormatHandler(item);
        }
    }
}