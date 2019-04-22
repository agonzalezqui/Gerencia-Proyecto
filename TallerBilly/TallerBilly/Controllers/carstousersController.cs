using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TallerBilly.Models;

namespace TallerBilly.Controllers
{
    public class carstousersController : Controller
    {
        private TallerBillyEntities1 db = new TallerBillyEntities1();

        // GET: carstousers
        public ActionResult Index()
        {
            var carstousers = db.carstousers.Include(c => c.createcarmodel).Include(c => c.createusermodel);
            return View(carstousers.ToList());
        }

        // GET: carstousers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carstouser carstouser = db.carstousers.Find(id);
            if (carstouser == null)
            {
                return HttpNotFound();
            }
            return View(carstouser);
        }

        // GET: carstousers/Create
        public ActionResult Create()
        {
            ViewBag.Car_Id = new SelectList(db.createcarmodels, "Id", "Placa");

            ViewBag.cars = db.createusermodels.ToList();

            ViewBag.User_Id = new SelectList(db.createusermodels, "Id", "Nombre");

            ViewBag.users = db.createusermodels.ToList();
            return View();
        }

        // POST: carstousers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Car_Id,User_Id")] carstouser carstouser)
        {
            if (ModelState.IsValid)
            {
                db.carstousers.Add(carstouser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Car_Id = new SelectList(db.createcarmodels, "Id", "Placa", carstouser.Car_Id);
            ViewBag.User_Id = new SelectList(db.createusermodels, "Id", "Nombre", carstouser.User_Id);
            return View(carstouser);
        }

        // GET: carstousers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carstouser carstouser = db.carstousers.Find(id);
            if (carstouser == null)
            {
                return HttpNotFound();
            }
            ViewBag.Car_Id = new SelectList(db.createcarmodels, "Id", "Placa", carstouser.Car_Id);
            ViewBag.User_Id = new SelectList(db.createusermodels, "Id", "Nombre", carstouser.User_Id);
            return View(carstouser);
        }

        // POST: carstousers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Car_Id,User_Id")] carstouser carstouser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carstouser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Car_Id = new SelectList(db.createcarmodels, "Id", "Placa", carstouser.Car_Id);
            ViewBag.User_Id = new SelectList(db.createusermodels, "Id", "Nombre", carstouser.User_Id);
            return View(carstouser);
        }

        // GET: carstousers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carstouser carstouser = db.carstousers.Find(id);
            if (carstouser == null)
            {
                return HttpNotFound();
            }
            return View(carstouser);
        }

        // POST: carstousers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            carstouser carstouser = db.carstousers.Find(id);
            db.carstousers.Remove(carstouser);
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
