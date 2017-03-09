namespace GatewayEDI.Logging
{
    /// <summary> Defines factory methods for obtaining <see cref="ILog" /> instances. These factory methods may create new instances or retrieve cached / pooled instances depending on the the name of the
    ///     requested log. </summary>
    public interface ILogFactory
    {
        /// <summary> Obtains an <see cref="ILog" /> instance that is identified by the given name. </summary>
        /// <param name="name"> The logger name. Submit <see cref="LogManager.DefaultLogName" /> in order to request a default (unnamed) log. </param>
        /// <returns> An <see cref="ILog" /> instance. </returns>
        ILog GetLog(string name);
    }
}