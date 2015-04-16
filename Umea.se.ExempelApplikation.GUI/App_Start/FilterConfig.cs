using System.Web;
using System.Web.Mvc;
using Umea.se.ExempelApplikation.GUI.Filters;

namespace Umea.se.ExempelApplikation.GUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionFilter()); 
            filters.Add(new HandleErrorAttribute());
        }
    }
}
