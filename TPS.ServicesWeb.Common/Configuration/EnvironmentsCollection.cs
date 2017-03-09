using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.Configuration
{
    internal class EnvironmentsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new EnvironmentElementCollection();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((EnvironmentElementCollection)element).Name;
        }
    }
}
