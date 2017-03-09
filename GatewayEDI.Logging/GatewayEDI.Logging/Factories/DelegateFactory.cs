namespace GatewayEDI.Logging.Factories
{
    /// <summary> A factory implementation that delegates requests to default and/or named loggers to delegates. </summary>
    public class DelegateFactory : ILogFactory
    {
        /// <summary> Empty default constructor, which causes the factory to return <see cref="NullLog" /> instances if <see cref="GetLog(string)" /> being invoked, until the <see cref="RequestHandler" />
        ///     property is being set. </summary>
        public DelegateFactory()
        {
        }

        /// <summary> Initializes the factory with a delegate that receives requests for named logger instances. </summary>
        /// <param name="requestHandler"> A delegate which is called if the factory's <see cref="GetLog(string)" /> method is being invoked.<br />
        ///     Submitting a null reference causes the factory to return a <see cref="NullLog" /> instance if <see cref="GetLog(string)" /> is being invoked. </param>
        public DelegateFactory(LogRequestHandler requestHandler)
        {
            //null references are being accepted
            RequestHandler = requestHandler;
        }

        /// <summary> A delegate which is called if the factory's <see cref="GetLog(string)" /> method is being invoked.<br />
        ///     Setting the delegate to null (default value) causes the factory to return a <see cref="NullLog" /> instance if <see cref="GetLog(string)" /> is being invoked. </summary>
        public LogRequestHandler RequestHandler { get; set; }

        /// <summary> Obtains an <see cref="ILog" /> instance that is identified by the given name by invoking the <see cref="RequestHandler" /> delegate. If the delegate is not set, a <see cref="NullLog" />
        ///     instance is being returned instead. </summary>
        /// <param name="name"> The log name. </param>
        /// <returns> An <see cref="ILog" /> instance. </returns>
        public ILog GetLog(string name)
        {
            return RequestHandler == null ? NullLog.Instance : RequestHandler(name);
        }
    }
}