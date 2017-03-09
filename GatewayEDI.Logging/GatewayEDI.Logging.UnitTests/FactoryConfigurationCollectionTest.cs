using GatewayEDI.Logging.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for FactoryConfigurationCollectionTest and is intended
    ///to contain all FactoryConfigurationCollectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FactoryConfigurationCollectionTest
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
        ///A test for FactoryConfigurationCollection Constructor
        ///</summary>
        [TestMethod()]
        public void FactoryConfigurationCollectionConstructorTest()
        {
            FactoryConfigurationCollection target = new FactoryConfigurationCollection();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BaseAdd
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void BaseAddTest()
        {
            FactoryConfigurationCollection_Accessor target = new FactoryConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
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
            FactoryConfigurationCollection_Accessor target = new FactoryConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
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
            FactoryConfigurationCollection_Accessor target = new FactoryConfigurationCollection_Accessor(); // TODO: Initialize to an appropriate value
            ConfigurationElement element = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetElementKey(element);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            FactoryConfigurationCollection target = new FactoryConfigurationCollection(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            FactoryConfigurationElement actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
