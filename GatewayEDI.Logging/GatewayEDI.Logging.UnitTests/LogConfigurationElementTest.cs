using GatewayEDI.Logging.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogConfigurationElementTest and is intended
    ///to contain all LogConfigurationElementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogConfigurationElementTest
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
        ///A test for LogConfigurationElement Constructor
        ///</summary>
        [TestMethod()]
        public void LogConfigurationElementConstructorTest()
        {
            string logName = string.Empty; // TODO: Initialize to an appropriate value
            string factoryName = string.Empty; // TODO: Initialize to an appropriate value
            LogConfigurationElement target = new LogConfigurationElement(logName, factoryName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for LogConfigurationElement Constructor
        ///</summary>
        [TestMethod()]
        public void LogConfigurationElementConstructorTest1()
        {
            LogConfigurationElement target = new LogConfigurationElement();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FactoryName
        ///</summary>
        [TestMethod()]
        public void FactoryNameTest()
        {
            LogConfigurationElement target = new LogConfigurationElement(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FactoryName = expected;
            actual = target.FactoryName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogName
        ///</summary>
        [TestMethod()]
        public void LogNameTest()
        {
            LogConfigurationElement target = new LogConfigurationElement(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LogName = expected;
            actual = target.LogName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
