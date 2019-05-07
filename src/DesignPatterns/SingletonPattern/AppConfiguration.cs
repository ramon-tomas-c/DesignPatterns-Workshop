using System;

namespace SingletonPattern
{
    /// <summary>
    /// The Singleton class
    /// </summary>
    public class AppConfiguration
    {
        // Lock synchronization object
        private static object syncLock = new object();
        private static AppConfiguration _instance;

        private static string _instanceId;
        private static string _externalUrl;
        private static string _connectionDB;

        // Only accessible from within own class or subclasses
        protected AppConfiguration()
        {
            _instanceId = Guid.NewGuid().ToString();

            // Load Config from whatever source
            
        }

        public static AppConfiguration GetConfigurationSingleton()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked

            
            return _instance;
        }

        public string InstanceId { get => _instanceId; }
        public string ExternalUrl { get => _externalUrl; }
        public string ConnectionDB { get => _connectionDB; }
    }
}
