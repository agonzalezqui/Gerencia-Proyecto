using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerBilly.Models;

namespace TallerBilly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCar(ModelCreateCar model)
        {
            if (ModelState.IsValid)
            {
                InsertCar(model.Placa, model.VIN, model.Modelo, model.Marca, model.Ano, model.Combustible, model.Transmision);

            }
            return View();
        }

        private void InsertCar(String Placa, String VIN, String Modelo, String Marca, String ano, String Combustible, String Transmision)
        {
            
        }
    }
}
