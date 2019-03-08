using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerBilly.Models;

namespace TallerBilly.Controllers
{
    public class CreateCarController : Controller
    {
        TallerBillyDB _db = new TallerBillyDB();
        // GET: CreateCar
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreateCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateCar/Create
        [HttpGet]
        public ActionResult CreateCar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateCar(CreateCarModel model)
        {
            if (ModelState.IsValid)
            {
                InsertCar(model.Placa, model.VIN, model.Modelo, model.Marca,
                    model.Ano, model.Combustible, model.Transmision);

            }
            return View();
        }

        private void InsertCar(String Placa, String VIN, String Modelo, String Marca,
            String ano, String Combustible, String Transmision)
        {
            CreateCarModel car = new CreateCarModel();
            car.Placa = Placa;
            car.VIN = VIN;
            car.Modelo = Modelo;
            car.Marca = Marca;
            car.Ano = ano;
            car.Combustible = Combustible;
            car.Transmision = Transmision;

            _db.CreatedCars.Add(car);
            _db.SaveChanges();
        }
    }

    // POST: CreateCar/Create
    //[HttpPost]
       /* public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreateCar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateCar/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreateCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateCar/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
    */
}
