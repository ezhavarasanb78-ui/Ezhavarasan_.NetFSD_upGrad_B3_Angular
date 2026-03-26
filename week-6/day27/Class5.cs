using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;

namespace discon
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public string DatabaseConnectionString { get; set; }
        private ConfigurationManager()
        {
            ApplicationName = "Inventory System";
            Version = "1.0.0";
            DatabaseConnectionString = "Server=LAPTOP-K8EM5KGG;Database=day27;Trusted_Connection=True;";
        }
        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ConfigurationManager();
            }
            return _instance;
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            Console.WriteLine("First Call:");
            Console.WriteLine(config1.ApplicationName);
            Console.WriteLine(config1.Version);
            Console.WriteLine(config1.DatabaseConnectionString);
            Console.WriteLine("\nSecond Call:");
            Console.WriteLine(config2.ApplicationName);
            Console.WriteLine(config2.Version);
            Console.WriteLine(config2.DatabaseConnectionString);
            Console.WriteLine("\nSame Instance: " + (config1 == config2));
            Console.ReadLine();
        }
    }
}
