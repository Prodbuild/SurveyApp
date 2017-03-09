namespace GatewayEDI.Logging.Factories
{
    /// <summary> Factory to log debug messages. </summary>
    public class DebugLogFactory : NamedLogFactoryBase<DebugLog>
    {
        /// <summary> Creates a named logger that captures Debug messages. </summary>
        /// <param name="name"> Name of the log to create. </param>
        /// <returns> Log object with the specified name. </returns>
        protected override DebugLog CreateLog(string name)
        {
            return new DebugLog(name);
        }
    }
}