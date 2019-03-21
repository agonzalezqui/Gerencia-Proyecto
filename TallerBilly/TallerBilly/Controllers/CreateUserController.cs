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
    public class CreateUserController : Controller
    {
        private TallerBillyDB db = new TallerBillyDB();

        // GET: CreateUser
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: CreateUser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateUserModel createUserModel = db.Users.Find(id);
            if (createUserModel == null)
            {
                return HttpNotFound();
            }
            return View(createUserModel);
        }

        // GET: CreateUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,Cedula,Email,Contacto,Direccion")] CreateUserModel createUserModel)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(createUserModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createUserModel);
        }

        // GET: CreateUser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateUserModel createUserModel = db.Users.Find(id);
            if (createUserModel == null)
            {
                return HttpNotFound();
            }
            return View(createUserModel);
        }

        // POST: CreateUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,Cedula,Email,Contacto,Direccion")] CreateUserModel createUserModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createUserModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createUserModel);
        }

        // GET: CreateUser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateUserModel createUserModel = db.Users.Find(id);
            if (createUserModel == null)
            {
                return HttpNotFound();
            }
            return View(createUserModel);
        }

        // POST: CreateUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateUserModel createUserModel = db.Users.Find(id);
            db.Users.Remove(createUserModel);
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
