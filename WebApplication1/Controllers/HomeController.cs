using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using MySql.Data.MySqlClient;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             
                       FactorViewModel p = new FactorViewModel();
            ViewBag.Message = "hello";
            ViewBag.nee_message = "kyu";

            var connectionString = "server=localhost;user id=root;password=root";
            MySqlConnection cann = new MySqlConnection(connectionString);
            // MySqlCommand cmd = new MySqlCommand("query", cann);
            // cmd.;
            cann.Open();
           
            //var a = "rahul";
            p.Purpose = "mvc";
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}