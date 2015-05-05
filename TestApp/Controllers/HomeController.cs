using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Let's get lost in the \"The World of Dreams\"";

            return View("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
