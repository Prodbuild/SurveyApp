using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatewayEDI.InternalApps.Common.Utilities
{
    public static class EnumParser
    {
        /// <summary>
        /// Parses a string or a string representation of the enumeration integer into the requested enumeration type.
        /// </summary>
        /// <typeparam name="T">The Enumeration type to parse the string value to.</typeparam>
        /// <param name="value">The value to be parsed. This can be a valid enum name or a string representation of the enum value.</param>
        /// <param name="defaultValue">The default value to be used if parsing fails.</param>
        /// <returns>The enumeration value if parsing is successful, otherwise the specified default value.</returns>
        /// <exception cref="System.ArgumentException">Thrown when the Type parameter is not an Enum type.</exception>
        public static T ParseEnumFromString<T>(string value, T defaultValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Type parameter T must be an enum type.");

            if (string.IsNullOrWhiteSpace(value))
                return defaultValue;

            T temp;
            if (Enum.TryParse(value.Trim(), true, out temp))
            {
                if (Enum.IsDefined(typeof(T), temp))
                    return temp;
            }

            return defaultValue;

        }

        /// <summary>
        /// Parses a string or a string representation of the enumeration integer into the requested enumeration type.
        /// </summary>
        /// <typeparam name="T">The Enumeration type to parse the string value to.</typeparam>
        /// <param name="value">The value to be parsed. This can be a valid enum name or a string representation of the enum value.</param>
        /// <returns>The enumeration value if parsing is successful, otherwise null.</returns>
        /// <exception cref="System.ArgumentException">Thrown when the Type parameter is not an Enum type.</exception>
        public static T? ParseEnumFromString<T>(string value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Type parameter T must be an enum type.");

            if (string.IsNullOrWhiteSpace(value))
                return null;

            T temp;
            if (Enum.TryParse(value.Trim(), true, out temp))
            {
                if (Enum.IsDefined(typeof(T), temp))
                    return temp;
            }

            return null;

        }
    }
}
