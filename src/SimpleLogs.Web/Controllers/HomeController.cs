using System;
using System.Web.Mvc;
using SimpleLogs.Simple;
using SimpleLogs.Web.Services;

namespace SimpleLogs.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logHelper = LogHelper.Resolve();
            logHelper.Debug("Debug From Home Index", this.GetType());
            logHelper.GetLogger(this.GetType()).Debug("Debug From Home Index");

            logHelper.Info("Info From Home Index", this.GetType());
            logHelper.GetLogger(this.GetType()).Info("Info From Home Index");
            logHelper.Error("Error From Home Index", this.GetType(), new Exception("blah"));
            logHelper.GetLogger(this.GetType()).Error("Error From Home Index");

            return Content("Home Index");
        }

        public ActionResult Bad()
        {
            try
            {
                Foo.HelloWorld();
            }
            catch (Exception ex)
            {
                LogHelper.Resolve().Error(ex.Message, typeof(Foo), ex);
            }
            return Content("Home Bad");
        }
    }
}
