using System.Web;
using System.Web.Mvc;

namespace NgVanDuoc2210900016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
