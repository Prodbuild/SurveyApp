using GatewayEDI.Logging.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GatewayEDI.Logging;
using System.Collections.Generic;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NamedLogFactoryBaseTest and is intended
    ///to contain all NamedLogFactoryBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NamedLogFactoryBaseTest
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
        ///A test for CreateLog
        ///</summary>
        public void CreateLogTestHelper<TLog>()
            where TLog : ILog
        {
            // Private Accessor for CreateLog is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for CreateLog is not found. Please rebuild the containing projec" +
                    "t or run the Publicize.exe manually.");
        }

        private void CreateNamedLogFactoryBase()
        {
            // Private Accessor for CreateLog is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for CreateLog is not found. Please rebuild the containing projec" +
                    "t or run the Publicize.exe manually.");
        }

        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void CreateLogTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLo" +
                    "g. Please call CreateLogTestHelper<TLog>() with appropriate type parameters.");
        }

        /// <summary>
        ///A test for GetCachedLogs
        ///</summary>
        public void GetCachedLogsTestHelper<TLog>()
            where TLog : ILog
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NamedLogFactoryBase_Accessor<TLog> target = new NamedLogFactoryBase_Accessor<TLog>(param0); // TODO: Initialize to an appropriate value
            IEnumerable<TLog> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TLog> actual;
            actual = target.GetCachedLogs();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual NamedLogFactoryBase_Accessor<TLog> CreateNamedLogFactoryBase_Accessor<TLog>()
        {
            // TODO: Instantiate an appropriate concrete class.
            NamedLogFactoryBase_Accessor<TLog> target = null;
            return target;
        }

        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void GetCachedLogsTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLo" +
                    "g. Please call GetCachedLogsTestHelper<TLog>() with appropriate type parameters." +
                    "");
        }

        /// <summary>
        ///A test for GetLockObject
        ///</summary>
        public void GetLockObjectTestHelper<TLog>()
            where TLog : ILog
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            NamedLogFactoryBase_Accessor<TLog> target = new NamedLogFactoryBase_Accessor<TLog>(param0); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetLockObject();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void GetLockObjectTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLo" +
                    "g. Please call GetLockObjectTestHelper<TLog>() with appropriate type parameters." +
                    "");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        //public void GetLogTestHelper<TLog>()
        //    where TLog : ILog
        //{
        //    NamedLogFactoryBase<TLog> target = CreateNamedLogFactoryBase<TLog>(); // TODO: Initialize to an appropriate value
        //    string name = string.Empty; // TODO: Initialize to an appropriate value
        //    ILog expected = null; // TODO: Initialize to an appropriate value
        //    ILog actual;
        //    actual = target.GetLog(name);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        [TestMethod()]
        public void GetLogTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLo" +
                    "g. Please call GetLogTestHelper<TLog>() with appropriate type parameters.");
        }
    }
}
