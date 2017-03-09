using System.Collections.Generic;
using System.Globalization;

namespace GatewayEDI.Logging.Factories
{
    /// <summary> A base class for factories which created named log instance. </summary>
    /// <typeparam name="TLog"> The type of log which this factory creates </typeparam>
    public abstract class NamedLogFactoryBase<TLog> : ILogFactory where TLog : ILog
    {
        /// <summary> An object which is used for locking </summary>
        private readonly object lockObj = new object();

        /// <summary> A cache of named loggers </summary>
        private readonly Dictionary<string, TLog> logs = new Dictionary<string, TLog>();

        /// <summary> Obtains an <see cref="ILog" /> instance that is identified by the given name. </summary>
        /// <param name="name"> The log name. If this parameter is a null reference, <see cref="LogManager.DefaultLogName" /> is used instead. </param>
        /// <returns> A factory that can be identified by the given name in the target output for this log. </returns>
        public ILog GetLog(string name)
        {
            if (name == null) name = LogManager.DefaultLogName;
            string lowerName = name.ToLower(CultureInfo.InvariantCulture);

            lock (lockObj)
            {
                TLog namedLog;
                if (!logs.TryGetValue(lowerName, out namedLog))
                {
                    namedLog = CreateLog(name);
                    logs.Add(lowerName, namedLog);
                }
                return namedLog;
            }
        }

        /// <summary> Gets a list of all currently cached logs. </summary>
        /// <remarks> Invoking this method is thread safe. </remarks>
        protected IEnumerable<TLog> GetCachedLogs()
        {
            lock (lockObj)
            {
                return new List<TLog>(logs.Values);
            }
        }

        /// <summary> Gets this class' synchronization token. </summary>
        protected object GetLockObject()
        {
            return lockObj;
        }

        /// <summary> Constructs a log with the given name </summary>
        /// <param name="name"> The log name. </param>
        /// <returns> A log with the given name. </returns>
        protected abstract TLog CreateLog(string name);
    }
}