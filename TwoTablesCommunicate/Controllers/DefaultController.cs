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
        [ChildActionOnly]
        //[NonAction]
        [HttpGet]
        public ActionResult post()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public string post(string comment)
        {
            // ViewBag.Message="comment inserted successfully";
           // ViewBag.Comment = comment;  
            
            return comment;
        }
    }
}