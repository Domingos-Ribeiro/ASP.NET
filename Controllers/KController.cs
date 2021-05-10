using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class KController : Controller
    {
        private EquipasMembrosContext pointer = new EquipasMembrosContext();
        // GET: K
        public ActionResult Index(int? idDrop)
        {
            //  Buscar a lista das equipas para enviar para a dropbox
            List<Equipa> lista = pointer.Equipas.ToList();
            SelectList sel = new SelectList(lista, "Id", "NomeEquipa");
            ViewBag.LISTA = sel;

            // Parametro idDrop tem o id (ou chave primária) da equipa escolhida
            // então, filtrar os membros em que a chave primária = idDrop
            var membros = pointer.Membros.Where(m => m.EquipaId == idDrop);


            //var membros = pointer...
            return View(membros.ToList());
        }
    }
}