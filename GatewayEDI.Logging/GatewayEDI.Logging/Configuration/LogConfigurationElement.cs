using System.Configuration;

namespace GatewayEDI.Logging.Configuration
{
    /// <summary> Represents a log declaration in an application configuration file. </summary>
    public class LogConfigurationElement : ConfigurationElement
    {
        private const string NameAttribute = "name";

        private const string FactoryNameAttribute = "factory";

        /// <summary> Initializes a new instance of the <see cref="T:System.Configuration.ConfigurationElement" /> class. </summary>
        public LogConfigurationElement()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="T:System.Configuration.ConfigurationElement" /> class. </summary>
        public LogConfigurationElement(string logName, string factoryName)
        {
            LogName = logName;
            FactoryName = factoryName;
        }

        /// <summary> The name of this log. </summary>
        [ConfigurationProperty(NameAttribute, IsRequired = false, DefaultValue = "", IsKey = true)]
        public string LogName
        {
            get { return (string) this[NameAttribute]; }
            set { this[NameAttribute] = value; }
        }

        /// <summary> Refers to the factory to be used. </summary>
        [ConfigurationProperty(FactoryNameAttribute, IsRequired = false, DefaultValue = "", IsKey = false)]
        public string FactoryName
        {
            get { return (string) this[FactoryNameAttribute]; }
            set { this[FactoryNameAttribute] = value; }
        }
    }
}