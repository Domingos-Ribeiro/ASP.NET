using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EquipasMembros.Models;
using System.Data.Entity;

namespace EquipasMembros.DAL 
{
    public class EquipasMembrosContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}