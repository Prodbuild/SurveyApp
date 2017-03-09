using System;
using System.Collections.Generic;
using System.Globalization;
using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A resolver that is able to map factories to log names, and resolve them in a hierarchical manner. </summary>
    public class NamedFactoryResolver : IFactoryResolver
    {
        /// <summary> A list of named factories sorted in order of decreasing specificity. </summary>
        private readonly List<NamedFactory> factoryCache;

        /// <summary> An object which is used for locking </summary>
        private object lockObj = new object();

        /// <summary> Creates a new instance of the resolver. </summary>
        public NamedFactoryResolver()
        {
            lock (lockObj)
            {
                factoryCache = new List<NamedFactory>();
            }
        }

        /// <summary> Determines a factory which can create an <see cref="ILog" /> instance based on a request for a named logger. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        public ILogFactory GetFactory(string logName)
        {
            if (logName == null) throw new ArgumentNullException("logName");

            logName = logName.ToLower(CultureInfo.InvariantCulture);
            ILogFactory resolvedFactory;

            lock (lockObj)
            {
                if (factoryCache.Count == 0)
                {
                    return NullLogFactory.Instance;
                }

                // locate the first factory which matches the named logger
                NamedFactory namedFactory = factoryCache.Find(factory => logName.StartsWith(factory.Name.ToLower(CultureInfo.InvariantCulture)));

                if (namedFactory != null)
                {
                    resolvedFactory = namedFactory.Factory;
                }
                else
                {
                    // if there are no matches, use the default log, i.e a log with an empty name

                    // get the least specific factory
                    namedFactory = factoryCache[factoryCache.Count - 1];

                    if (namedFactory.Name == LogManager.DefaultLogName)
                    {
                        // this is the default log. so return the factory
                        resolvedFactory = namedFactory.Factory;
                    }
                    else
                    {
                        // the least specific factory is not a default factory, so we have no other option than to return a null log factory
                        resolvedFactory = NullLogFactory.Instance;
                    }
                }
            }
            return resolvedFactory;
        }

        /// <summary> Checks for the occurrence of a given factory in the internal cache. </summary>
        /// <param name="name"> The log name that was associated with the factory. </param>
        /// <returns> </returns>
        public bool ContainsFactory(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            name = name.ToLower(CultureInfo.InvariantCulture);

            lock (lockObj)
            {
                return factoryCache.Find(nf => nf.Name.ToLower(CultureInfo.InvariantCulture) == name) != null;
            }
        }

        /// <summary> Adds a factory that resolves to the given name. </summary>
        /// <param name="name"> The name that was used to register a given factory. Name comparison is case insensitive. </param>
        /// <param name="factory"> The factory that is associated with the name. </param>
        /// <exception cref="ArgumentException"> If a factory with the same name was already registered. </exception>
        /// <exception cref="ArgumentNullException"> If one of the parameters is a null reference. </exception>
        /// <exc
        public void RegisterFactory(string name, ILogFactory factory)
        {
            if (name == null) throw new ArgumentNullException("name");
            if (factory == null) throw new ArgumentNullException("factory");

            lock (lockObj)
            {
                if (ContainsFactory(name))
                {
                    string message = String.Format("There's already a factory registered by the name '{0}'.", name);
                    throw new ArgumentException(message);
                }

                //register and sort the cache in order of decreasing specificity
                factoryCache.Add(new NamedFactory(name, factory));
                factoryCache.Sort((f1, f2) => f2.Name.Length.CompareTo(f1.Name.Length));
            }
        }

        /// <summary> Removes a previously registered factory from the resolver's internal cache. </summary>
        /// <param name="name"> The name that was used to register the factory. Comparison is case insensitive. </param>
        /// <returns> True if a matching factory was found and removed. </returns>
        public bool DeregisterFactory(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            name = name.ToLower(CultureInfo.InvariantCulture);

            lock (lockObj)
            {
                // locate the first factory which matches the named log
                NamedFactory namedFactory = factoryCache.Find(factory => name == factory.Name.ToLower(CultureInfo.InvariantCulture));
                if (namedFactory != null)
                {
                    factoryCache.Remove(namedFactory);
                    return true;
                }
            }
            return false;
        }
    }
}