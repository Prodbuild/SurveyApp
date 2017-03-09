using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CompositeLogTest and is intended
    ///to contain all CompositeLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CompositeLogTest
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
        ///A test for Logs
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LogsTest()
        {
            CompositeLog_Accessor target = new CompositeLog_Accessor(); // TODO: Initialize to an appropriate value
            List<ILog> expected = null; // TODO: Initialize to an appropriate value
            List<ILog> actual;
            target.Logs = expected;
            actual = target.Logs;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            CompositeLog target = new CompositeLog(); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CompositeLog Constructor
        ///</summary>
        [TestMethod()]
        public void CompositeLogConstructorTest()
        {
            CompositeLog target = new CompositeLog();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompositeLog Constructor
        ///</summary>
        [TestMethod()]
        public void CompositeLogConstructorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            CompositeLog target = new CompositeLog(name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompositeLog Constructor
        ///</summary>
        [TestMethod()]
        public void CompositeLogConstructorTest2()
        {
            ILog[] logs = null; // TODO: Initialize to an appropriate value
            CompositeLog target = new CompositeLog(logs);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompositeLog Constructor
        ///</summary>
        [TestMethod()]
        public void CompositeLogConstructorTest3()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            ILog[] logs = null; // TODO: Initialize to an appropriate value
            CompositeLog target = new CompositeLog(name, logs);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
