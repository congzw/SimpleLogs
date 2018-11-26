using System;
using System.Configuration;

namespace SimpleLogs.Log4Net
{
    public static class LogHelperExtensions
    {
        private static Func<ILoggerManager> _backupFactory = null;

        public static void EnableLog4Net(this LogHelper helper)
        {
            _backupFactory = helper.Resolve;
            helper.SetLoggerManager(() => new Log4NetLoggerManager());
        }

        public static void DisableLog4Net(this LogHelper helper)
        {
            if (_backupFactory != null)
            {
                helper.SetLoggerManager(_backupFactory);
            }
        }
        
        private static string Common_Logs_Log4NetEnabled = "Common.Logs.Log4NetEnabled";
        public static void Init(this LogHelper helper)
        {
            //enabled by config
            var enabled = ConfigurationManager.AppSettings[Common_Logs_Log4NetEnabled];
            if ("true".Equals(enabled, StringComparison.OrdinalIgnoreCase))
            {
                helper.EnableLog4Net();
            }
        }
    }
}
