using System;
using System.Collections.Generic;
using System.Linq;

namespace IPv4Setter
{
    static class Config
    {
        /// <summary>
        /// Dictionary containing loaded config file
        /// </summary>
        private static Dictionary<string, string> source = new Dictionary<string,string>();

        /// <summary>
        /// String containing entire config file
        /// </summary>
        private static string text;

        /// <summary>
        /// Method loading config file
        /// </summary>
        /// <param name="path">Path of existing config file</param>
        public static void Load(string path)
        {
            text = System.IO.File.ReadAllText($@"{path}");

            source = text.Split(';')
                         .Select(x => x.Split('='))
                         .ToDictionary(split => split[0], split => split[1]);
        }

        /// <summary>
        /// Method printing Dictionary in Console output
        /// </summary>
        public static void Print()
        {
            foreach (KeyValuePair<string, string> kvp in source)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }

        /// <summary>
        /// Returns value specified by key
        /// </summary>
        /// <param name="key">dictionary key</param>
        /// <returns>value associated with key</returns>
        public static string GetValue(string key)
        {
            string value;
            source.TryGetValue(key, out value);
            return value;
        }

        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Returns dictionary created from config file</returns>
        public static Dictionary<string, string> Source()
        {
            return source;
        }

        /// <summary>
        /// Sets new value to dictionary and deletes the old one
        /// </summary>
        /// <param name="key">Key of the dictionary</param>
        /// <param name="value">Value of the dictionary</param>
        public static void SetValue(string key, string value)
        {
            source.Remove(key);
            source.Add(key, value);
        }

        /// <summary>
        /// Method saving config to file
        /// </summary>
        /// <param name="path">Path to save config file</param>
        public static void Save(string path)
        {
            string text2 = string.Join(";", source.Select(x => x.Key + "=" + x.Value).ToArray());
            System.IO.File.WriteAllText(path, text2);
        }
    }

}
