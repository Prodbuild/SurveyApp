using System;

namespace GatewayEDI.Logging.Factories
{
    /// <summary> A log factory that provides delegate logs with naming support. </summary>
    public class DelegateLogFactory : NamedLogFactoryBase<DelegateLog>
    {
        /// <summary> Creates the factory. </summary>
        /// <param name="logAction"> A delegate that is invoked by the factory's logs, which is supposed to perform the actual logging. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="logAction" /> is a null reference. </exception>
        public DelegateLogFactory(Action<LogItem> logAction)
        {
            if (logAction == null) throw new ArgumentNullException("logAction");
            this.LogAction = logAction;
        }

        /// <summary> A delegate that is invoked by the factory's loggers, which is supposed to perform the actual logging. </summary>
        public Action<LogItem> LogAction { get; private set; }

        /// <summary> Constructs a log with the given name </summary>
        /// <param name="name"> The log name. </param>
        /// <returns> A log with the given name. </returns>
        protected override DelegateLog CreateLog(string name)
        {
            return new DelegateLog(name, LogAction);
        }
    }
}