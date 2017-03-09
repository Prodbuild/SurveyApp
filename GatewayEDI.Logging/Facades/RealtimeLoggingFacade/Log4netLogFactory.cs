using GatewayEDI.Logging;
using log4net.Config;
using System.IO;
using System.Xml;

namespace RealtimeLoggingFacade
{
    /// <summary>
    /// An implementation of the <see cref="ILogFactory"/> interface which creates <see cref="ILog"/> instances that use the log4net framework as the underlying logging mechanism.
    /// </summary>
    public class Log4netLogFactory : IConfigurableLogFactory
    {
        //static Log4netLogFactory()
        //{
        //    // load the log4net configuration from the application configuration.
        //    XmlConfigurator.Configure();
        //}

        public ILog GetLog(string name)
        {
            return new Log4netLog(log4net.LogManager.GetLogger(name));
        }

        public void Init(string factoryData)
        {
            if (!string.IsNullOrEmpty(factoryData))
            {
                XmlDocument config = new XmlDocument();
                config.LoadXml(factoryData);
                var configFileElement = config.SelectSingleNode("parameters/configFile");
                if (configFileElement != null)
                {
                    var configFileAttribute = configFileElement.Attributes["value"];
                    if (configFileAttribute != null)
                    {
                        string fileName = configFileAttribute.Value;
                        FileInfo configFileName = new FileInfo(fileName);
                        XmlConfigurator.Configure(configFileName);
                        return;
                    }
                }
            }
            // load the log4net configuration from the application configuration.
            XmlConfigurator.Configure();
        }
    }
}
