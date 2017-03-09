namespace GatewayEDI.Logging.Factories
{
    /// <summary> Associates a factory with a name which is used to determine whether a request for a named logger resolves to the associated factory. </summary>
    public class NamedFactory
    {
        /// <summary> Creates a factory for creating logs. </summary>
        /// <param name="name"> The name of the factory. </param>
        /// <param name="factory"> The factory to associate with the name. </param>
        public NamedFactory(string name, ILogFactory factory)
        {
            Factory = factory;
            Name = name;
        }

        /// <summary> The ILogFactory object. </summary>
        public ILogFactory Factory { get; private set; }

        /// <summary> The name of the Factory object. </summary>
        public string Name { get; private set; }
    }
}