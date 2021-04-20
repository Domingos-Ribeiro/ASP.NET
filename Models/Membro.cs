using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipasMembros.Models
{
    public class Membro
    {
        public int Id { get; set; }
        public string NomeMembro { get; set; }
        public int EquipaId { get; set; }

        public virtual Equipa Equipa { get; set; }
    }
}