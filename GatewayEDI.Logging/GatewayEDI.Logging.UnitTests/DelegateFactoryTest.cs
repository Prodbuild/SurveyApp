using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DelegateFactoryTest and is intended
    ///to contain all DelegateFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DelegateFactoryTest
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
        ///A test for DelegateFactory Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateFactoryConstructorTest()
        {
            LogRequestHandler requestHandler = null; // TODO: Initialize to an appropriate value
            DelegateFactory target = new DelegateFactory(requestHandler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DelegateFactory Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateFactoryConstructorTest1()
        {
            DelegateFactory target = new DelegateFactory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        [TestMethod()]
        public void GetLogTest()
        {
            DelegateFactory target = new DelegateFactory(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            actual = target.GetLog(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RequestHandler
        ///</summary>
        [TestMethod()]
        public void RequestHandlerTest()
        {
            DelegateFactory target = new DelegateFactory(); // TODO: Initialize to an appropriate value
            LogRequestHandler expected = null; // TODO: Initialize to an appropriate value
            LogRequestHandler actual;
            target.RequestHandler = expected;
            actual = target.RequestHandler;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
