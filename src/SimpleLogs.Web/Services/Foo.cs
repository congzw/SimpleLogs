using System;

namespace SimpleLogs.Web.Services
{
    public class Foo
    {
        public static string HelloWorld()
        {
            throw new ApplicationException("Shit happens!");
        }
    }
}