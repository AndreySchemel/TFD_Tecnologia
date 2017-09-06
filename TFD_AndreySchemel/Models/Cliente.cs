using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFD_AndreySchemel.Models
{
    public class Cliente

    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int numeroTelefone { get; set; }

        public string email { get; set; }
    }
}