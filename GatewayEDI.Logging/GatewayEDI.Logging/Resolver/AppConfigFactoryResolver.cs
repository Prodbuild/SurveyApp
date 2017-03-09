using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using GatewayEDI.Logging.Configuration;
using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> Resolves factories to be used for log instantiation based on settings taken from the application's default configuration file (<c> App.config </c> or <c> Web.config </c>). </summary>
    public class AppConfigFactoryResolver : NamedFactoryResolver
    {
        /// <summary> The name of the configuration section </summary>
        private const string configSectionName = "gatewayedi.logging";

        public AppConfigFactoryResolver()
        {
            Load();
        }

        /// <summary> A log used to log problems with the underlying configuration of logs and factories. Per default, a <see cref="DebugLog" /> is used. </summary>
        protected ILog DiagnosticLog
        {
            get { return LogManager.GetDiagnosticLog(GetType().FullName); }
        }

        /// <summary> Loads the resolver configuration from the log.config file or the applications App.config file. </summary>
        public virtual void Load()
        {
            LogConfigurationSection config = ParseConfiguration();
            LoadConfiguration(config);
        }

        /// <summary> Parses the application configuration to locate and extract the configuration section </summary>
        private LogConfigurationSection ParseConfiguration()
        {
            string configFileName = "log.config";
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly != null)
            {
                string appFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                configFileName = Path.Combine(appFolder, configFileName);
            }
            //This code is a base for loading from a separate configuration file instead of app.config.
            FileInfo configFile = new FileInfo(configFileName);
            if (configFile.Exists)
            {
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = configFileName;
                try
                {
                    System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                    return (LogConfigurationSection) config.GetSection(configSectionName);
                }
                catch (ConfigurationErrorsException ex)
                {
                    DiagnosticLog.Info(ex);
                    return (LogConfigurationSection) ConfigurationManager.GetSection(configSectionName);
                }
            }
            else
            {
                return (LogConfigurationSection) ConfigurationManager.GetSection(configSectionName);
            }
        }

        /// <summary> Prepares the internal dictionaries and caches for factory requests, but without already creating the factory instances. </summary>
        /// <param name="configuration"> An configuration section that provides configuration settings about factories and loggers. </param>
        protected void LoadConfiguration(LogConfigurationSection configuration)
        {
            // construct the named factories.
            var factories = new Dictionary<string, ILogFactory>();
            if (configuration != null && configuration.Factories != null)
            {
                foreach (FactoryConfigurationElement factoryConfiguration in configuration.Factories)
                {
                    ILogFactory factory = CreateFactoryInstance(factoryConfiguration);

                    if (factories.ContainsKey(factoryConfiguration.Name))
                    {
                        DiagnosticLog.Warn("There are duplicate factories with the name [{0}]", factoryConfiguration.Name);
                    }
                    else
                    {
                        factories.Add(factoryConfiguration.Name, factory);
                    }
                }
            }

            //if there is no default factory, create an implicit entry that resolves to a NullLogFactory
            if (!factories.ContainsKey(LogManager.DefaultLogName))
            {
                factories.Add(LogManager.DefaultLogName, NullLogFactory.Instance);
            }

            //process log configurations
            List<LogConfigurationElement> logConfigurationList = new List<LogConfigurationElement>();
            if (configuration != null && configuration.Logs != null)
            {
                foreach (LogConfigurationElement logConfiguration in configuration.Logs)
                {
                    logConfigurationList.Add(logConfiguration);

                    //make sure a correct factory name is referenced
                    string factoryName = logConfiguration.FactoryName;
                    if (!factories.ContainsKey(factoryName))
                    {
                        const string message = "Declared log configuration '{0}' refers to undeclared log factory '{1}'";
                        DiagnosticLog.Error(message, logConfiguration.LogName, factoryName);

                        // associate with a null logger factory
                        base.RegisterFactory(logConfiguration.LogName, NullLogFactory.Instance);
                    }
                    else
                    {
                        ILogFactory factory = factories[factoryName];
                        base.RegisterFactory(logConfiguration.LogName, factory);
                    }
                }
            }

            // if there is no default log declaration, create one that links to the default factory
            if (logConfigurationList.Find(el => el.LogName == LogManager.DefaultLogName) == null)
            {
                base.RegisterFactory(LogManager.DefaultLogName, factories[LogManager.DefaultLogName]);
            }
        }

        /// <summary> Creates a factory based on a given configuration. If the factory provides invalid information, an error is logged through the internal log, and a <see cref="NullLogFactory" /> returned. </summary>
        /// <param name="factoryConfiguration"> The configuration that provides type information for the <see cref="ILogFactory" /> that is being created. </param>
        /// <returns> Factory instance. </returns>
        private ILogFactory CreateFactoryInstance(FactoryConfigurationElement factoryConfiguration)
        {
            ILogFactory factory = ActivatorHelper.Instantiate<ILogFactory>(factoryConfiguration.Type, DiagnosticLog);

            //if the factory is configurable, invoke its Init method
            IConfigurableLogFactory cf = factory as IConfigurableLogFactory;
            if (cf != null)
            {
                cf.Init(factoryConfiguration.FactoryData);
            }

            if (factory == null)
            {
                factory = NullLogFactory.Instance;
            }

            return factory;
        }
    }
}