using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogManagerTest and is intended
    ///to contain all LogManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogManagerTest
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
        ///A test for GetDiagnosticLog
        ///</summary>
        [TestMethod()]
        public void GetDiagnosticLogTest()
        {
            string logName = string.Empty; // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            actual = LogManager.GetDiagnosticLog(logName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        [TestMethod()]
        public void GetLogTest()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            actual = LogManager.GetLog(type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        [TestMethod()]
        public void GetLogTest1()
        {
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            actual = LogManager.GetLog();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        [TestMethod()]
        public void GetLogTest2()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            actual = LogManager.GetLog(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            LogManager.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetDiagnosticLogFactory
        ///</summary>
        [TestMethod()]
        public void SetDiagnosticLogFactoryTest()
        {
            ILogFactory factory = null; // TODO: Initialize to an appropriate value
            LogManager.SetDiagnosticLogFactory(factory);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetLog
        ///</summary>
        [TestMethod()]
        public void SetLogTest()
        {
            ILog logImplementation = null; // TODO: Initialize to an appropriate value
            LogManager.SetLog(logImplementation);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FactoryResolver
        ///</summary>
        [TestMethod()]
        public void FactoryResolverTest()
        {
            IFactoryResolver expected = null; // TODO: Initialize to an appropriate value
            IFactoryResolver actual;
            LogManager.FactoryResolver = expected;
            actual = LogManager.FactoryResolver;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
