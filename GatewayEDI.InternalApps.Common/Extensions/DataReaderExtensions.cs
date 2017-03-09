using System;
using System.Data;

namespace GatewayEDI.InternalApps.Common.Extensions
{
    public static class DataReaderExtenstions
    {
        public static string GetString(this IDataReader rdr, string columnName)
        {
            if (rdr != null)
            {
                if (rdr[columnName]!=null && rdr[columnName] != DBNull.Value)
                    return rdr[columnName].ToString().Trim();
            }

            return null;
        }

        public static DateTime? GetNullableDate(this IDataReader rdr, string columnName)
        {
            string sDate = rdr.GetString(columnName);
            if (!string.IsNullOrWhiteSpace(sDate))
            {
                DateTime temp;
                if (DateTime.TryParse(sDate, out temp))
                    return temp;
            }

            return null;
        }

        public static DateTime GetDate(this IDataReader rdr, string columnName)
        {
            DateTime? date = rdr.GetNullableDate(columnName);
            return date != null ? date.Value : DateTime.MinValue;
        }

        public static int? GetNullableInt32(this IDataReader rdr, string columnName)
        {

            var temp2 = rdr.GetString(columnName);

            if (temp2 != null)
            {
                int temp;
                if (int.TryParse(temp2, out temp))
                {
                    return temp;
                }
            }

            return null;
        }

        public static Int32 GetInt32(this IDataReader rdr, string columnName)
        {
            string temp2 = rdr.GetString(columnName);

            if (temp2 != null)
            {
                int temp;
                if (int.TryParse(temp2, out temp))
                {
                    return temp;
                }
            }

            return 0;
        }

        public static Guid? GetGuid(this IDataReader rdr, string columnName)
        {
            string temp2 = rdr.GetString(columnName);

            if (temp2 != null)
            {
                Guid temp;
                if (Guid.TryParse(temp2, out temp))
                {
                    return temp;
                }
            }

            return null;
        }

        public static bool  GetBoolean(this IDataReader rdr, string columnName)
        {
            var temp2 = rdr.GetString(columnName);
            if (temp2 != null)
            {
                bool temp;
                if (bool.TryParse(temp2, out temp))
                    return temp;
            }

            return false;

        }

        public static Decimal GetDecimal(this IDataReader rdr, string columnName)
        {
            string temp2 = rdr.GetString(columnName);

            if (temp2 != null)
            {
                decimal temp;
                if (Decimal.TryParse(temp2, out temp))
                {
                    return temp;
                }
            }

            return 0;
        }

    }
}
