﻿using System;
using System.Web;

namespace SimpleLogs.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            MainEntry.Init();
        }
    }
}