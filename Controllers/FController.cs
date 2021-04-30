using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.ViewModel;

namespace EquipasMembros.Controllers
{
    public class FController : Controller
    {
        private EquipasMembrosContext db = new EquipasMembrosContext();

        // GET: F
        public ActionResult Index(int? id)
        {
           
            var viewModel = new EquipaMembros();
            viewModel.Equipas = db.Equipas.ToList();
            viewModel.Membros = db.Membros.ToList();

            ViewBag.EQUIPACLICADA = id;
            return View(viewModel);
        }
    }
}