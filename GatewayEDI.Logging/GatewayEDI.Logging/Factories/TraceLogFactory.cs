namespace GatewayEDI.Logging.Factories
{
#if !SILVERLIGHT
    /// <summary> Create a log factory to hold logs that redirect Trace entries to the underlying logging mechanism. </summary>
    public class TraceLogFactory : NamedLogFactoryBase<TraceLog>
    {
        /// <summary> Creates a log with a specified name. </summary>
        /// <param name="name"> The name of the log object. </param>
        /// <returns> The log object with the specified name. </returns>
        protected override TraceLog CreateLog(string name)
        {
            return new TraceLog(name);
        }
    }
#endif
}