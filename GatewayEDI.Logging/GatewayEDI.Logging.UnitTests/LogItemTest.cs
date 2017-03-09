using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogItemTest and is intended
    ///to contain all LogItemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogItemTest
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
        ///A test for LogItem Constructor
        ///</summary>
        [TestMethod()]
        public void LogItemConstructorTest()
        {
            LogItem target = new LogItem();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            LogItem expected = null; // TODO: Initialize to an appropriate value
            LogItem actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EventId
        ///</summary>
        [TestMethod()]
        public void EventIdTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.EventId = expected;
            actual = target.EventId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Exception
        ///</summary>
        [TestMethod()]
        public void ExceptionTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            Exception expected = null; // TODO: Initialize to an appropriate value
            Exception actual;
            target.Exception = expected;
            actual = target.Exception;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogLevel
        ///</summary>
        [TestMethod()]
        public void LogLevelTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            LogLevel expected = new LogLevel(); // TODO: Initialize to an appropriate value
            LogLevel actual;
            target.LogLevel = expected;
            actual = target.LogLevel;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogName
        ///</summary>
        [TestMethod()]
        public void LogNameTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LogName = expected;
            actual = target.LogName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Message
        ///</summary>
        [TestMethod()]
        public void MessageTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Message = expected;
            actual = target.Message;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Timestamp
        ///</summary>
        [TestMethod()]
        public void TimestampTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            DateTimeOffset expected = new DateTimeOffset(); // TODO: Initialize to an appropriate value
            DateTimeOffset actual;
            target.Timestamp = expected;
            actual = target.Timestamp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Title
        ///</summary>
        [TestMethod()]
        public void TitleTest()
        {
            LogItem target = new LogItem(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Title = expected;
            actual = target.Title;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
