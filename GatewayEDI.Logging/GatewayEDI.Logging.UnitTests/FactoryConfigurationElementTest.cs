using GatewayEDI.Logging.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for FactoryConfigurationElementTest and is intended
    ///to contain all FactoryConfigurationElementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FactoryConfigurationElementTest
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
        ///A test for FactoryConfigurationElement Constructor
        ///</summary>
        [TestMethod()]
        public void FactoryConfigurationElementConstructorTest()
        {
            FactoryConfigurationElement target = new FactoryConfigurationElement();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for OnDeserializeUnrecognizedElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void OnDeserializeUnrecognizedElementTest()
        {
            FactoryConfigurationElement_Accessor target = new FactoryConfigurationElement_Accessor(); // TODO: Initialize to an appropriate value
            string elementName = string.Empty; // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.OnDeserializeUnrecognizedElement(elementName, reader);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FactoryData
        ///</summary>
        [TestMethod()]
        public void FactoryDataTest()
        {
            FactoryConfigurationElement target = new FactoryConfigurationElement(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FactoryData = expected;
            actual = target.FactoryData;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            FactoryConfigurationElement target = new FactoryConfigurationElement(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Type
        ///</summary>
        [TestMethod()]
        public void TypeTest()
        {
            FactoryConfigurationElement target = new FactoryConfigurationElement(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Type = expected;
            actual = target.Type;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
