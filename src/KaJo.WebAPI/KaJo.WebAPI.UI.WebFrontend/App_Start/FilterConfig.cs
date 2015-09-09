using System.Web;
using System.Web.Mvc;

namespace KaJo.WebAPI.UI.WebFrontend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}