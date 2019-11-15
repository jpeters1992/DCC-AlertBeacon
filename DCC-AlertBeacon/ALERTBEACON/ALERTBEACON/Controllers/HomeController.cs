using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALERTBEACON.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alerts()
        {
            ViewBag.Message = "Your Alerts";

            return View();
        }

        public ActionResult Rewards()
        {
            ViewBag.Message = "Your Rewards";

            return View();
        }
    }
}