using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatewayEDI.Logging.Configuration;

namespace TPS.ServicesWeb.Common.Configuration
{
    internal class EnvironmentElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = false)]
        public string Name
        {
            get { return base["name"].ToString(); }
            private set { base["name"] = value; }
        }

        [ConfigurationProperty("value", IsRequired = false)]
        public string Value
        {
            get { return base["value"].ToString(); }
        }
    }
}
