using GatewayEDI.Logging.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogConfigurationSectionTest and is intended
    ///to contain all LogConfigurationSectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogConfigurationSectionTest
    {

        private const string configurationSection = "gatewayedi.logging";
        private FactoryConfigurationElement singleFactory = new FactoryConfigurationElement();
        private LogConfigurationElement singleLog = new LogConfigurationElement();
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            singleFactory.Type = "Log4netFacade.Log4netLogFactory, Log4netFacade";
            singleFactory.Name = "Log4netFactory";

            singleLog.FactoryName = "Log4netFactory";
            singleLog.LogName = "Log4netLog";
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for LogConfigurationSection Constructor
        ///</summary>
        [TestMethod()]
        public void LogConfigurationSectionConstructorTest()
        {
            LogConfigurationSection target = new LogConfigurationSection();
            Assert.IsNotNull(target);
            Assert.IsInstanceOfType(target, typeof(LogConfigurationSection));
        }

        /// <summary>
        ///A test for Factories
        ///</summary>
        [TestMethod()]
        public void FactoriesTest()
        {
            LogConfigurationSection configSection = ConfigurationManager.GetSection(configurationSection) as LogConfigurationSection;
            Assert.IsNotNull(configSection);
            Assert.AreEqual(1, configSection.Factories.Count);
            Assert.AreEqual(singleFactory.Type, configSection.Factories[0].Type);
            Assert.AreEqual(singleFactory.Name, configSection.Factories[0].Name);
        }

        /// <summary>
        ///A test for Logs
        ///</summary>
        [TestMethod()]
        public void LogsTest()
        {
            LogConfigurationSection configSection = ConfigurationManager.GetSection(configurationSection) as LogConfigurationSection;
            Assert.IsNotNull(configSection);
            Assert.AreEqual(1, configSection.Logs.Count);
            Assert.AreEqual(singleLog.LogName, configSection.Logs[0].LogName);
            Assert.AreEqual(singleLog.FactoryName, configSection.Logs[0].FactoryName);
        }
    }
}
