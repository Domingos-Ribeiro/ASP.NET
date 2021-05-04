
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;
using EquipasMembros.ViewModel;
using EquipasMembros.Controllers;


namespace EquipasMembros.Controllers
{

    public class GController : Controller
    {
        private EquipaMembros db = new EquipaMembros();
        // GET: G
        public ActionResult Index(int? id)
        {



            var viewModel = new EquipaMembros();


           // viewModel.Equipas = db.Equipas.Include(i => i.Membros.Select(c. => c.Equipa));

            return View();
        }
    }
}