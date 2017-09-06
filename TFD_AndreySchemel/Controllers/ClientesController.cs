using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFD_AndreySchemel.Models;
using TFD_AndreySchemel.ViewModels;


namespace TFD_AndreySchemel.Controllers
{
    public class ClientesController : Controller
    {

        public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {Id = 1, Nome = "Andrey", email = "andrey.schemel@unerj.br", numeroTelefone = 91822},
            new Cliente {Id = 2, Nome = "Wyllyam", email = "schemel.andrey@unerj.br", numeroTelefone = 15941},
            new Cliente {Id = 3, Nome = "Schemel", email = "andrey@unerj.br", numeroTelefone = 16546}
        };

        public ActionResult Index()
        {
            return View(Clientes);
        }

        public ActionResult Details(int id)
        {
            var cliente = Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

       


    }
}