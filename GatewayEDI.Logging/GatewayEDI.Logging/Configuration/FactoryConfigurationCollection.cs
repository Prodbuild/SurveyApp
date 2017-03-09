using System.Configuration;

namespace GatewayEDI.Logging.Configuration
{
    /// <summary> Extends <see cref="ConfigurationElementCollection" /> in order to support a collection of <see cref="FactoryConfigurationElement" /> elements. </summary>
    public class FactoryConfigurationCollection : ConfigurationElementCollection
    {
        /// <summary> Gets a <see cref="FactoryConfigurationElement" /> at a given index. </summary>
        public FactoryConfigurationElement this[int index]
        {
            get { return (FactoryConfigurationElement) BaseGet(index); }
        }

        /// <summary> Creates a new  <see cref="FactoryConfigurationElement" /> instance. </summary>
        protected override ConfigurationElement CreateNewElement()
        {
            return new FactoryConfigurationElement();
        }

        /// <summary> Adds the given element to the collection. </summary>
        /// <param name="element"> </param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            try
            {
                // check whether a factory config of this name was already added.
                bool add = true;
                FactoryConfigurationElement factoryConfigElement = element as FactoryConfigurationElement;
                foreach (FactoryConfigurationElement existingElement in this)
                {
                    if (existingElement.Name.ToLowerInvariant() == factoryConfigElement.Name.ToLowerInvariant())
                    {
                        ILog log = LogManager.GetDiagnosticLog(GetType().FullName);
                        log.Warn("An error occured while loading the Factory Configuration elements. Please ensure that all factories have unique names.");
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
                ILog log = LogManager.GetDiagnosticLog(GetType().FullName);
                log.Warn(e, "An error occured while loading the Factory Configuration elements. Please ensure that all factories have unique names.");
            }
        }

        /// <summary> Gets the value of the property of the given <see cref="FactoryConfigurationElement" /> instance that has been designated as the key. </summary>
        /// <param name="element"> </param>
        /// <returns> </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FactoryConfigurationElement) element).Name;
        }
    }
}