
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;
using EquipasMembros.ViewModel;
namespace EquipasMembros.Controllers


namespace EquipasMembros.Controllers
{

    public class GController : Controller
    {
        private EquipaMembros db = new EquipaMembros();
        // GET: G
        public ActionResult Index(int? id)
        {
            //A ViewModel poderá aceder a qualquer um dos atributos da Class EquipaMembros.
            // São eles: Equipa e Membros (Ver a pasta ViewModel)
            var viewModel = new EquipaMembros();

            // Leva as Equipas para a View:
            viewModel.Equipas = db.Equipas.Include(i => i.Membros.Select(c => c.Equipa));

            // Leva as Equipas para a View:
            viewModel.Membros = db.Membros;

            // Recebe a Equipa clicada via argumento e devolve á View:
            ViewBag.equipaclicada = id;
            

            return View(viewModel);
        }
    }
}