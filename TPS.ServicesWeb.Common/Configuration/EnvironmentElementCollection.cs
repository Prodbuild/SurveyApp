using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.Configuration
{
    internal class EnvironmentElementCollection : ConfigurationElementCollection
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return base["name"].ToString(); }
            set { base["name"] = value; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new EnvironmentElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((EnvironmentElement)element).Name;
        }

        public EnvironmentElement this[int idx]
        {
            get { return BaseGet(idx) as EnvironmentElement; }
            set
            {
                if (base.BaseGet(idx) != null)
                {
                    base.BaseRemoveAt(idx);
                }
                this.BaseAdd(idx, value);
            }
        }
    }
}
