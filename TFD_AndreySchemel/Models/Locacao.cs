using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFD_AndreySchemel.Models
{
    public class Locacao
    {
        public string cliente { get; set; }

        public double valor { get; set; }

        public int qntDias { get; set; }

        public int idLocacao { get; set; }

       
    }
}