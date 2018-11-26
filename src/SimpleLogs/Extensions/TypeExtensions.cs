using System;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace SimpleLogs
{
    public static class TypeExtensions
    {
        public static string GuessProjectPrefix(this Type type)
        {
            var prefix = "";
            var ns = type.Namespace;
            if (ns != null)
            {
                var result = ns.Split('.').FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    prefix = result;
                }
            }
            return prefix;
        }
    }
}
