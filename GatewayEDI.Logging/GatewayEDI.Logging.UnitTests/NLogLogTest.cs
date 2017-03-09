using NLogFacade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NLog;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NLogLogTest and is intended
    ///to contain all NLogLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NLogLogTest
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
        ///A test for NLogLog Constructor
        ///</summary>
        [TestMethod()]
        public void NLogLogConstructorTest()
        {
            Logger log = null; // TODO: Initialize to an appropriate value
            NLogLog target = new NLogLog(log);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for IsLogLevelEnabled
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NLogFacade.dll")]
        public void IsLogLevelEnabledTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NLogLog_Accessor target = new NLogLog_Accessor(param0); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsLogLevelEnabled(level);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            Logger log = null; // TODO: Initialize to an appropriate value
            NLogLog target = new NLogLog(log); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
