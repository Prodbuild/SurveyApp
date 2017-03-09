using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;
using GatewayEDI.Logging;
using log4net;
using log4net.Config;
using ILog = GatewayEDI.Logging.ILog;
using LogManager = log4net.LogManager;

namespace Log4netFacade
{
    /// <summary> An implementation of the <see cref="IConfigurableLogFactory" /> interface which creates <see cref="GatewayEDI.Logging.ILog" /> instances that use the log4net framework as the underlying
    ///     logging mechanism. </summary>
    public class Log4netLogFactory : IConfigurableLogFactory
    {
        //static Log4netLogFactory()
        //{
        //    // load the log4net configuration from the application configuration.
        //    XmlConfigurator.Configure();
        //}

        public ILog GetLog(string name)
        {
            return new Log4netLog(LogManager.GetLogger(name));
        }

        /// <summary> Loads the extra configuration items that are necessary for configuring the log4net framework. </summary>
        /// <param name="factoryData"> The innerXml from the &lt;factory-data> element from the configuration section. </param>
        /// <exception cref="System.XmlException"> This means there was a problem with the configuration section. </exception>
        public void Init(string factoryData)
        {
            foreach (string key in LogProperties.Keys)
                GlobalContext.Properties[key] = LogProperties.Get(key);

            GlobalContext.Properties["MachineName"] = Environment.MachineName;
            GlobalContext.Properties["UserName"] = Environment.UserName;
            GlobalContext.Properties["ProcessId"] = Process.GetCurrentProcess().Id;

            if (!string.IsNullOrEmpty(factoryData))
            {
                XmlDocument config = new XmlDocument();
                try
                {
                    config.LoadXml(factoryData);
                    var configFileElement = config.SelectSingleNode("parameters/configFile");
                    if (configFileElement != null)
                    {
                        var configFileAttribute = configFileElement.Attributes["value"];
                        if (configFileAttribute != null)
                        {
                            string fileName = configFileAttribute.Value;
                            if (fileName.StartsWith(".\\"))
                            {
                                string appFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                                fileName = Path.Combine(appFolder, fileName.Replace(".\\", string.Empty));
                            }
                            FileInfo configFileName = new FileInfo(fileName);
                            XmlConfigurator.Configure(configFileName);
                            return;
                        }
                    }
                }
                catch (XmlException)
                {
                    XmlConfigurator.Configure();
                }
            }
            // load the log4net configuration from the application configuration.
            XmlConfigurator.Configure();
        }
    }
}