using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.Configuration
{
    internal class TpsServicesWebConfigurationSection : ConfigurationSection
    {
        private const string SettingsCollectionName = "environments";

        /// <summary>
        /// The environments specified within the configuration.
        /// </summary>
        [ConfigurationProperty(SettingsCollectionName, IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(EnvironmentsCollection), AddItemName = "environment")]
        public EnvironmentsCollection Environments
        {
            get { return (EnvironmentsCollection)base[SettingsCollectionName]; }
        }

        /// <summary>
        /// The environment identifier such as DEV, QA, STAGING, or PROD.
        /// This attribute should be set at the root site's web.config
        /// </summary>
        [ConfigurationProperty("identifier")]
        public string Identifier
        {
            get { return base["identifier"].ToString(); }
        }
    }
}
