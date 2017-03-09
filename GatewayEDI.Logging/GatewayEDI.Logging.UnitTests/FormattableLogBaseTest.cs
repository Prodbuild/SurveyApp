using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for FormattableLogBaseTest and is intended
    ///to contain all FormattableLogBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FormattableLogBaseTest
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


        internal virtual FormattableLogBase_Accessor CreateFormattableLogBase_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            FormattableLogBase_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for FormatItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void FormatItemTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            FormattableLogBase_Accessor target = new FormattableLogBase_Accessor(param0); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.FormatItem(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual FormattableLogBase CreateFormattableLogBase()
        {
            // TODO: Instantiate an appropriate concrete class.
            FormattableLogBase target = null;
            return target;
        }

        /// <summary>
        ///A test for SetFormatter
        ///</summary>
        [TestMethod()]
        public void SetFormatterTest()
        {
            FormattableLogBase target = CreateFormattableLogBase(); // TODO: Initialize to an appropriate value
            ILogItemFormatter formatter = null; // TODO: Initialize to an appropriate value
            target.SetFormatter(formatter);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Formatter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void FormatterTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            FormattableLogBase_Accessor target = new FormattableLogBase_Accessor(param0); // TODO: Initialize to an appropriate value
            ILogItemFormatter expected = null; // TODO: Initialize to an appropriate value
            ILogItemFormatter actual;
            target.Formatter = expected;
            actual = target.Formatter;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
