using System.Collections.Generic;

namespace GatewayEDI.Logging
{
    public static class LogProperties
    {
        private static Dictionary<string, string> properties = new Dictionary<string, string>();
        private static object lockObject = new object();

        public static Dictionary<string, string>.KeyCollection Keys
        {
            get { return properties.Keys; }
        }

        public static void Add(string key, string value)
        {
            lock (lockObject)
            {
                if (properties.ContainsKey(key))
                    properties.Add(key, value);
                else
                    properties[key] = value;
            }
        }

        public static void Remove(string key)
        {
            lock (lockObject)
            {
                properties.Remove(key);
            }
        }

        public static void Clear()
        {
            lock (lockObject)
            {
                properties.Clear();
            }
        }

        public static string Get(string key)
        {
            return properties[key];
        }
    }
}