using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;
using System.Web.Mvc;
using DBASPNet.Models;

namespace DBASPNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var factories = new List<Factory>();

            using (
                var con =
                    new SqlConnection(WebConfigurationManager.ConnectionStrings["BlueSunDBContext"].ConnectionString))
            {
                con.Open();

                using (
                    SqlCommand cmd =
                        new SqlCommand(
                            "select id, city, state, country, currency, street_address, zip_code from dbo.Factories", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Factory factory = new Factory
                            {
                                ID = new SqlGuid(reader.GetString(0)),
                                City = reader.GetString(1),
                                State = reader.GetString(2),
                                Country = reader.GetString(3),
                                Currency = reader.GetString(4),
                                StreetAddress = reader.GetString(5),
                                ZipCode = reader.GetString(6)
                            };

                            factories.Add(factory);
                        }
                    }
                }
            }

            this.ViewBag.Factories = factories;

            return View();
        }
    }
}