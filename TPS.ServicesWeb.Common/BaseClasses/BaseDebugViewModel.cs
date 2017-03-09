using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TPS.ServicesWeb.Common.BaseClasses
{
    public class BaseDebugViewModel
    {
        public string EnvironmentIdentifier { get; set; }
        public string AppPoolIdentity { get; set; }
        public string SitePath { get; set; }
        public AssemblyName MainAssembly { get; set; }
    }
}
