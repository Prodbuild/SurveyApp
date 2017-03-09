using System.Configuration;

namespace GatewayEDI.Logging.Configuration
{
    /// <summary> This is the entire configuration section that defines the logging facade. The outer element label is defined in <see cref="Resolver.AppConfigFactoryResolver.configSectionName" />. The inner
    ///     tags are defined in this class with <see cref="factoryCollectionName" /> and <see cref="logCollectionName" /> defining the outermost element labels.
    ///     <see cref="factoryElementName" /> and <see cref="logElementName" /> define the instances of <see cref="ILogFactory" /> and <see cref="ILog" /> items. </summary>
    public class LogConfigurationSection : ConfigurationSection
    {
        private const string factoryCollectionName = "factories";
        private const string logCollectionName = "logs";

        private const string factoryElementName = "factory";
        private const string logElementName = "log";

        /// <summary> The factories specified within the configuration. </summary>
        [ConfigurationProperty(factoryCollectionName, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof (FactoryConfigurationCollection), AddItemName = factoryElementName)]
        public FactoryConfigurationCollection Factories
        {
            get { return (FactoryConfigurationCollection) this[factoryCollectionName]; }
            set { this[factoryCollectionName] = value; }
        }

        /// <summary> The logs specified within the configuration. </summary>
        [ConfigurationProperty(logCollectionName, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof (LogConfigurationCollection), AddItemName = logElementName)]
        public LogConfigurationCollection Logs
        {
            get { return (LogConfigurationCollection) this[logCollectionName]; }
            set { this[logCollectionName] = value; }
        }
    }
}