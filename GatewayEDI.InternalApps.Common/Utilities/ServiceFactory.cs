using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace GatewayEDI.InternalApps.Common.Utilities
{
    public static class ServiceFactory
    {
        public static T GetProxy<T>(string clientEndpointConfig)
        {
            var factory = new ChannelFactory<T>(clientEndpointConfig);

            T channel = factory.CreateChannel();

            return channel;
        }

        public static T GetProxy<T>(Binding binding, string endpointAddress)
        {
            var factory = new ChannelFactory<T>(binding, endpointAddress);

            T channel = factory.CreateChannel();

            return channel;
        }

        public static T GetProxy<T>(string clientEndpointConfig, ClientCredentials credentials)
        {
            var factory = new ChannelFactory<T>(clientEndpointConfig);

            var defaultCredentials = factory.Endpoint.Behaviors.Find<ClientCredentials>();
            factory.Endpoint.Behaviors.Remove(defaultCredentials);
            factory.Endpoint.Behaviors.Add(credentials);

            T channel = factory.CreateChannel();

            return channel;
        }

        public static T GetProxy<T>(Binding binding, string endpointAddress, ClientCredentials credentials)
        {
            var factory = new ChannelFactory<T>(binding, endpointAddress);

            var defaultCredentials = factory.Endpoint.Behaviors.Find<ClientCredentials>();
            factory.Endpoint.Behaviors.Remove(defaultCredentials);
            factory.Endpoint.Behaviors.Add(credentials);

            T channel = factory.CreateChannel();

            return channel;
        }
    }
}
