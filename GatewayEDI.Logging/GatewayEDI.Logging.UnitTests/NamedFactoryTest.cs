using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NamedFactoryTest and is intended
    ///to contain all NamedFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NamedFactoryTest
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
        ///A test for NamedFactory Constructor
        ///</summary>
        [TestMethod()]
        public void NamedFactoryConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            ILogFactory factory = null; // TODO: Initialize to an appropriate value
            NamedFactory target = new NamedFactory(name, factory);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Factory
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void FactoryTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NamedFactory_Accessor target = new NamedFactory_Accessor(param0); // TODO: Initialize to an appropriate value
            ILogFactory expected = null; // TODO: Initialize to an appropriate value
            ILogFactory actual;
            target.Factory = expected;
            actual = target.Factory;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void NameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NamedFactory_Accessor target = new NamedFactory_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
