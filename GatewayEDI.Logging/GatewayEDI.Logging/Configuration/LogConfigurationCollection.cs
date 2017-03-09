using System.Configuration;

namespace GatewayEDI.Logging.Configuration
{
    /// <summary> Represents a collection of <see cref="LogConfigurationElement" /> instances in an application configuration file. </summary>
    public class LogConfigurationCollection : ConfigurationElementCollection
    {
        /// <summary> Log instance </summary>
        protected ILog DiagnosticLog
        {
            get { return LogManager.GetDiagnosticLog(GetType().FullName); }
        }

        /// <summary> Gets a <see cref="LogConfigurationElement" /> at a given index. </summary>
        public LogConfigurationElement this[int index]
        {
            get { return (LogConfigurationElement) BaseGet(index); }
        }

        /// <summary> Adds the given element to the collection. </summary>
        /// <param name="element"> </param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            try
            {
                // check whether a factory config of this name was already added.
                bool add = true;
                LogConfigurationElement logConfigElement = element as LogConfigurationElement;
                foreach (LogConfigurationElement existingElement in this)
                {
                    if (existingElement.LogName.ToLowerInvariant() == logConfigElement.LogName.ToLowerInvariant())
                    {
                        DiagnosticLog.Warn("An error occured while loading the Log Configuration elements. Please ensure that all logs have unique names.");
                        add = false;
                    }
                }

                if (add)
                {
                    base.BaseAdd(element);
                }
            }
            catch (ConfigurationErrorsException e)
            {
                DiagnosticLog.Warn(e, "An error occured while loading the Log Configuration elements. Please ensure that all logs have unique names.");
            }
        }

        /// <summary> Creates a new  <see cref="LogConfigurationElement" /> instance. </summary>
        protected override ConfigurationElement CreateNewElement()
        {
            return new LogConfigurationElement();
        }

        /// <summary> Gets the value of the property of the given <see cref="LogConfigurationElement" /> instance that has been designated as the key. </summary>
        /// <param name="element"> </param>
        /// <returns> </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LogConfigurationElement) element).LogName;
        }
    }
}