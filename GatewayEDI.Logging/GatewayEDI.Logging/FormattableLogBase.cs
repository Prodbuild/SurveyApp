using System;

namespace GatewayEDI.Logging
{
    /// <summary> Base class that extends <see cref="LogBase" /> with a custom <see cref="ILogItemFormatter" /> by implementing the <see cref="IFormattableLog" /> interface.<br />
    ///     Derive from this base class if you want to use simple string conversion for logged <see cref="LogItem" /> instances. </summary>
    public abstract class FormattableLogBase : LogBase, IFormattableLog
    {
        private ILogItemFormatter formatter;

        /// <summary> Creates a named log, and uses the default <see cref="SimpleLogItemFormatter" /> to format logged <see cref="LogItem" /> instances. </summary>
        /// <param name="name"> The log name. </param>
        protected FormattableLogBase(string name) : this(name, SimpleLogItemFormatter.Instance)
        {
        }

        /// <summary> Creates the log, and uses the default <see cref="SimpleLogItemFormatter" /> to format logged <see cref="LogItem" /> instances. </summary>
        /// <param name="name"> The log name. </param>
        protected FormattableLogBase() : this(SimpleLogItemFormatter.Instance)
        {
        }

        /// <summary> Creates the log with a given formatter. </summary>
        /// <param name="formatter"> The formatter to be used in order to create string representations of logged <see cref="LogItem" /> instances. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="formatter" /> is a null reference. </exception>
        protected FormattableLogBase(ILogItemFormatter formatter)
            : base()
        {
            SetFormatter(formatter);
        }

        /// <summary> Creates a named log with a given formatter. </summary>
        /// <param name="name"> The log name. </param>
        /// <param name="formatter"> The formatter to be used in order to create string representations of logged <see cref="LogItem" /> instances. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="formatter" /> is a null reference. </exception>
        protected FormattableLogBase(string name, ILogItemFormatter formatter)
            : base(name)
        {
            SetFormatter(formatter);
        }

        /// <summary> Gets a given formatter which is used to produce the output of the logger. </summary>
        /// <exception cref="ArgumentNullException"> If <paramref name="value" />  is a null reference. </exception>
        public ILogItemFormatter Formatter
        {
            get { return formatter; }
            private set { formatter = value; }
        }

        /// <summary> Sets a given formatter which is used to produce the output of the log. </summary>
        /// <param name="formatter"> The formatter to be used in order to create string representations of logged <see cref="LogItem" /> instances. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="formatter" /> is a null reference. </exception>
        public void SetFormatter(ILogItemFormatter formatter)
        {
            if (formatter == null) throw new ArgumentNullException("formatter");
            this.Formatter = formatter;
        }

        /// <summary> Simple helper method which returns the formatted string representation of the submitted <see cref="LogItem" /> by invoking the <see cref="ILogItemFormatter.FormatItem" /> method of the
        ///     assigned <see cref="Formatter" />. </summary>
        /// <param name="item"> The item to be processed. </param>
        /// <returns> Formatted logging data. </returns>
        protected string FormatItem(LogItem item)
        {
            return Formatter.FormatItem(item);
        }
    }
}