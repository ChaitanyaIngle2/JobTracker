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

            var status = new Status
            {
                StatusId = 1,
                StatusName = "Applied"
            };
            var tempJob = new Job()
            {
                Company = "Microsoft",
                Position = "Developer",
                Status = status
            };

            var viewModel = new AboutViewModel()
            {
                Job = tempJob
            };

            return View(viewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}