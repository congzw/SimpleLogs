using System;
using System.Web.Mvc;
using SimpleLogs.Web.Services;

namespace SimpleLogs.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LogHelper.Instance.Info("From Home Index", this.GetType());
            LogHelper.Instance.Resolve().GetLogger(this.GetType()).Info("From Home Index");

            LogHelper.Instance.Debug("From Home Index", this.GetType());
            LogHelper.Instance.Resolve().GetLogger(this.GetType()).Debug("From Home Index");

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
                LogHelper.Instance.Error(ex.Message, ex, typeof(Foo));
            }
            return Content("Home Bad");
        }
    }
}
