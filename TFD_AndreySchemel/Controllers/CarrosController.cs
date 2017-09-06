using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFD_AndreySchemel.Models;

namespace TFD_AndreySchemel.Controllers
{
    public class CarrosController : Controller
    {
        // GET: Carros
        public List<Carros> Carros = new List<Carros>
        {
            new Carros {placa = "ABC-1234", cor = "Preto", modelo = "Celta"},
            new Carros {placa = "ABC-1235", cor = "Azul", modelo = "Gol"},

        };

        public ActionResult Index()
        {
            return View(Carros);
        }

        public ActionResult Details(string placa)
        {
            var carro = Carros.SingleOrDefault(c => c.placa == placa);

            if (carro == null)
            {
                return HttpNotFound();
            }

            return View(carro);
        }

    }
}