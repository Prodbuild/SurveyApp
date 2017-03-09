using System;
using System.ServiceModel;

namespace EnrollmentWorkflow.Helpers
{
    public class WcfClient<TClient>
        where TClient : ICommunicationObject
    {
        private readonly TClient client;

        private WcfClient(TClient client)
        {
            this.client = client;
        }

        public static WcfClient<TClient> Instantiate(Func<TClient> action)
        {
            return new WcfClient<TClient>(action());
        }

        public void Use(Action<TClient> action)
        {
            try
            {
                client.Open();
                action(client);
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
                throw;
            }
        }

        public TResult Return<TResult>(Func<TClient, TResult> action)
        {
            try
            {
                client.Open();
                TResult result = action(client);
                client.Close();
                return result;
            }
            catch (Exception)
            {
                client.Abort();
                throw;
            }
        }
    }
}