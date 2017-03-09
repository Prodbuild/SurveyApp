using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.Logging;
using System.Configuration;

namespace BigBrotherFacade
{
    class BigBrotherLogFactory : ILogFactory
    {
        private const string configSectionName = "bigbrother";
        private static BigBrotherConfigurationSection config;
        static BigBrotherLogFactory()
        {
            config = (BigBrotherConfigurationSection)ConfigurationManager.GetSection(configSectionName);
        }

        public ILog GetLog(string name)
        {
            BigBrotherLog log = new BigBrotherLog(config.Server, config.Port, config.RemoteTest, config.Threshold);
            return log;
        }
    }
}
