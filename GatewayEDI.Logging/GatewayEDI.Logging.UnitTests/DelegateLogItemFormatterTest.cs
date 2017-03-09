using GatewayEDI.Logging.Formatters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DelegateLogItemFormatterTest and is intended
    ///to contain all DelegateLogItemFormatterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DelegateLogItemFormatterTest
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
        ///A test for DelegateLogItemFormatter Constructor
        ///</summary>
        [TestMethod()]
        public void DelegateLogItemFormatterConstructorTest()
        {
            FormatRequestHandler formatHandler = null; // TODO: Initialize to an appropriate value
            DelegateLogItemFormatter target = new DelegateLogItemFormatter(formatHandler);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FormatItem
        ///</summary>
        [TestMethod()]
        public void FormatItemTest()
        {
            FormatRequestHandler formatHandler = null; // TODO: Initialize to an appropriate value
            DelegateLogItemFormatter target = new DelegateLogItemFormatter(formatHandler); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FormatItem(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FormatHandler
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void FormatHandlerTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DelegateLogItemFormatter_Accessor target = new DelegateLogItemFormatter_Accessor(param0); // TODO: Initialize to an appropriate value
            FormatRequestHandler expected = null; // TODO: Initialize to an appropriate value
            FormatRequestHandler actual;
            target.FormatHandler = expected;
            actual = target.FormatHandler;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
