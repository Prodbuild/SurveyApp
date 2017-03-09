using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BigBrotherFacade
{
    /// <summary>
    /// The configuration section within the application configuration.
    /// </summary>
    public class BigBrotherConfigurationSection : ConfigurationSection
    {
        private const string thresholdAttribute = "threshold";
        private const string remoteTestAttribute = "remoteTest";
        private const string serverAttribute = "server";
        private const string portAttribute = "port";

        [ConfigurationProperty(thresholdAttribute, IsRequired = false, DefaultValue = "ERROR")]
        public string Threshold
        {
            get { return (string)this[thresholdAttribute]; }
            set { this[thresholdAttribute] = value; }
        }

        [ConfigurationProperty(remoteTestAttribute, IsRequired = false, DefaultValue = "rt-elig")]
        public string RemoteTest
        {
            get { return (string)this[remoteTestAttribute]; }
            set { this[remoteTestAttribute] = value; }
        }

        [ConfigurationProperty(serverAttribute, IsRequired = false, DefaultValue = "gsmonitor")]
        public string Server
        {
            get { return (string)this[serverAttribute]; }
            set { this[serverAttribute] = value; }
        }

        [ConfigurationProperty(portAttribute, IsRequired = false, DefaultValue = "1984")]
        public string Port
        {
            get { return (string)this[portAttribute]; }
            set { this[portAttribute] = value; }
        }
    }
}
