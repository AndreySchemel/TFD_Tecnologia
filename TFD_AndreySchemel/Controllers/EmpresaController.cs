using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFD_AndreySchemel.Models;

namespace TFD_AndreySchemel.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Carros
        public List<Empresa> Empresas = new List<Empresa>
        {
            new Empresa {CNPJ = "00.812.123/0002-12", endereco = "Rua não sei", nome = "LocaCar", numeroTelefone = 132123123 }


        };

        public ActionResult Index()
        {
            return View(Empresas);
        }

        public ActionResult Details(string cnpj)
        {
            var empresa = Empresas.SingleOrDefault(c => c.CNPJ == cnpj);

            if (empresa == null)
            {
                return HttpNotFound();
            }

            return View(empresa);
        }

    }
}