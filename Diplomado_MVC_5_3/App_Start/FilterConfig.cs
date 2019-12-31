using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_5_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
