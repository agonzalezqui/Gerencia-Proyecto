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
    public class createusermodelsController : Controller
    {
        private TallerBillyEntities1 db = new TallerBillyEntities1();

        // GET: createusermodels
        public ActionResult Index()
        {
            return View(db.createusermodels.ToList());
        }

        // GET: createusermodels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createusermodel createusermodel = db.createusermodels.Find(id);
            if (createusermodel == null)
            {
                return HttpNotFound();
            }
            return View(createusermodel);
        }

        // GET: createusermodels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: createusermodels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,Cedula,Email,Contacto,Direccion")] createusermodel createusermodel)
        {
            if (ModelState.IsValid)
            {
                db.createusermodels.Add(createusermodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createusermodel);
        }

        // GET: createusermodels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createusermodel createusermodel = db.createusermodels.Find(id);
            if (createusermodel == null)
            {
                return HttpNotFound();
            }
            return View(createusermodel);
        }

        // POST: createusermodels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,Cedula,Email,Contacto,Direccion")] createusermodel createusermodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createusermodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createusermodel);
        }

        // GET: createusermodels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createusermodel createusermodel = db.createusermodels.Find(id);
            if (createusermodel == null)
            {
                return HttpNotFound();
            }
            return View(createusermodel);
        }

        // POST: createusermodels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            createusermodel createusermodel = db.createusermodels.Find(id);
            db.createusermodels.Remove(createusermodel);
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
