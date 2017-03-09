using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A resolver that works upon a single <see cref="DelegateFactory" /> which can be configured with custom delegates in order to resolve a given log.<br />
    ///     This is a convenience class that allows you to quickly configure more complex configuration scenarios through code. </summary>
    public class DelegateResolver : IFactoryResolver
    {
        /// <summary> The underlying logger factory which maintains the assigned delegates. </summary>
        private readonly DelegateFactory factory;

        /// <summary> Empty default constructor, which causes the underlying factory to return <see cref="NullLog" /> instances for <see cref="ILogFactory.GetLog(string)" /> until the
        ///     <see cref="RequestHandler" /> property is being set. </summary>
        public DelegateResolver()
        {
            factory = new DelegateFactory();
        }

        /// <summary> Initializes the underlying factory with delegates that receive requests for both the default and named logs. </summary>
        /// <param name="requestHandler"> A delegate which is called if the underlying factory's <see cref="ILogFactory.GetLog(string)" /> method is being invoked.<br />
        ///     Submitting a null reference causes the underlying factory to return a <see cref="NullLog" /> instance if <see cref="ILogFactory.GetLog(string)" /> is being invoked. </param>
        public DelegateResolver(LogRequestHandler requestHandler)
        {
            //null references are being accepted
            factory = new DelegateFactory(requestHandler);
        }

        /// <summary> A delegate which is called if the factory's <see cref="ILogFactory.GetLog" /> method is being invoked.<br />
        ///     Setting the delegate to null (default value) causes the factory to return a <see cref="NullLog" /> instance if <see cref="ILogFactory.GetLog" /> is being invoked. </summary>
        public LogRequestHandler RequestHandler
        {
            get { return factory.RequestHandler; }
            set { factory.RequestHandler = value; }
        }

        /// <summary> Determines a factory which cab create an <see cref="ILog" /> instance based on a request for a named logger. This method returns a factory that uses the assigned
        ///     <see cref="RequestHandler" /> in order to resolve a logger based on a named request. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        public ILogFactory GetFactory(string logName)
        {
            return factory;
        }
    }
}