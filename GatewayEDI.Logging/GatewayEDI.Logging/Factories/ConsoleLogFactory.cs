namespace GatewayEDI.Logging.Factories
{
    /// <summary> Factory to log to the console. </summary>
    public class ConsoleLogFactory : NamedLogFactoryBase<ConsoleLog>
    {
        /// <summary> Creates a named log. </summary>
        /// <param name="name"> Name of the log to create. </param>
        /// <returns> A ConsoleLog with the specified name. </returns>
        protected override ConsoleLog CreateLog(string name)
        {
            return new ConsoleLog(name);
        }
    }
}