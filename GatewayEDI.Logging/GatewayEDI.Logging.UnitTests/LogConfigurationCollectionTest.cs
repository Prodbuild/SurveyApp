using GatewayEDI.Logging.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogConfigurationCollectionTest and is intended
    ///to contain all LogConfigurationCollectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogConfigurationCollectionTest
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
        ///A test for LogConfigurationCollection Constructor
        ///</summary>
        [TestMethod()]
        public void LogConfigurationCollectionConstructorTest()
        {
            LogConfigurationCollection target = new LogConfigurationCollection();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BaseAdd
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void BaseAddTest()
        {
            LogConfigurationCollection_Accessor target = new LogConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
            ConfigurationElement element = null; // TODO: Initialize to an appropriate value
            target.BaseAdd(element);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateNewElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateNewElementTest()
        {
            LogConfigurationCollection_Accessor target = new LogConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
            ConfigurationElement expected = null; // TODO: Initialize to an appropriate value
            ConfigurationElement actual;
            actual = target.CreateNewElement();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetElementKey
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void GetElementKeyTest()
        {
            LogConfigurationCollection_Accessor target = new LogConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
            ConfigurationElement element = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetElementKey(element);
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
            LogConfigurationCollection_Accessor target = new LogConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
            ILog actual;
            actual = target.DiagnosticLog;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            LogConfigurationCollection target = new LogConfigurationCollection(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            LogConfigurationElement actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
