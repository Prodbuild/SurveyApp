namespace GatewayEDI.Logging.Factories
{
    /// <summary> </summary>
    public class TestLogFactory : NamedLogFactoryBase<TestLog>
    {
        /// <summary> Creates a log with the specified name. </summary>
        /// <param name="name"> The name of the log. </param>
        /// <returns> The log with the specified name. </returns>
        protected override TestLog CreateLog(string name)
        {
            return new TestLog(name);
        }
    }
}