using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class BController : Controller
    {
        private EquipasMembrosContext db = new EquipasMembrosContext();
        
        
        // Levar os nomes daqui para a view
        EquipasMembrosContext pointer = new EquipasMembrosContext();
        // GET: B
        public ActionResult Index() 
        {
            List<Equipa> lst = new List<Equipa>();
            lst = pointer.Equipas.ToList();

            ViewBag.ListaDasEquipas = lst;

            ViewBag.Membros = db.Membros.ToList();
            return View();
        }
    }
}