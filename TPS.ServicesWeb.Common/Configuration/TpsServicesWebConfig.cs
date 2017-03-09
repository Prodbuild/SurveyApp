using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.Configuration
{
    public class TpsServicesWebConfig
    {
        protected static Dictionary<string, string> _instances;
        private readonly static string _envIdentifier;
        public const string ConfigSectionName = "tpsServicesWeb";

        static TpsServicesWebConfig()
        {
            _instances = new Dictionary<string, string>();
            
            var configSection = ConfigurationManager.GetSection(ConfigSectionName) as TpsServicesWebConfigurationSection;
            if (configSection != null)
            {
                _envIdentifier = configSection.Identifier;


                _instances = new Dictionary<string, string>();
                foreach (EnvironmentElementCollection envCollection in configSection.Environments)
                {
                    if (envCollection.Name == configSection.Identifier)
                        foreach (EnvironmentElement elem in envCollection)
                        {
                            _instances.Add(elem.Name, elem.Value);
                        }
                }
            }
        }

        public static string GetEnvSetting(string key)
        {
            return _instances[key];
        }

        public static string[] GetEnvKeys()
        {
            return _instances.Keys.ToArray();
        }

        public static string EnvironmentIdentifier
        {
            get { return _envIdentifier; }
        }
    }
}
