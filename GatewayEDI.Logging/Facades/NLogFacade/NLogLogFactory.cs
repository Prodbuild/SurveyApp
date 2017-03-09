using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayEDI.Logging;

namespace NLogFacade
{
    /// <summary>
    /// An implementation of the <see cref="ILogFactory"/> interface which creates <see cref="ILog"/> instances that use the NLog framework as the underlying logging mechanism.
    /// </summary>
    public class NLogLogFactory : ILogFactory
    {
        public ILog GetLog(string name)
        {
            return new NLogLog(NLog.LogManager.GetLogger(name));
        }
    }
}
