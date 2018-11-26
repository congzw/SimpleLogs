using System;

namespace SimpleLogs
{
    public interface ILoggerManager
    {
        ILogger GetLogger(Type type);
        ILogger GetLogger(string name);
    }
}