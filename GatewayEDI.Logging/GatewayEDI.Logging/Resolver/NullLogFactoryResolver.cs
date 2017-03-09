using GatewayEDI.Logging.Factories;

namespace GatewayEDI.Logging.Resolver
{
    /// <summary> A resolver that always returns a <see cref="NullLogFactory" />, which in turn creates a <see cref="NullLog" /> instance. </summary>
    public sealed class NullLogFactoryResolver : IFactoryResolver
    {
        /// <summary> The log factory instance. </summary>
        private static readonly ILogFactory factory = NullLogFactory.Instance;

        /// <summary> Determines a factory which cab create an <see cref="ILog" /> instance based on a request for a named log. </summary>
        /// <param name="logName"> The log name. </param>
        /// <returns> A factory which in turn is responsible for creating a given <see cref="ILog" /> implementation. </returns>
        public ILogFactory GetFactory(string logName)
        {
            return factory;
        }

        #region singleton

        /// <summary> Singleton instance. </summary>
        private static readonly NullLogFactoryResolver instance = new NullLogFactoryResolver();

        /// <summary> Explicit static constructor to tell C# compiler not to mark type as beforefieldint </summary>
        static NullLogFactoryResolver()
        {
        }

        /// <summary> Provides access to the singleton instance of the class. </summary>
        public static NullLogFactoryResolver Instance
        {
            get { return instance; }
        }

        /// <summary> Private constructor. A reference to the Singleton instance of this class is available through the static <see cref="Instance" /> property. </summary>
        private NullLogFactoryResolver()
        {
        }

        #endregion
    }
}