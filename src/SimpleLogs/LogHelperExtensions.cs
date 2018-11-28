using System;
using SimpleLogs.Simple;

namespace SimpleLogs
{
    public static class LogHelperExtensions
    {
        private static Func<ILoggerManager> _factory = () => new TraceLoggerManager();
        public static Func<ILoggerManager> GetLoggerManagerFactory(this ILogHelper helper)
        {
            return _factory;
        }

        public static void SetLoggerManagerFactory(this ILogHelper helper, Func<ILoggerManager> factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException();
            }
            _factory = factory;
        }
        
        public static void ResetLoggerManagerFactory(this ILogHelper helper)
        {
            _factory = () => new TraceLoggerManager();
        }

        public static ILoggerManager GetLoggerManager(this ILogHelper helper)
        {
            return _factory();
        }

        public static ILogger GetLogger(this ILogHelper helper, Type type)
        {
            var loggerManager = helper.GetLoggerManager();
            return loggerManager.GetLogger(type);
        }

        public static ILogger GetLogger(this ILogHelper helper, string type)
        {
            var loggerManager = helper.GetLoggerManager();
            return loggerManager.GetLogger(type);
        }
    }
}