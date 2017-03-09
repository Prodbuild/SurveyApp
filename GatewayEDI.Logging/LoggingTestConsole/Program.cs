using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.Logging;

namespace LoggingTestConsole
{
    class Program
    {
        private static ILog primaryLog = LogManager.GetLog(typeof(Program));
        private static ILog secondaryLog = LogManager.GetLog(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Program.primaryLog.Debug("primaryLog Debug Message");
            Program.primaryLog.Info("primaryLog Info Message");
            Program.primaryLog.Warn("primaryLog Warn Message");
            Program.primaryLog.Error("primaryLog Error Message");
            Program.primaryLog.Fatal("primaryLog Fatal Message");

            Program.secondaryLog.Debug("secondaryLog Debug Message");
            Program.secondaryLog.Info("secondaryLog Info Message");
            Program.secondaryLog.Warn("secondaryLog Warn Message");
            Program.secondaryLog.Error("secondaryLog Error Message");
            Program.secondaryLog.Fatal("secondaryLog Fatal Message");

            Console.ReadLine();
        }
    }
}
