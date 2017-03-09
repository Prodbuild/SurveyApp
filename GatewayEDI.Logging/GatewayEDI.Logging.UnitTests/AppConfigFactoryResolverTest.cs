using GatewayEDI.Logging.Resolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging.Configuration;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for AppConfigFactoryResolverTest and is intended
    ///to contain all AppConfigFactoryResolverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AppConfigFactoryResolverTest
    {


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
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AppConfigFactoryResolver Constructor
        ///</summary>
        [TestMethod()]
        public void AppConfigFactoryResolverConstructorTest()
        {
            AppConfigFactoryResolver target = new AppConfigFactoryResolver();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateFactoryInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateFactoryInstanceTest()
        {
            AppConfigFactoryResolver_Accessor target = new AppConfigFactoryResolver_Accessor(); // TODO: Initialize to an appropriate value
            FactoryConfigurationElement factoryConfiguration = null; // TODO: Initialize to an appropriate value
            ILogFactory expected = null; // TODO: Initialize to an appropriate value
            ILogFactory actual;
            actual = target.CreateFactoryInstance(factoryConfiguration);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            AppConfigFactoryResolver target = new AppConfigFactoryResolver(); // TODO: Initialize to an appropriate value
            target.Load();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadConfiguration
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LoadConfigurationTest()
        {
            AppConfigFactoryResolver_Accessor target = new AppConfigFactoryResolver_Accessor(); // TODO: Initialize to an appropriate value
            LogConfigurationSection configuration = null; // TODO: Initialize to an appropriate value
            target.LoadConfiguration(configuration);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ParseConfiguration
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void ParseConfigurationTest()
        {
            AppConfigFactoryResolver_Accessor target = new AppConfigFactoryResolver_Accessor(); // TODO: Initialize to an appropriate value
            LogConfigurationSection expected = null; // TODO: Initialize to an appropriate value
            LogConfigurationSection actual;
            actual = target.ParseConfiguration();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DiagnosticLog
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void DiagnosticLogTest()
        {
            AppConfigFactoryResolver_Accessor target = new AppConfigFactoryResolver_Accessor(); // TODO: Initialize to an appropriate value
            ILog actual;
            actual = target.DiagnosticLog;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
