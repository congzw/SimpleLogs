using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SimpleLogs.Simple
{
    public class TraceLoggerManager : ILoggerManager
    {
        private static readonly IDictionary<string, ILogger> Loggers = new ConcurrentDictionary<string, ILogger>(); 

        public ILogger GetLogger<T>()
        {
            return TryGetLogger(typeof(T).FullName);
        }

        public ILogger GetLogger(Type type)
        {
            return TryGetLogger(type.FullName);
        }

        public ILogger GetLogger(string name)
        {
            return TryGetLogger(name);
        }

        public ILogger GetLogger()
        {
            return TryGetLogger(string.Empty);
        }

        private static ILogger TryGetLogger(string category)
        {
            if (!Loggers.ContainsKey(category))
            {
                Loggers[category] = new TraceLogger() { Category = category };
            }
            return Loggers[category];
        }
    }
}