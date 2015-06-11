using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_MVC5_396
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
