using System;
using System.Configuration;

namespace SimpleLogs.Log4Net
{
    public static class LogHelperExtensions
    {
        private static Func<ILoggerManager> _backupFactory = null;

        public static void EnableLog4Net(this ILogHelper helper)
        {
            _backupFactory = helper.GetLoggerManagerFactory();
            helper.SetLoggerManagerFactory(() => new Log4NetLoggerManager());
        }

        public static void DisableLog4Net(this ILogHelper helper)
        {
            if (_backupFactory != null)
            {
                helper.SetLoggerManagerFactory(_backupFactory);
            }
        }
        
        private static string Common_Logs_Log4NetEnabled = "Common.Logs.Log4NetEnabled";
        public static void Init(this ILogHelper helper)
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
