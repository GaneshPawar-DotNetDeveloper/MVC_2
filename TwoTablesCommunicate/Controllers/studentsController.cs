using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TwoTablesCommunicate.Models;

namespace TwoTablesCommunicate.Controllers
{
    //[Authorize]
    public class StudentsController : Controller
    {
        private studentcontext db = new studentcontext();

        // GET: students
        // [AllowAnonymous]
        //  [OutputCache(Duration =60)]
        //  [OutputCache(CacheProfile = "2minutechache")]
        [HandleError(View ="Error")]
        public ActionResult Index()
        {
           
            throw new Exception("there is some problem");

          // return View(db.students.ToString());
            var students = db.students.Include(s => s.Trainer);
            return View(students.ToList());
        }

        // GET: students/Details/5x`
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student student = db.students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: students/Create
        public ActionResult Create()
        {
            ViewBag.TrainerId = new SelectList(db.Trainers, "TrainerId", "TrainerName");
            return View();
        }

        // POST: students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RollNumber,Name,Email,ConfirmEmail,DOB,TrainerId")] student student)
        {
            if (ModelState.IsValid)
            {
                db.students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TrainerId = new SelectList(db.Trainers, "TrainerId", "TrainerName", student.TrainerId);
            return View(student);
        }

        // GET: students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student student = db.students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.TrainerId = new SelectList(db.Trainers, "TrainerId", "TrainerName", student.TrainerId);
            return View(student);
        }

        // POST: students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RollNumber,Name,Email,DOB,TrainerId")] student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TrainerId = new SelectList(db.Trainers, "TrainerId", "TrainerName", student.TrainerId);
            return View(student);
        }

        // GET: students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student student = db.students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            student student = db.students.Find(id);
            db.students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult About()
        {
            return View();
        }
       
        [HttpGet]
         public ActionResult StudentByTrainer(int TrainerId)
        {
            // we need to featch all students for this trainer
            var students = db.students.Where(s => s.TrainerId == TrainerId);
            return View(students);
        }
        [HttpGet]
        /* public JsonResult IsEmailExists(string Email)
         {
            // bool isEmailExists = db.students.Any(s => s.Email == Email);
             bool isEmailExists = db.students.Any(s => s.Email.ToLower() == Email.ToLower());

             return Json(!isEmailExists, JsonRequestBehavior.AllowGet);
         }*/

        [HttpPost]
        public JsonResult IsEmailExists(string Email)
        {
            bool sw= !db.students.Any(s => s.Email == Email);
            return Json(sw,JsonRequestBehavior.AllowGet);
        }


        /* public JsonResult IsUserNameAvailable(string UserName)
         {
             bool isAvailable = !db.Users.Any(x => x.UserName == UserName);
             return Json(isAvailable, JsonRequestBehavior.AllowGet);
         }*/
        [HttpGet]
        [OutputCache(Duration =3)]
        public PartialViewResult GetPArtialCFontent()
        {
            return PartialView("_partialView");
        }
    }

}
