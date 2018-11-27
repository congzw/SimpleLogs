using System;
using System.Web.Mvc;
using SimpleLogs.Web.Services;

namespace SimpleLogs.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LogHelper.Instance.Debug("Debug From Home Index", this.GetType());
            LogHelper.Instance.Resolve().GetLogger(this.GetType()).Debug("Debug From Home Index");

            LogHelper.Instance.Info("Info From Home Index", this.GetType());
            LogHelper.Instance.Resolve().GetLogger(this.GetType()).Info("Info From Home Index");

            LogHelper.Instance.Error("Error From Home Index", this.GetType(), new Exception("blah"));
            LogHelper.Instance.Resolve().GetLogger(this.GetType()).Error("Error From Home Index");

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
                LogHelper.Instance.Error(ex.Message, typeof(Foo), ex);
            }
            return Content("Home Bad");
        }
    }
}
