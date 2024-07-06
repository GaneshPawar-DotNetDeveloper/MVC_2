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
        public PartialViewResult Action()
        {
            return PartialView("_partialview");
        }
         public PartialViewResult RenderAction()
        {
            return PartialView("_partialview");
        }
        public PartialViewResult just()
        {
            return PartialView("_partialview");
        }
       
    }
}