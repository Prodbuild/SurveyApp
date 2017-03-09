using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DecoratorLogTest and is intended
    ///to contain all DecoratorLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DecoratorLogTest
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
        ///A test for DecoratorLog Constructor
        ///</summary>
        [TestMethod()]
        public void DecoratorLogConstructorTest()
        {
            ILog log = null; // TODO: Initialize to an appropriate value
            LogFilter filter = null; // TODO: Initialize to an appropriate value
            DecoratorLog target = new DecoratorLog(log, filter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DecoratorLog Constructor
        ///</summary>
        [TestMethod()]
        public void DecoratorLogConstructorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            ILog log = null; // TODO: Initialize to an appropriate value
            LogFilter filter = null; // TODO: Initialize to an appropriate value
            DecoratorLog target = new DecoratorLog(name, log, filter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            ILog log = null; // TODO: Initialize to an appropriate value
            LogFilter filter = null; // TODO: Initialize to an appropriate value
            DecoratorLog target = new DecoratorLog(log, filter); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Filter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void FilterTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DecoratorLog_Accessor target = new DecoratorLog_Accessor(param0); // TODO: Initialize to an appropriate value
            LogFilter expected = null; // TODO: Initialize to an appropriate value
            LogFilter actual;
            target.Filter = expected;
            actual = target.Filter;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Log
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LogTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DecoratorLog_Accessor target = new DecoratorLog_Accessor(param0); // TODO: Initialize to an appropriate value
            ILog expected = null; // TODO: Initialize to an appropriate value
            ILog actual;
            target.Log = expected;
            actual = target.Log;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
