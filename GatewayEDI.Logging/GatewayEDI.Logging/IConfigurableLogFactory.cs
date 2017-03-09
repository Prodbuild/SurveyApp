namespace GatewayEDI.Logging
{
    /// <summary> Common interface for logger factories that can be initialized with custom configuration data. </summary>
    public interface IConfigurableLogFactory : ILogFactory
    {
        /// <summary> Inits the plug-in with configured factory data. </summary>
        /// <param name="factoryData"> Retrieved factory settings. This parameter is null if no configuration at all was found. </param>
        void Init(string factoryData);
    }
}