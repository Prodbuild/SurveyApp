using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using EnrollmentWorkflow.Enums;

namespace EnrollmentWorkflow.Helpers
{
    public static class SelectListHelper
    {
        public static IEnumerable<SelectListItem> ToSelectList<T>(string initialOptionText = "")
            where T : struct
        {
            if (!typeof(T).IsEnum)
                throw new InvalidOperationException(typeof(T) + " is not a valid enumeration");

            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Text = initialOptionText,
                Value = String.Empty,
                Selected = true
            });
            
            selectList.AddRange((EnumToList<T>()
                                    .Select(value => new SelectListItem
                                    {
                                        Value = value.ToString(),
                                        Text = GetEnumStringValue(value)

                                    })));

            return selectList;
        }

        public static string GetEnumStringValue(object value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            EnumStringValueAttribute[] attributes =
                (EnumStringValueAttribute[])fi.GetCustomAttributes(typeof(EnumStringValueAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Value;
            else
                return value.ToString();
        }

        public static WorkItemStatus GetEnumFromString(string value)
        {
            foreach (WorkItemStatus status in Enum.GetValues(typeof(WorkItemStatus)))
            {
                FieldInfo fi = typeof(WorkItemStatus).GetField(status.ToString());
                EnumStringValueAttribute[] attributes = (EnumStringValueAttribute[])fi.GetCustomAttributes(typeof(EnumStringValueAttribute), false);
                string strValue = attributes.Length > 0 ? attributes[0].Value : status.ToString();

                if (strValue.Equals(value, StringComparison.OrdinalIgnoreCase))
                    return status;
            }

            throw new ArgumentException("Could not find value.");
        }

        public static bool TryParseWorkItemStatus(string value, out WorkItemStatus? convertedWorkItemStatus)
        {
            convertedWorkItemStatus = null;
            bool isWorkItemSuccessfullyConverted = false;

            foreach (WorkItemStatus status in Enum.GetValues(typeof(WorkItemStatus)))
            {
                FieldInfo fi = typeof(WorkItemStatus).GetField(status.ToString());
                EnumStringValueAttribute[] attributes = (EnumStringValueAttribute[])fi.GetCustomAttributes(typeof(EnumStringValueAttribute), false);
                string strValue = attributes.Length > 0 ? attributes[0].Value : status.ToString();

                if (strValue.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    convertedWorkItemStatus = status;
                    isWorkItemSuccessfullyConverted = true;
                    break;
                }
            }

            return isWorkItemSuccessfullyConverted;
        }

        public static IEnumerable<T> EnumToList<T>()
        {
            Type enumType = typeof(T);

            // Can't use generic type constraints on value types,
            // so have to do check like this
            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");

            Array enumValArray = Enum.GetValues(enumType);
            List<T> enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray)
            {
                enumValList.Add((T)Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }
    }
}