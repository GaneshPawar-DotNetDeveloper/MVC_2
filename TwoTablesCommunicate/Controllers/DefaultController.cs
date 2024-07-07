using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwoTablesCommunicate.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
       
        [HttpGet]
        public ActionResult post()
        {
            return View();
        }
    }
}