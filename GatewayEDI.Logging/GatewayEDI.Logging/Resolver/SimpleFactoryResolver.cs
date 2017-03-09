using System;
using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A factory resolver that always returns a given <see cref="ILogFactory" />, which can be set at runtime. </summary>
    public class SimpleFactoryResolver : IFactoryResolver
    {
        private ILogFactory factory = NullLogFactory.Instance;

        /// <summary> Gets or sets the logger factory that is used by this resolver. If a null reference is being assigned, this resolver automatically falls back to a <see cref="NullLogFactory" /> instance. </summary>
        public ILogFactory Factory
        {
            get { return factory; }
            set { factory = value ?? NullLogFactory.Instance; }
        }

        /// <summary> Determines a factory which cab create an <see cref="ILog" /> instance based on a request for a named log. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> This implementation always returns the currently assigned <see cref="Factory" />, regardless of the submitted <paramref name="logName" />. </returns>
        public ILogFactory GetFactory(string logName)
        {
            return factory;
        }

        #region construction

        /// <summary> Initializes a new instance of the resolver, which uses an <see cref="NullLogFactory" /> instance until the <see cref="Factory" /> property is set explicitly. </summary>
        public SimpleFactoryResolver()
        {
        }

        /// <summary> Initializes a new instance of the resolver with the log to be maintained. </summary>
        /// <param name="factory"> The factory to be returned by this resolver's <see cref="GetFactory" /> method. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="factory" /> is a null reference. </exception>
        public SimpleFactoryResolver(ILogFactory factory)
        {
            if (factory == null) throw new ArgumentNullException("factory");
            this.Factory = factory;
        }

        #endregion
    }
}