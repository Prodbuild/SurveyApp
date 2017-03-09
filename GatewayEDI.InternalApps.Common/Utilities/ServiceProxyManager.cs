using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using GatewayEDI.InternalApps.Common.Interfaces;

namespace GatewayEDI.InternalApps.Common.Utilities
{
    public class ServiceProxyManager<T> : IServiceProxyManager<T>, IDisposable
    {
        private bool _disposed;
        private IClientChannel _channel;


        #region Implement IDisposable

        [DebuggerHidden()]
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [DebuggerHidden()]
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this._disposed)
            {
                // If disposing equals true, dispose all managed 
                // and unmanaged resources.
                if (disposing)
                {
                    if (_channel != null)
                    {
                        //Check for Faulted State. If the service throws an exception and the binding type is NOT basicHTTP,
                        //the channel will enter a Faulted State. Calling Close while in a Faulted State will cause a masking
                        //exception. Therefore, Abort should instead be called when in a Faulted State.
                        if (_channel.State == CommunicationState.Faulted)
                            _channel.Abort();
                        else if (_channel.State != CommunicationState.Closed &&
                                 _channel.State != CommunicationState.Closing)
                        {
                            _channel.Close();
                            _channel.Dispose();
                        }
                    }
                }

                // Call the appropriate methods to clean up 
                // unmanaged resources here.
                // If disposing is false, 
                // only the following code is executed.

            }

            _disposed = true;
        }

        // Use C# destructor syntax for finalization code.
        ~ServiceProxyManager()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
        #endregion


        public T GetServiceProxy(string clientEndpointConfig)
        {
            T channel = ServiceFactory.GetProxy<T>(clientEndpointConfig);
            _channel = (IClientChannel)channel;

            return channel;
        }

        public T GetServiceProxy(Binding binding, string endpointAddress)
        {
            T channel = ServiceFactory.GetProxy<T>(binding, endpointAddress);
            _channel = (IClientChannel)channel;

            return channel;
        }

        public T GetServiceProxy(string clientEndpointConfig, ClientCredentials credentials)
        {
            T channel = ServiceFactory.GetProxy<T>(clientEndpointConfig, credentials);
            _channel = (IClientChannel)channel;

            return channel;
        }

        public T GetServiceProxy(Binding binding, string endpointAddress, ClientCredentials credentials)
        {
            T channel = ServiceFactory.GetProxy<T>(binding, endpointAddress, credentials);
            _channel = (IClientChannel)channel;

            return channel;
        }
    }
}
