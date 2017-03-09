using Log4netFacade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using log4net;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for Log4netLogTest and is intended
    ///to contain all Log4netLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Log4netLogTest
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


        ///// <summary>
        /////A test for Log4netLog Constructor
        /////</summary>
        //[TestMethod()]
        //public void Log4netLogConstructorTest()
        //{
        //    ILog log = null; // TODO: Initialize to an appropriate value
        //    Log4netLog target = new Log4netLog(log);
        //    Assert.Inconclusive("TODO: Implement code to verify target");
        //}

        /// <summary>
        ///A test for IsLogLevelEnabled
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Log4netFacade.dll")]
        public void IsLogLevelEnabledTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Log4netLog_Accessor target = new Log4netLog_Accessor(param0); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsLogLevelEnabled(level);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ///// <summary>
        /////A test for Write
        /////</summary>
        //[TestMethod()]
        //public void WriteTest()
        //{
        //    ILog log = null; // TODO: Initialize to an appropriate value
        //    Log4netLog target = new Log4netLog(log); // TODO: Initialize to an appropriate value
        //    LogItem item = null; // TODO: Initialize to an appropriate value
        //    target.Write(item);
        //    Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //}
    }
}
