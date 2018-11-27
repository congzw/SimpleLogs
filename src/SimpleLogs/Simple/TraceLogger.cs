using System;

namespace SimpleLogs.Simple
{
    public class TraceLogger : ILogger
    {
        //todo filter by config
        public bool IsDebugEnabled
        {
            get { return true; }
        }
        public bool IsInfoEnabled
        {
            get { return true; }
        }
        public bool IsWarnEnabled
        {
            get { return true; }
        }
        public bool IsErrorEnabled
        {
            get { return true; }
        }
        public bool IsFatalEnabled
        {
            get { return true; }
        }

        public string Category { get; set; }

        public static string Prefix = "[" + typeof(TraceLogger).GuessProjectPrefix() + "] ";

        public void Debug(object message)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Debug(object message, Exception exception)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0)
        {
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Info(object message)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Info(object message, Exception exception)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0)
        {
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }
        public void Warn(object message)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Warn(object message, Exception exception)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0)
        {
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Error(object message)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Error(object message, Exception exception)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0)
        {
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Fatal(object message)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Fatal(object message, Exception exception)
        {
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0)
        {
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }
    }
}