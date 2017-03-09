using System;
using System.Xml;

namespace GatewayEDI.Logging.Factories
{
    /// <summary> This factory sub-classes <see cref="SimpleLogFactory" /> adding configuration support via the <see cref="IConfigurableLogFactory" /> interface.<br />
    ///     Keep in mind that using this factory disables support for named loggers - it will always return the same logger instance, no matter what logger name is submitted. Furthermore, this factory will
    ///     *NOT* set the <see cref="ILog.Name" /> property of the logger it creates, so the name will return the logger's default value. </summary>
    /// <example> This factory expects configuraton of the following form:
    ///     <code>
    /// &lt;factory type="GatewayEDI.Logging.Factories.SimpleLoggerFactory, GatewayEDI.Logging"&gt;
    ///   &lt;factory-data&gt;
    ///     &lt;log type="GatewayEDI.ConsoleLog, GatewayEDI.Logging" /&gt;
    ///   &lt;/factory-data&gt;
    /// &lt;/factory&gt;
    /// </code>
    ///     Where the type attribute of the logger element indicates the logger type that this factory returns. </example>
    public class SingleLogFactory : SimpleLogFactory, IConfigurableLogFactory
    {
        protected ILog DiagnosticLog
        {
            get { return LogManager.GetDiagnosticLog(GetType().FullName); }
        }

        /// <summary> Inits the plug-in with configured factory data. </summary>
        /// <param name="factoryData"> Retrieved factory settings. This parameter is null if no configuration at all was found. </param>
        public void Init(string factoryData)
        {
            string logTypeName;

            try
            {
                // load the factoryData XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(factoryData);

                // obtain the logger element and inspect the 'type' attribute
                XmlElement logElement = (XmlElement) xmlDoc.GetElementsByTagName("log")[0];
                XmlAttribute logTypeAttribute = logElement.Attributes[0];
                logTypeName = logTypeAttribute.Value;
            }
            catch (Exception e)
            {
                DiagnosticLog.Error(e, "An exception was thrown while trying to parse the given XML configuration [{0}]",
                    factoryData);
                return;
            }

            ILog log = ActivatorHelper.Instantiate<ILog>(logTypeName, DiagnosticLog);
            if (log != null)
            {
                this.Log = log;
            }
        }
    }
}