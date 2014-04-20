using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using salonMVC.Models;

namespace salonMVC.Controllers
{
    public class NewSalonManagerController : Controller
    {
        private SalonEntities db = new SalonEntities();

        // GET: /NewSalonManager/
        public ActionResult Index()
        {
            var treatments = db.Treatments.Include(t => t.Stylist).Include(t => t.TreatmentType);
            return View(treatments.ToList());
        }

        // GET: /NewSalonManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: /NewSalonManager/Create
        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "Name");
            ViewBag.TreatmentTypeId = new SelectList(db.TreatmentTypes, "TreatmentTypeId", "Name");
            return View();
        }

        // POST: /NewSalonManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="TreatmentId,TreatmentTypeId,StylistId,TreatmentName,Price,TreatmentPicUrl")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatments.Add(treatment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "Name", treatment.StylistId);
            ViewBag.TreatmentTypeId = new SelectList(db.TreatmentTypes, "TreatmentTypeId", "Name", treatment.TreatmentTypeId);
            return View(treatment);
        }

        // GET: /NewSalonManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "Name", treatment.StylistId);
            ViewBag.TreatmentTypeId = new SelectList(db.TreatmentTypes, "TreatmentTypeId", "Name", treatment.TreatmentTypeId);
            return View(treatment);
        }

        // POST: /NewSalonManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="TreatmentId,TreatmentTypeId,StylistId,TreatmentName,Price,TreatmentPicUrl")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StylistId = new SelectList(db.Stylists, "StylistId", "Name", treatment.StylistId);
            ViewBag.TreatmentTypeId = new SelectList(db.TreatmentTypes, "TreatmentTypeId", "Name", treatment.TreatmentTypeId);
            return View(treatment);
        }

        // GET: /NewSalonManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: /NewSalonManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Treatment treatment = db.Treatments.Find(id);
            db.Treatments.Remove(treatment);
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
