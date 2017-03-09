namespace GatewayEDI.Logging
{
    /// <summary> Responsible for finding and creating <see cref="ILoggerFactory" />
    ///     instances which are being used to create loggers of a given implementation. </summary>
    public interface IFactoryResolver
    {
        /// <summary> Determines a factory which in turn creates an
        ///     <see cref="ILog" /> instance based on a request for a named logger. </summary>
        /// <param name="logName"> The name of the requested logger. This name will also be used to determine the factory that is responsible to create the logger instance. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        ILogFactory GetFactory(string logName);
    }
}