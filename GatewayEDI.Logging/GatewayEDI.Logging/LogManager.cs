using System;
using GatewayEDI.Logging.Factories;
using GatewayEDI.Logging.Resolver;

namespace GatewayEDI.Logging
{
    /// <summary> Provides a global repository that provides access to <see cref="ILog" /> instances. This class ensures that <see cref="GetLog()" />, <see cref="GetLog(string)" /> and
    ///     <see cref="GetLog(type)" /> methods always return a valid <see cref="ILog" /> instance. If no logger instance can be resolved, the service automatically falls back to a <see cref="NullLog" />
    ///     instance. </summary>
    public static class LogManager
    {
        /// <summary> The name of the default log, which is just an empty string. </summary>
        /// <remarks> This facade supports named logs, meaning that a request for a log with a particular name may return a specific <see cref="ILog" /> instance. This also applies to the default log that is
        ///     being requested through the parameterless <see cref="GetLog()" /> method, which just makes a query for a logger with a name of <see cref="string.Empty" />. string.Empty is not a constant.  It's
        ///     marked as static readonly, so this won't compile if I try to set this to string.Empty. </remarks>
        public const string DefaultLogName = "";

        /// <summary> Non-Silverlight projects: Rely on configuration settings per default in order to make sure declarative configuration in app.config does not require setting the resolver programmatically.
        ///     <br />
        ///     Silverlight: Use the NullLogger per default. </summary>
        private static IFactoryResolver factoryResolver;

        /// <summary> A log factory that maintains internally used diagnostic logs, which log information is something goes wrong within this facade. </summary>
        private static ILogFactory diagnosticLogFactory = new DebugLogFactory();

        /// <summary> Initializes the log manager with a default resolver:<br />
        ///     Non-Silverlight projects: Rely on configuration settings per default in order to make sure declarative configuration in app.config does not require setting the resolver programmatically.<br />
        ///     Silverlight: Use the NullLog per default. </summary>
        static LogManager()
        {
            Reset();
        }

        /// <summary> Provides access to factories for both the default and named logs. </summary>
        public static IFactoryResolver FactoryResolver
        {
            get { return factoryResolver; }
            set { factoryResolver = value ?? NullLogFactoryResolver.Instance; }
        }

        /// <summary> Gets the internal log that is used to output debug information in case something went wrong within this facade. </summary>
        /// <param name="logName"> Requested log name. </param>
        /// <returns> A log that outputs this facade's internal debug information. </returns>
        internal static ILog GetDiagnosticLog(string logName)
        {
            return diagnosticLogFactory.GetLog(logName);
        }

        /// <summary> Provides all means to exchanged the internal factory that is used to manage internal diagnostic log which are returned by <see cref="GetDiagnosticLog" />. </summary>
        /// <param name="factory"> The factory to be plugged in. Submit a null value to reset the factory to its default (a new <see cref="DebugLogFactory" />). </param>
        internal static void SetDiagnosticLogFactory(ILogFactory factory)
        {
            diagnosticLogFactory = factory ?? new DebugLogFactory();
        }

        /// <summary> Discards customizations and resets the configured logger facilities to their defaults. For Silverlight, this means that the service returns <see cref="NullLogger" /> instances for all
        ///     requests. In other environments, the class falls back to loggers that were configured through <c> app.config </c>. </summary>
        public static void Reset()
        {
#if SILVERLIGHT
            factoryResolver = NullLoggerFactoryResolver.Instance;
            #else
            factoryResolver = new AppConfigFactoryResolver();
#endif
        }

        /// <summary> Gets a named  <see cref="ILog" /> instance. This is the logger instance set by the <see cref="SetLog" /> method, or a logger with the specified name if a factory can be resolved that
        ///     returns. </summary>
        /// <param name="name"> The name of the requested logger. If this parameter is a null reference, the <see cref="DefaultLogName" /> will be used instead. </param>
        /// <returns> Always returns a valid <see cref="ILog" /> instance. If no log can be resolved, an instance of <see cref="NullLogger" /> is returned. </returns>
        /// <remarks> This method applies several fallback strategies when trying to determine the requested log. </remarks>
        public static ILog GetLog(string name)
        {
            if (string.IsNullOrEmpty(name)) name = DefaultLogName;

            //the name is used to resolve both the factory...
            ILogFactory factory = FactoryResolver.GetFactory(name);
            if (factory == null) return NullLog.Instance;

            //...and logger instance
            return factory.GetLog(name) ?? NullLog.Instance;
        }

        /// <summary> Gets a default <see cref="ILog" /> instance. This is the log instance set by the <see cref="SetLog" /> method, or a log with a default name if a factory can be resolved through the
        ///     <see cref="FactoryResolver" />. Invoking this method is syntactically equivalent to invoking the <see cref="GetLog(string)" /> method with a log name of <see cref="DefaultLogName" />. </summary>
        /// <param name="type"> The type of the assembly. The Full Name of the assembly is used as the name of the log and factory. If this parameter is a null reference, the <see cref="DefaultLogName" /> will
        ///     be used instead. </param>
        /// <returns> Always returns a valid <see cref="ILog" /> instance. If no logger can be resolved, an instance of <see cref="NullLog" /> is returned. </returns>
        public static ILog GetLog(Type type)
        {
            if (type == null) return GetLog(string.Empty);
            return GetLog(type.FullName);
        }

        /// <summary> Gets a default <see cref="ILog" /> instance. This is the log instance set by the <see cref="SetLog" /> method, or a log with a default name if a factory can be resolved through the
        ///     <see cref="FactoryResolver" />. Invoking this method is syntactically equivalent to invoking the <see cref="GetLog(string)" /> method with a log name of <see cref="DefaultLogName" />. </summary>
        /// <returns> Always returns a valid <see cref="ILog" /> instance. If no logger can be resolved, an instance of <see cref="NullLog" /> is returned. </returns>
        public static ILog GetLog()
        {
            //call overload
            return GetLog(DefaultLogName);
        }

        /// <summary> Plugs in a single <see cref="ILog" /> instance that will be returned for all requests, including requests for named logs (both <see cref="GetLog()" /> and <see cref="GetLog(string)" />
        ///     methods). </summary>
        /// <param name="logImplementation"> The log to be used globally. A null reference is a valid parameter value which resets the service to return a <see cref="NullLog" /> instance. </param>
        /// <remarks> Assigning a log through this method creates a custom <see cref="IFactoryResolver" />. This resolver replaces the current <see cref="FactoryResolver" /> property in order to always return
        ///     the submitted <paramref name="logImplementation" /> if <see cref="GetLog()" /> or <see cref="GetLog(string)" /> is being invoked. </remarks>
        public static void SetLog(ILog logImplementation)
        {
            ILog log = logImplementation ?? NullLog.Instance;
            FactoryResolver = new SimpleLogResolver(log);
        }
    }
}