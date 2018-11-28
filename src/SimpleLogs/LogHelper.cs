using System;

namespace SimpleLogs
{
    public interface ILogHelper
    {
        void Debug(string message, Type type);
        void Info(string message, Type type);
        void Error(object message, Type type, Exception exception);
    }
    
    public class LogHelper : ILogHelper
    {
        #region for di extensions

        public static readonly LogHelper _instance = new LogHelper();
        private static Func<ILogHelper> _resolve = () => _instance;
        public static Func<ILogHelper> Resolve
        {
            get { return _resolve; }
            set { _resolve = value; }
        }

        #endregion

        public void Debug(string message, Type type)
        {
            var loggerManager = this.GetLoggerManager();
            var log = loggerManager.GetLogger(type);
            log.Debug(message);
        }

        public void Info(string message, Type type)
        {
            var loggerManager = this.GetLoggerManager();
            var log = loggerManager.GetLogger(type);
            log.Info(message);
        }

        public void Error(object message, Type type, Exception exception)
        {
            var loggerManager = this.GetLoggerManager();
            var log = loggerManager.GetLogger(type);
            log.Error(message, exception);
        }
    }
}
