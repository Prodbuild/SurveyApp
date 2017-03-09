using System;

namespace GatewayEDI.Logging
{
    /// <summary> Indicates that a logger provides a <see cref="Formatter" /> property, which can be used to plug in a custom <see cref="ILogItemFormatter" /> instance in order to customize logging output. </summary>
    public interface IFormattableLog : ILog
    {
        /// <summary> Gets or sets a given formatter which is used to produce the output of the logger. </summary>
        ILogItemFormatter Formatter { get; }

        /// <summary> Sets a given formatter which is used to produce the output of the logger. </summary>
        /// <param name="formatter"> The formatter to be used in order to create string representations of logged <see cref="LogItem" /> instances. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="formatter" /> is a null reference. </exception>
        void SetFormatter(ILogItemFormatter formatter);
    }
}