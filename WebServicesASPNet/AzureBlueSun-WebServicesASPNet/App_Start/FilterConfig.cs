using System.Web;
using System.Web.Mvc;

namespace AzureBlueSun_WebServicesASPNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
