using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class CController : Controller
    {
        private EquipasMembrosContext dbPointer = new EquipasMembrosContext();
        // GET: C
        public ActionResult Index()
        {
            // Preparação da drop 1 com as Equipas:
            List<Equipas> listaDasEquipas = new List<Equipa>();
            listaDasEquipas = dbPointer.Equipas.ToList();

            return View();
        }
    }
}