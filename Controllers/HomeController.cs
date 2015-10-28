using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TameImpala.Controllers
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

        public ActionResult UpcomingGigs()
        {
            ViewBag.Message = "Below is a list of upcoming gigs";

            return View();
        }

        public ActionResult PreviousGigs()
        {
            ViewBag.Message = "Below is a list of previous gigs";

            return View();
        }
    }
}