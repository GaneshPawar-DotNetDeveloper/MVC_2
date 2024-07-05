using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewLayoutDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Index1()
        {
            return View();
        }
        public PartialViewResult PartialViewResult()
        {
            return PartialView("_partialview");
        }
        public PartialViewResult PartialViewResult1()
        {
            return PartialView("_partialview");
        }
    }
}