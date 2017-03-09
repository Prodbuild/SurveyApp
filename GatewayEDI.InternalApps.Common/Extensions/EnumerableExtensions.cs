using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GatewayEDI.InternalApps.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            var table = CreateTable<T>();
            var entityType = typeof(T);
            var properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                var row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// Creates the datatable structure
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>Datatble</returns>
        private static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }

        /// <summary>
        /// Creates the datatable structure from a delimited string
        /// </summary>
        /// <returns>Datatable</returns>
        public static DataTable DelimitedStringToIntTable(this string ids, string tableName, string columnName, char delimiter = ',')
        {

            var rt = new DataTable(tableName);

            rt.Columns.Add(columnName, typeof(Int32));

            var idList = ids.Split(delimiter).Distinct();

            foreach (var id in idList)
            {
                rt.Rows.Add(id);
            }

            return rt;
        }

        /// <summary>
        /// Creates the datatable structure from a delimited string
        /// </summary>
        /// <returns>Datatable</returns>
        public static DataTable DelimitedStringToStringTable(this string ids, string tableName, string columnName, char delimiter = ',')
        {

            var rt = new DataTable(tableName);

            rt.Columns.Add(columnName, typeof(string));

            var idList = ids.Split(delimiter).Distinct();

            foreach (var id in idList)
            {
                rt.Rows.Add(id);
            }

            return rt;
        }




    }
}
