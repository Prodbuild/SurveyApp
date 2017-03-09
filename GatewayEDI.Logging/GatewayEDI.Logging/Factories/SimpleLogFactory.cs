using System;

namespace GatewayEDI.Logging.Factories
{
    /// <summary> A factory implementation that always returns the same <see cref="Log" /> instance.<br />
    ///     Keep in mind that using this factory disables support for named loggers - it will always return the same logger instance, no matter what logger name is submitted. </summary>
    public class SimpleLogFactory : ILogFactory
    {
        private ILog log = NullLog.Instance;

        /// <summary> Initializes a new instance of the factory, which uses an <see cref="NullLog" /> instance until the <see cref="Log" /> property is set explicitly. </summary>
        public SimpleLogFactory()
        {
        }

        /// <summary> Initializes a new instance of the factory with the logger to be maintained by the factory. </summary>
        /// <param name="log"> The logger to be returned by the factory's <see cref="GetLog" /> method. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="log" /> is a null reference. </exception>
        public SimpleLogFactory(ILog log)
        {
            if (log == null) throw new ArgumentNullException("log");
            this.Log = log;
        }

        /// <summary> Gets or sets the log that is being returned by the factory. If a null value is being assigned, the factory falls back to a <see cref="NullLog" /> instance. </summary>
        public ILog Log
        {
            get { return log; }
            set { log = value ?? NullLog.Instance; }
        }

        /// <summary> Obtains an <see cref="ILog" /> instance that is identified by the given name. </summary>
        /// <param name="name"> The log name. </param>
        /// <returns> This factory always returns the currently assigned <see cref="Log" /> property, regardless of the submitted <paramref name="name" />. </returns>
        public ILog GetLog(string name)
        {
            return this.Log;
        }
    }
}