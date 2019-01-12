using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class DoctorsController : Controller
    {
        private DoctorsEntities db = new DoctorsEntities();

        // GET: Doctors
        public ActionResult Index()
        {
            return View(db.DoctorsInfoes.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsInfo doctorsInfo = db.DoctorsInfoes.Find(id);
            if (doctorsInfo == null)
            {
                return HttpNotFound();
            }
            return View(doctorsInfo);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            return View();
        }

        public JsonResult FillIndex()

        {
            return Json(db.DoctorsInfoes.ToList(), JsonRequestBehavior.AllowGet);
        }

        // POST: Doctors/Create
        
        [HttpPost]
        public string Create(DoctorsInfo doctorInfo)
        {
            db.DoctorsInfoes.Add(doctorInfo);
            db.SaveChanges();
            return "Success!";
        }
        

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsInfo doctorsInfo = db.DoctorsInfoes.Find(id);
            if (doctorsInfo == null)
            {
                return HttpNotFound();
            }
            return View(doctorsInfo);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Specialty,PhoneNumber")] DoctorsInfo doctorsInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorsInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorsInfo);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsInfo doctorsInfo = db.DoctorsInfoes.Find(id);
            if (doctorsInfo == null)
            {
                return HttpNotFound();
            }
            return View(doctorsInfo);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorsInfo doctorsInfo = db.DoctorsInfoes.Find(id);
            db.DoctorsInfoes.Remove(doctorsInfo);
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
    }
}
