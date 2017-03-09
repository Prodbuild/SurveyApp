using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DelegateLogFactoryTest and is intended
    ///to contain all DelegateLogFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DelegateLogFactoryTest
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
        ///A test for DelegateLogFactory Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateLogFactoryConstructorTest()
        {
            Action<LogItem> logAction = null; // TODO: Initialize to an appropriate value
            DelegateLogFactory target = new DelegateLogFactory(logAction);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateLog
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateLogTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DelegateLogFactory_Accessor target = new DelegateLogFactory_Accessor(param0); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            DelegateLog expected = null; // TODO: Initialize to an appropriate value
            DelegateLog actual;
            actual = target.CreateLog(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogAction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LogActionTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DelegateLogFactory_Accessor target = new DelegateLogFactory_Accessor(param0); // TODO: Initialize to an appropriate value
            Action<LogItem> expected = null; // TODO: Initialize to an appropriate value
            Action<LogItem> actual;
            target.LogAction = expected;
            actual = target.LogAction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
