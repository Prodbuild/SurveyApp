using System;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A resolver that uses a delegate in order to create a requested factory. </summary>
    public class DelegateFactoryResolver : IFactoryResolver
    {
        /// <summary> Creates the resolver based on two resolver functions. </summary>
        /// <param name="requestHandler"> The resolver function that returns a factory which in turn is responsible for creating a given <see cref="ILog" />. </param>
        /// <exception cref="ArgumentNullException"> If <paramref name="requestHandler" /> is a null reference. </exception>
        public DelegateFactoryResolver(FactoryRequestHandler requestHandler)
        {
            if (requestHandler == null) throw new ArgumentNullException("requestHandler");
            this.RequestHandler = requestHandler;
        }

        /// <summary> The resolver function that returns a factory which is responsible for creating a named log. </summary>
        public FactoryRequestHandler RequestHandler { get; private set; }

        /// <summary> Determines a factory which cab create an <see cref="ILog" /> instance based on a request for a named log. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        public ILogFactory GetFactory(string logName)
        {
            return RequestHandler(logName);
        }
    }
}