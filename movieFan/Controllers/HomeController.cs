using movieFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movieFan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "index page";
            return View();
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




        public ActionResult MovieCollection()
        {
            ViewBag.Message = "This is your user homepage.  Under Construction";

            return View();
        }

        //public ActionResult MovieIndex()
        //{
        //    ViewBag.Message = "list of movies";

        //    return View("~/Views/Movie/Details.cshtml");
        //}
    }
}