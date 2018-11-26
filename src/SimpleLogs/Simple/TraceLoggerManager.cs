using System;

namespace SimpleLogs.Simple
{
    public class TraceLoggerManager : ILoggerManager
    {
        private readonly ILogger _logger = new TraceLogger();

        public ILogger GetLogger<T>()
        {
            return _logger;
        }

        public ILogger GetLogger(Type type)
        {
            return _logger;
        }

        public ILogger GetLogger(string name)
        {
            return _logger;
        }

        public ILogger GetLogger()
        {
            return _logger;
        }
    }
}