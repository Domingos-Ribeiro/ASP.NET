using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EquipasMembros.Models;

namespace EquipasMembros.ViewModel
{
    public class EquipaMembros
    {
        public IEnumerable<Equipa> Equipas { get; set; }

        public IEnumerable<Membro> Membros { get; set; }
    }
}