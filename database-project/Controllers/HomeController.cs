using database_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace database_project.Controllers
{
    public class HomeController : Controller
    {
        Database db;
        public HomeController()
        {
            db = new Database();
        }
        public ActionResult Index()
        {
            var model = db.DisplayData();
            return View(model);
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