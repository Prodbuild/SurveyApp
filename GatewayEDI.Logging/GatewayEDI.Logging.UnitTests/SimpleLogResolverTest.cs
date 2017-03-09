using GatewayEDI.Logging.Resolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for SimpleLogResolverTest and is intended
    ///to contain all SimpleLogResolverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SimpleLogResolverTest
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
        ///A test for SimpleLogResolver Constructor
        ///</summary>
        [TestMethod()]
        public void SimpleLogResolverConstructorTest()
        {
            ILog log = null; // TODO: Initialize to an appropriate value
            SimpleLogResolver target = new SimpleLogResolver(log);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SimpleLogResolver Constructor
        ///</summary>
        [TestMethod()]
        public void SimpleLogResolverConstructorTest1()
        {
            SimpleLogResolver target = new SimpleLogResolver();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetFactory
        ///</summary>
        [TestMethod()]
        public void GetFactoryTest()
        {
            SimpleLogResolver target = new SimpleLogResolver(); // TODO: Initialize to an appropriate value
            string logName = string.Empty; // TODO: Initialize to an appropriate value
            ILogFactory expected = null; // TODO: Initialize to an appropriate value
            ILogFactory actual;
            actual = target.GetFactory(logName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Log
        ///</summary>
        [TestMethod()]
        public void LogTest()
        {
            SimpleLogResolver target = new SimpleLogResolver(); // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            target.Log = expected;
            actual = target.Log;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
