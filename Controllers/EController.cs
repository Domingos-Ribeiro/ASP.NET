using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.ViewModel;

namespace EquipasMembros.Controllers
{
    public class EController : Controller
    {
        private EquipasMembrosContext db = new EquipasMembrosContext();

        // GET: E
        public ActionResult Index()
        {
            var viewModel = new EquipaMembros();

            viewModel.Equipas = db.Equipas.ToList();
            viewModel.Membros = db.Membros.ToList();


            return View(viewModel);
        }
    }
}