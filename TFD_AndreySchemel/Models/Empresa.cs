using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFD_AndreySchemel.Models
{
    public class Empresa
    {
        public string CNPJ { get; set; }

        public string nome { get; set; }

        public int numeroTelefone { get; set; }

        public string endereco { get; set; }

    }
}