using System;

namespace SimpleLogs.Simple
{
    public class TraceLogger : ILogger
    {
        public bool IsDebugEnabled
        {
            get { return LogLevelHelper.IsLevelEnabled(LogLevel.Debug); }
        }
        public bool IsInfoEnabled
        {
            get { return LogLevelHelper.IsLevelEnabled(LogLevel.Info); }
        }
        public bool IsWarnEnabled
        {
            get { return LogLevelHelper.IsLevelEnabled(LogLevel.Warn); }
        }
        public bool IsErrorEnabled
        {
            get { return LogLevelHelper.IsLevelEnabled(LogLevel.Error); }
        }
        public bool IsFatalEnabled
        {
            get { return LogLevelHelper.IsLevelEnabled(LogLevel.Fatal); }
        }

        public string Category { get; set; }

        public static string Prefix = "[" + typeof(TraceLogger).GuessProjectPrefix() + "] ";

        public void Debug(object message)
        {
            if (!IsDebugEnabled)
                return;
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Debug(object message, Exception exception)
        {
            if (!IsDebugEnabled)
                return;

            if (exception != null)
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message + " " + exception.Message, Category);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
            }
        }

        public void DebugFormat(string format, params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0)
        {
            if (!IsDebugEnabled)
                return;
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            if (!IsDebugEnabled)
                return;
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            if (!IsDebugEnabled)
                return;
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Info(object message)
        {
            if (!IsInfoEnabled)
                return;
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Info(object message, Exception exception)
        {
            if (!IsInfoEnabled)
                return;

            if (exception != null)
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message + " " + exception.Message, Category);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
            }
        }

        public void InfoFormat(string format, params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0)
        {
            if (!IsInfoEnabled)
                return;
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            if (!IsInfoEnabled)
                return;
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            if (!IsInfoEnabled)
                return;
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }
        public void Warn(object message)
        {
            if (!IsWarnEnabled)
                return;
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Warn(object message, Exception exception)
        {
            if (!IsWarnEnabled)
                return;

            if (exception != null)
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message + " " + exception.Message, Category);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
            }
        }

        public void WarnFormat(string format, params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0)
        {
            if (!IsWarnEnabled)
                return;
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            if (!IsWarnEnabled)
                return;
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            if (!IsWarnEnabled)
                return;
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Error(object message)
        {
            if (!IsErrorEnabled)
                return;
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Error(object message, Exception exception)
        {
            if (!IsErrorEnabled)
                return;

            if (exception != null)
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message + " " + exception.Message, Category);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
            }
        }

        public void ErrorFormat(string format, params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0)
        {
            if (!IsErrorEnabled)
                return;
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            if (!IsErrorEnabled)
                return;
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            if (!IsErrorEnabled)
                return;
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Fatal(object message)
        {
            if (!IsFatalEnabled)
                return;
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void Fatal(object message, Exception exception)
        {
            if (!IsFatalEnabled)
                return;

            if (exception != null)
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message + " " +exception.Message, Category);
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
            }
        }

        public void FatalFormat(string format, params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0)
        {
            if (!IsFatalEnabled)
                return;
            string message = string.Format(format, arg0);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            if (!IsFatalEnabled)
                return;
            string message = string.Format(format, arg0, arg1);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            if (!IsFatalEnabled)
                return;
            string message = string.Format(format, arg0, arg1, arg2);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            string message = string.Format(format, args);
            System.Diagnostics.Trace.WriteLine(Prefix + message, Category);
        }
    }
}