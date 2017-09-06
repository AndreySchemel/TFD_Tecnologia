using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFD_AndreySchemel.Models;

namespace TFD_AndreySchemel.Controllers
{
    public class LocacaoController : Controller
    {
        public List<Locacao> Locacoes = new List<Locacao>
        {
                new Locacao {cliente = "Andrey", qntDias = 8, valor = 150, idLocacao = 21 },
                new Locacao {cliente = "Wyllyam", qntDias = 9, valor = 150, idLocacao = 25 }

        };

        public ActionResult Index()
        {
            return View(Locacoes);
        }

        public ActionResult Details(int id)
        {
            var empresa = Locacoes.SingleOrDefault(c => c.idLocacao == id);

            if (empresa == null)
            {
                return HttpNotFound();
            }

            return View(empresa);
        }

    };
}
