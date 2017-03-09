using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NullLogTest and is intended
    ///to contain all NullLogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NullLogTest
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
        ///A test for NullLog Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void NullLogConstructorTest()
        {
            NullLog_Accessor target = new NullLog_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest1()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest2()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest3()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Debug(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest4()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Debug(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest5()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest6()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest7()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest8()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest9()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Debug(exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest10()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Debug(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest11()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Debug(format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest12()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Debug(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest13()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Debug(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest14()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Debug(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest15()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Debug(provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest16()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Debug(provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest17()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Debug(provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest18()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Debug(format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest19()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Debug(provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Error(provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest1()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Error(format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest2()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Error(provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest3()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest4()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Error(format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest5()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Error(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest6()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Error(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest7()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest8()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Error(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest9()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Error(provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest10()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Error(exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest11()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest12()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest13()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest14()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest15()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Error(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest16()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Error(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest17()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest18()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Error(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest19()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Fatal(provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest1()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest2()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest3()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Fatal(provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest4()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Fatal(provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest5()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Fatal(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest6()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Fatal(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest7()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest8()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest9()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest10()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest11()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest12()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest13()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest14()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest15()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Fatal(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest16()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest17()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest18()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest19()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Info(format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest1()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Info(format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest2()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Info(provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest3()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Info(provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest4()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Info(provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest5()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Info(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest6()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest7()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Info(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest8()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Info(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest9()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Info(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest10()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest11()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest12()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Info(exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest13()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest14()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest15()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Info(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest16()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Info(provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest17()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Info(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest18()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Info(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest19()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Info(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Warn(provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest1()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Warn(format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest2()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest3()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Warn(provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest4()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Warn(provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest5()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Warn(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest6()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Warn(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest7()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Warn(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest8()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Warn(format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest9()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest10()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest11()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest12()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest13()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest14()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest15()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Warn(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest16()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Warn(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest17()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest18()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest19()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Instance
        ///</summary>
        [TestMethod()]
        public void InstanceTest()
        {
            NullLog actual;
            actual = NullLog.Instance;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsDebugEnabled
        ///</summary>
        [TestMethod()]
        public void IsDebugEnabledTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsDebugEnabled;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsErrorEnabled
        ///</summary>
        [TestMethod()]
        public void IsErrorEnabledTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsErrorEnabled;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsFatalEnabled
        ///</summary>
        [TestMethod()]
        public void IsFatalEnabledTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFatalEnabled;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsInfoEnabled
        ///</summary>
        [TestMethod()]
        public void IsInfoEnabledTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsInfoEnabled;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsWarnEnabled
        ///</summary>
        [TestMethod()]
        public void IsWarnEnabledTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsWarnEnabled;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            NullLog_Accessor target = new NullLog_Accessor(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
