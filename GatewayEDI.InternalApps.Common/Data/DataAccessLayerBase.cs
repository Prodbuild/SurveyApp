using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GatewayEDI.Logging;

namespace GatewayEDI.InternalApps.Common.Data
{
    public abstract class DataAccessLayerBase
    {
        protected static readonly ILog log = LogManager.GetLog(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected abstract String DefaultConnectionStringName { get; }

        protected virtual String GetConnectionString()
        {
            return GetConnectionString(DefaultConnectionStringName);
        }

        protected virtual String GetConnectionString(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public virtual SqlCommand GetStoredProcedureCommand(SqlConnection connection, String commandText)
        {
            var rt = connection.CreateCommand();
            rt.CommandText = commandText;
            rt.CommandType = CommandType.StoredProcedure;
            rt.CommandTimeout = 720;

            return rt;
        }

    }
}
