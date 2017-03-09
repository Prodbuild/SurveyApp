using GatewayEDI.Logging.Resolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for SimpleFactoryResolverTest and is intended
    ///to contain all SimpleFactoryResolverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SimpleFactoryResolverTest
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
        ///A test for SimpleFactoryResolver Constructor
        ///</summary>
        [TestMethod()]
        public void SimpleFactoryResolverConstructorTest()
        {
            ILogFactory factory = null; // TODO: Initialize to an appropriate value
            SimpleFactoryResolver target = new SimpleFactoryResolver(factory);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SimpleFactoryResolver Constructor
        ///</summary>
        [TestMethod()]
        public void SimpleFactoryResolverConstructorTest1()
        {
            SimpleFactoryResolver target = new SimpleFactoryResolver();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetFactory
        ///</summary>
        [TestMethod()]
        public void GetFactoryTest()
        {
            SimpleFactoryResolver target = new SimpleFactoryResolver(); // TODO: Initialize to an appropriate value
            string logName = string.Empty; // TODO: Initialize to an appropriate value
            ILogFactory expected = null; // TODO: Initialize to an appropriate value
            ILogFactory actual;
            actual = target.GetFactory(logName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Factory
        ///</summary>
        [TestMethod()]
        public void FactoryTest()
        {
            SimpleFactoryResolver target = new SimpleFactoryResolver(); // TODO: Initialize to an appropriate value
            ILogFactory expected = null; // TODO: Initialize to an appropriate value
            ILogFactory actual;
            target.Factory = expected;
            actual = target.Factory;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
