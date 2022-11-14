using System.Web;
using System.Web.Mvc;

namespace Session_State_Hello_World
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
