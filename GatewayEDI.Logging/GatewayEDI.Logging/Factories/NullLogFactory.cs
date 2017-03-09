namespace GatewayEDI.Logging.Factories
{
    /// <summary> A dummy implementation of the <see cref="ILogFactory" /> which simply returns a <see cref="NullLog" /> instance. </summary>
    public sealed class NullLogFactory : ILogFactory
    {
        /// <summary> The shared <see cref="NullLog" /> instance. </summary>
        private readonly ILog logger = NullLog.Instance;

        /// <summary> Obtains an <see cref="ILog" /> instance that is identified by the given name. </summary>
        /// <param name="name"> The logger name. </param>
        /// <returns> An <see cref="ILog" /> instance. </returns>
        public ILog GetLog(string name)
        {
            return logger;
        }

        #region singleton

        /// <summary> Singleton instance. </summary>
        private static readonly NullLogFactory instance = new NullLogFactory();

        /// <summary> Explicit static constructor to tell C# compiler not to mark type as beforefieldint </summary>
        static NullLogFactory()
        {
        }

        /// <summary> Provides access to the singleton instance of the class. </summary>
        public static NullLogFactory Instance
        {
            get { return instance; }
        }

        /// <summary> Private constructor. A reference to the Singleton instance of this class is available through the static <see cref="Instance" /> property. </summary>
        private NullLogFactory()
        {
        }

        #endregion
    }
}