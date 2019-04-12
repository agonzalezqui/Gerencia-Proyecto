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
    public class createcarmodelsController : Controller
    {
        private TallerBillyEntities1 db = new TallerBillyEntities1();

        // GET: createcarmodels
        public ActionResult Index()
        {
            return View(db.createcarmodels.ToList());
        }

        // GET: createcarmodels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createcarmodel createcarmodel = db.createcarmodels.Find(id);
            if (createcarmodel == null)
            {
                return HttpNotFound();
            }
            return View(createcarmodel);
        }

        // GET: createcarmodels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: createcarmodels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Placa,VIN,Modelo,Marca,Ano,Combustible,Transmision")] createcarmodel createcarmodel)
        {
            if (ModelState.IsValid)
            {
                db.createcarmodels.Add(createcarmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createcarmodel);
        }

        // GET: createcarmodels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createcarmodel createcarmodel = db.createcarmodels.Find(id);
            if (createcarmodel == null)
            {
                return HttpNotFound();
            }
            return View(createcarmodel);
        }

        // POST: createcarmodels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Placa,VIN,Modelo,Marca,Ano,Combustible,Transmision")] createcarmodel createcarmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createcarmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createcarmodel);
        }

        // GET: createcarmodels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            createcarmodel createcarmodel = db.createcarmodels.Find(id);
            if (createcarmodel == null)
            {
                return HttpNotFound();
            }
            return View(createcarmodel);
        }

        // POST: createcarmodels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            createcarmodel createcarmodel = db.createcarmodels.Find(id);
            db.createcarmodels.Remove(createcarmodel);
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
