using System;
using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A factory resolver that provides a simplified API by allowing to directly set the <see cref="ILog" /> instance that is being returned by its internal <see cref="ILogFactory" /> instance.
    ///     <br />
    ///     Use this class in order to provide a simple resolver that does not need to resolve factories or logs for different log names, but always returns the same <see cref="ILog" />. </summary>
    public class SimpleLogResolver : IFactoryResolver
    {
        /// <summary> Internal factory - not exposed. </summary>
        private readonly SimpleLogFactory factory = new SimpleLogFactory();

        /// <summary> Gets or sets the log that is being returned by the factory. If a null value is being assigned, the factory falls back to a <see cref="NullLog" /> instance. </summary>
        public ILog Log
        {
            get { return factory.Log; }
            set { factory.Log = value; }
        }

        /// <summary> Determines a factory which cab create an <see cref="ILog" /> instance based on a request for a named log. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        public ILogFactory GetFactory(string logName)
        {
            return factory;
        }

        #region construction

        /// <summary> Initializes a new instance of the resolver, which uses an <see cref="NullLog" /> instance until the <see cref="Log" /> property is set explicitly. </summary>
        public SimpleLogResolver()
        {
        }

        /// <summary> Initializes a new instance of the resolver with the log to be maintained. </summary>
        /// <param name="log"> The log to be returned by this resolver's factory. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="log" /> is a null reference. </exception>
        public SimpleLogResolver(ILog log)
        {
            if (log == null) throw new ArgumentNullException("log");
            this.Log = log;
        }

        #endregion
    }
}