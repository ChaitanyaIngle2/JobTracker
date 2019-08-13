using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobTracker.Models;
using JobTracker.Models.ViewModels;

namespace JobTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Applications()
        {
            return View();
        }

        public ActionResult AddPosition()
        {
            return View();
        }

        public ActionResult UpdateStatus()
        {
            return View();
        }
    }
}