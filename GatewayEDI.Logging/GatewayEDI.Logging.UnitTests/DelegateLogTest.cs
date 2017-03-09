using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DelegateLogTest and is intended
    ///to contain all DelegateLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DelegateLogTest
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
        ///A test for DelegateLog Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateLogConstructorTest()
        {
            Action<LogItem> logAction = null; // TODO: Initialize to an appropriate value
            DelegateLog target = new DelegateLog(logAction);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DelegateLog Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateLogConstructorTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Action<LogItem> logAction = null; // TODO: Initialize to an appropriate value
            DelegateLog target = new DelegateLog(name, logAction);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            Action<LogItem> logAction = null; // TODO: Initialize to an appropriate value
            DelegateLog target = new DelegateLog(logAction); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LogAction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LogActionTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DelegateLog_Accessor target = new DelegateLog_Accessor(param0); // TODO: Initialize to an appropriate value
            Action<LogItem> expected = null; // TODO: Initialize to an appropriate value
            Action<LogItem> actual;
            target.LogAction = expected;
            actual = target.LogAction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
