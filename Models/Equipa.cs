using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipasMembros.Models
{
    public class Equipa
    {
        public int Id { get; set; }
        public string NomeEquipa { get; set; }

        // Cada equipa pode ter uma coleção de membros:
        public virtual ICollection<Membro> Membros { get; set; }
    }
}