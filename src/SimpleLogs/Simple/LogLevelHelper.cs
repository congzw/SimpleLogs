using System;
using System.Configuration;

namespace SimpleLogs.Simple
{
    public class LogLevelHelper
    {
        public static Lazy<LogLevel> LogLevelLazy = new Lazy<LogLevel>(TryReadFromConfig); 

        public static bool IsLevelEnabled(LogLevel current)
        {
            return current >= LogLevelLazy.Value;
        }

        public static string Common_Logs_SimpleLogLevel = "Common.Logs.SimpleLogLevel";
        private static LogLevel TryReadFromConfig()
        {
            var appSetting = ConfigurationManager.AppSettings[Common_Logs_SimpleLogLevel];
            if (!string.IsNullOrWhiteSpace(appSetting))
            {
                LogLevel result;
                var tryParse = LogLevel.TryParse(appSetting, true, out result);
                if (tryParse)
                {
                    return result;
                }
            }
            
            return LogLevel.All;
        }
    }

    public enum LogLevel
    {
        All = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5
    }
}