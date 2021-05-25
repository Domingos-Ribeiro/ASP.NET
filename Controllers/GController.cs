
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;
using EquipasMembros.ViewModel;




namespace EquipasMembros.Controllers
{

    public class GController : Controller
    {
        //private EquipasContext db = new EquipasContext(); 
        //-------- Em cima dava ERRO por faltavam os Membros, a expressão correta está em baixo.
        private EquipasMembrosContext db = new EquipasMembrosContext();
        // GET: G
        public ActionResult Index(int? id)
        {
            //A ViewModel poderá aceder a qualquer um dos atributos da Class EquipaMembros.
            // São eles: Equipa e Membros (Ver a pasta ViewModel)
            var viewModel = new EquipaMembros();

            // Leva as Equipas para a View:
            viewModel.Equipas = db.Equipas.Include(i => i.Membros.Select(c => c.Equipa));

            // Leva os Membros para a View:
            viewModel.Membros = db.Membros;

            // Recebe a Equipa clicada via argumento e devolve á View:
            ViewBag.equipaclicada = id;
            

            return View(viewModel);
        }
    }
}