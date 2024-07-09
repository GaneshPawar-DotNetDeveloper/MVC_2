using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreasDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult partialView1()
        {
            return PartialView("_PartialView1");
        }
        public PartialViewResult partialView2()
        {
            return PartialView("_PartialView2");
        } 
        public PartialViewResult partialView3()
        {
            return PartialView("_PartialView3");
        }
    }
}