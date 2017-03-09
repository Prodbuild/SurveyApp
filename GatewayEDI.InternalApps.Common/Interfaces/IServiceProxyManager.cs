namespace GatewayEDI.InternalApps.Common.Interfaces
{
    public interface IServiceProxyManager<T> 
    {
        T GetServiceProxy(string clientEndpointConfig);
    }
}
