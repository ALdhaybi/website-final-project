using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website_final_project.Controllers
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


        public ActionResult product()
        {
            ViewBag.Message = "Your product page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact information:";

            return View();
        }
    }
}