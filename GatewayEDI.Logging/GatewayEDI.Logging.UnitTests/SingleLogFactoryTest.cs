using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for SingleLogFactoryTest and is intended
    ///to contain all SingleLogFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SingleLogFactoryTest
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
        ///A test for SingleLogFactory Constructor
        ///</summary>
        [TestMethod()]
        public void SingleLogFactoryConstructorTest()
        {
            SingleLogFactory target = new SingleLogFactory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Init
        ///</summary>
        [TestMethod()]
        public void InitTest()
        {
            SingleLogFactory target = new SingleLogFactory(); // TODO: Initialize to an appropriate value
            string factoryData = string.Empty; // TODO: Initialize to an appropriate value
            target.Init(factoryData);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DiagnosticLog
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void DiagnosticLogTest()
        {
            SingleLogFactory_Accessor target = new SingleLogFactory_Accessor(); // TODO: Initialize to an appropriate value
            ILog actual;
            actual = target.DiagnosticLog;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
