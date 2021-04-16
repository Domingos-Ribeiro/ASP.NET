using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipasMembros.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Morada { get; set; }
    }
}