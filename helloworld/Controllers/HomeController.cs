using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helloworld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Jenkins test setup 11";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello 22 contact page.";

            return View();
        }
    }
}