using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TraceLogFactoryTest and is intended
    ///to contain all TraceLogFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TraceLogFactoryTest
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
        ///A test for TraceLogFactory Constructor
        ///</summary>
        [TestMethod()]
        public void TraceLogFactoryConstructorTest()
        {
            TraceLogFactory target = new TraceLogFactory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateLog
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateLogTest()
        {
            TraceLogFactory_Accessor target = new TraceLogFactory_Accessor(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            TraceLog expected = null; // TODO: Initialize to an appropriate value
            TraceLog actual;
            actual = target.CreateLog(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
