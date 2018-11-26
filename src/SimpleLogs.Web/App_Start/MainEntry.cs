using System.Web.Mvc;
using System.Web.Routing;
using SimpleLogs.Log4Net;

namespace SimpleLogs.Web
{
    public class MainEntry
    {
        public static void Init()
        {
            LogHelper.Instance.Init();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
