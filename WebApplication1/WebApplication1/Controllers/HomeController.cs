using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string a = "s";

            ViewBag.Title = "Home Page";

            return View();
        }

        public void Test()
        {
            String s = "this is a test";
        }
    }
}
