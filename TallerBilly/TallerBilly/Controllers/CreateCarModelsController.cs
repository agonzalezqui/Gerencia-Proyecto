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
    public class CreateCarModelsController : Controller
    {
        private TallerBillyDB db = new TallerBillyDB();

        // GET: CreateCarModels
        public ActionResult Index()
        {
            return View(db.CreatedCars.ToList());
        }

        // GET: CreateCarModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateCarModel createCarModel = db.CreatedCars.Find(id);
            if (createCarModel == null)
            {
                return HttpNotFound();
            }
            return View(createCarModel);
        }

        // GET: CreateCarModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateCarModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Placa,VIN,Modelo,Marca,Ano,Combustible,Transmision,CreateUserModelId")] CreateCarModel createCarModel)
        {
            if (ModelState.IsValid)
            {
                db.CreatedCars.Add(createCarModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createCarModel);
        }

        // GET: CreateCarModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateCarModel createCarModel = db.CreatedCars.Find(id);
            if (createCarModel == null)
            {
                return HttpNotFound();
            }
            return View(createCarModel);
        }

        // POST: CreateCarModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Placa,VIN,Modelo,Marca,Ano,Combustible,Transmision,CreateUserModelId")] CreateCarModel createCarModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createCarModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createCarModel);
        }

        // GET: CreateCarModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateCarModel createCarModel = db.CreatedCars.Find(id);
            if (createCarModel == null)
            {
                return HttpNotFound();
            }
            return View(createCarModel);
        }

        // POST: CreateCarModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateCarModel createCarModel = db.CreatedCars.Find(id);
            db.CreatedCars.Remove(createCarModel);
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
