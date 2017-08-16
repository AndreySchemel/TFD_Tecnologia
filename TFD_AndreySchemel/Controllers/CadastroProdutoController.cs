using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFD_AndreySchemel.Models;

namespace TFD_AndreySchemel.Controllers
{
    public class CadastroProdutoController : Controller
    {
        // GET: CadastroProduto
        public ActionResult Index()
        {
            var cadastro = new CadastroProduto
            {
                Nome = "Andrey"
            };
            return View(cadastro);
        }
    }

}