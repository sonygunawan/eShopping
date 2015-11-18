using System.Web;
using System.Web.Mvc;

namespace Pos.UI.WebApi.Pos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
