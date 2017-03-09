namespace GatewayEDI.Logging.Factories
{
    /// <summary> A delegate that is used by the <see cref="DelegateFactory" /> in order to get a named log if its <see cref="DelegateFactory.GetLog(string)" /> method is being invoked. </summary>
    /// <returns> The log implementation that is being resolved based on the request. </returns>
    public delegate ILog LogRequestHandler(string logName);
}