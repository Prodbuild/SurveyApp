using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Diagnostics;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for GEDITraceListenerTest and is intended
    ///to contain all GEDITraceListenerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GEDITraceListenerTest
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
        ///A test for GEDITraceListener Constructor
        ///</summary>
        [TestMethod()]
        public void GEDITraceListenerConstructorTest()
        {
            GEDITraceListener target = new GEDITraceListener();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateFooter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateFooterTest()
        {
            GEDITraceListener_Accessor target = new GEDITraceListener_Accessor(); // TODO: Initialize to an appropriate value
            StringBuilder builder = null; // TODO: Initialize to an appropriate value
            TraceEventCache eventCache = null; // TODO: Initialize to an appropriate value
            target.CreateFooter(builder, eventCache);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateHeader
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateHeaderTest()
        {
            StringBuilder builder = null; // TODO: Initialize to an appropriate value
            string source = string.Empty; // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            GEDITraceListener_Accessor.CreateHeader(builder, source, eventType, id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fail
        ///</summary>
        [TestMethod()]
        public void FailTest()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            string detailMessage = string.Empty; // TODO: Initialize to an appropriate value
            target.Fail(message, detailMessage);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fail
        ///</summary>
        [TestMethod()]
        public void FailTest1()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Fail(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetLevel
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void GetLevelTest()
        {
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            LogLevel expected = new LogLevel(); // TODO: Initialize to an appropriate value
            LogLevel actual;
            actual = GEDITraceListener_Accessor.GetLevel(eventType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOptionEnabled
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void IsOptionEnabledTest()
        {
            GEDITraceListener_Accessor target = new GEDITraceListener_Accessor(); // TODO: Initialize to an appropriate value
            TraceOptions opts = new TraceOptions(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOptionEnabled(opts);
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
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            StringBuilder builder = null; // TODO: Initialize to an appropriate value
            GEDITraceListener_Accessor.Log(eventType, builder);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Log
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void LogTest1()
        {
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            GEDITraceListener_Accessor.Log(level, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceData
        ///</summary>
        [TestMethod()]
        public void TraceDataTest()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            TraceEventCache eventCache = null; // TODO: Initialize to an appropriate value
            string source = string.Empty; // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            object data = null; // TODO: Initialize to an appropriate value
            target.TraceData(eventCache, source, eventType, id, data);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceData
        ///</summary>
        [TestMethod()]
        public void TraceDataTest1()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            TraceEventCache eventCache = null; // TODO: Initialize to an appropriate value
            string source = string.Empty; // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            object[] data = null; // TODO: Initialize to an appropriate value
            target.TraceData(eventCache, source, eventType, id, data);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceEvent
        ///</summary>
        [TestMethod()]
        public void TraceEventTest()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            TraceEventCache eventCache = null; // TODO: Initialize to an appropriate value
            string source = string.Empty; // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.TraceEvent(eventCache, source, eventType, id, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceEvent
        ///</summary>
        [TestMethod()]
        public void TraceEventTest1()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            TraceEventCache eventCache = null; // TODO: Initialize to an appropriate value
            string source = string.Empty; // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.TraceEvent(eventCache, source, eventType, id, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Write(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WriteLine
        ///</summary>
        [TestMethod()]
        public void WriteLineTest()
        {
            GEDITraceListener target = new GEDITraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.WriteLine(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
