using System;
using log4net;

//use customize config file, change this file will auto work with logs, without restart the web! :)
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SimpleLogs.Log4Net
{
    public class Log4NetLoggerManager : ILoggerManager
    {
        public ILogger GetLogger(Type type)
        {
            var logger = LogManager.GetLogger(type);
            return new Log4NetLogger(logger);
        }

        public ILogger GetLogger(string name)
        {
            var logger = LogManager.GetLogger(name);
            return new Log4NetLogger(logger);
        }
    }
}
