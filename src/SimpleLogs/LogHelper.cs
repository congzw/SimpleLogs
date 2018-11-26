using System;
using SimpleLogs.Simple;

namespace SimpleLogs
{
    public class LogHelper
    {
        public static LogHelper Instance = new LogHelper();
        private LogHelper()
        {
        }

        private Func<ILoggerManager> _factory = () => new TraceLoggerManager();
        public void SetLoggerManager(Func<ILoggerManager> factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException();
            }
            _factory = factory;
        }
        public ILoggerManager Resolve()
        {
            return _factory();
        }
        
        public void Debug(string message, Type type)
        {
            var loggerManager = _factory();
            var log = loggerManager.GetLogger(type);
            log.Debug(Prefix + message);
        }

        public void Info(string message, Type type)
        {
            var loggerManager = _factory();
            var log = loggerManager.GetLogger(type);
            log.Info(Prefix + message);
        }

        public void Error(object message, Exception exception, Type type)
        {
            var loggerManager = _factory();
            var log = loggerManager.GetLogger(type);
            log.Error(Prefix + message, exception);
        }


        public string Prefix = "[" + typeof (LogHelper).GuessProjectPrefix() + "] ";
    }
}
