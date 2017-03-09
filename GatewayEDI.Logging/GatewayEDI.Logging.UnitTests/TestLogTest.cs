using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TestLogTest and is intended
    ///to contain all TestLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TestLogTest
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
        ///A test for TestLog Constructor
        ///</summary>
        [TestMethod()]
        public void TestLogConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            TestLog target = new TestLog(name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TestLog Constructor
        ///</summary>
        [TestMethod()]
        public void TestLogConstructorTest1()
        {
            TestLog target = new TestLog();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            TestLog target = new TestLog(); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            TestLog target = new TestLog(); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoggedItems
        ///</summary>
        [TestMethod()]
        public void LoggedItemsTest()
        {
            TestLog target = new TestLog(); // TODO: Initialize to an appropriate value
            List<LogItem> actual;
            actual = target.LoggedItems;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
