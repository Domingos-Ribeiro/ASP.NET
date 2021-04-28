using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class DController : Controller
    {
        private EquipasMembrosContext dbpointer = new EquipasMembrosContext();

        // GET: D
        public ActionResult Index(string codigoClicado)
        {
            //Levar as Equipas sem recorrer ao model na view
            List<Equipa> list = new List<Equipa>();
            list = dbpointer.Equipas.ToList();
            SelectList sel = new SelectList(list, "Id", "NomeEquipa");
            ViewBag.SEL = sel;

            if (String.IsNullOrEmpty(codigoClicado)) // Primeira vez
            {
                
                codigoClicado = "Clique no botão em cima para ver o código";
            }

            // Enviar o codigo da Equipa para a view
            ViewBag.CODIGOCLICADO = codigoClicado;

            return View();
        }
    }
}