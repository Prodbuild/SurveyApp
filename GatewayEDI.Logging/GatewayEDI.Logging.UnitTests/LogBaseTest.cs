using GatewayEDI.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GatewayEDI.Logging.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for LogBaseTest and is intended
    ///to contain all LogBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogBaseTest
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


        internal virtual LogBase CreateLogBase()
        {
            // TODO: Instantiate an appropriate concrete class.
            LogBase target = null;
            return target;
        }

        /// <summary>
        ///A test for Debug
        ///</summary>
        [TestMethod()]
        public void DebugTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest3()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest4()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest5()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Error(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest8()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest9()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest10()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest13()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        ///A test for Error
        ///</summary>
        [TestMethod()]
        public void ErrorTest14()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest15()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest18()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void ErrorTest19()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Error(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest1()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest2()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest3()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest4()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest5()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest6()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Fatal(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest7()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest8()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest9()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest10()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Fatal(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest11()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest12()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Fatal(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest14()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest15()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest16()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Fatal
        ///</summary>
        [TestMethod()]
        public void FatalTest17()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void FatalTest19()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Fatal(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void InfoTest11()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void InfoTest12()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void InfoTest13()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void InfoTest16()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Info(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest17()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Info(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest18()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Info(exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual LogBase_Accessor CreateLogBase_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            LogBase_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for IsLogLevelEnabled
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GatewayEDI.Logging.dll")]
        public void IsLogLevelEnabledTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            LogBase_Accessor target = new LogBase_Accessor(param0); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsLogLevelEnabled(level);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest1()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest2()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest3()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Warn(exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest4()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest5()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Warn(format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest6()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Warn(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest7()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest8()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest9()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest10()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest11()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest12()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest13()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            target.Warn(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest14()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest15()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest16()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Warn(exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest17()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Warn
        ///</summary>
        [TestMethod()]
        public void WarnTest18()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
        public void WarnTest19()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Warn(exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest1()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest2()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest3()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest4()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest5()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Write(level, exception, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest6()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogItem item = null; // TODO: Initialize to an appropriate value
            target.Write(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest7()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest8()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest9()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest10()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Write(level, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest11()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Write(level, provider, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest12()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Write(level, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest13()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object[] args = null; // TODO: Initialize to an appropriate value
            target.Write(level, format, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest14()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Write(level, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest15()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.Write(level, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest16()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            Exception exception = null; // TODO: Initialize to an appropriate value
            target.Write(level, exception);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest17()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            object arg2 = null; // TODO: Initialize to an appropriate value
            target.Write(level, provider, format, arg0, arg1, arg2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest18()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            target.Write(level, provider, format, arg0);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest19()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            LogLevel level = new LogLevel(); // TODO: Initialize to an appropriate value
            IFormatProvider provider = null; // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg0 = null; // TODO: Initialize to an appropriate value
            object arg1 = null; // TODO: Initialize to an appropriate value
            target.Write(level, provider, format, arg0, arg1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsDebugEnabled
        ///</summary>
        [TestMethod()]
        public void IsDebugEnabledTest()
        {
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
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
            LogBase target = CreateLogBase(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsWarnEnabled;
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
            LogBase_Accessor target = new LogBase_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
