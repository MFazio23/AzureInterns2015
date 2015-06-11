using System.Collections.Generic;
using System.Web.Mvc;
using AzureBlueSun_WebServicesASPNet.Models;
using DBASPNet.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace DBASPNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var users = new List<User>();

            var client = new MobileServiceClient(
                "https://azurebluesun.azure-mobile.net/"
                );

            var userTable = client.GetTable<User>();
            //userTable.

            //this.ViewBag.Users = userTable.

            return View();
        }
    }
}