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
