using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;


namespace EquipasMembros.Controllers
{
    public class LController : Controller
    {
        private EquipasMembrosContext pointer = new EquipasMembrosContext();

        // GET: L
        public ActionResult Index()
        {

            var membros = pointer.Membros.ToList();

            //int max = 0;

            //foreach (var item in membros)
            //{
            //    if (item.Id > max)
            //    {
            //        max = item.Id;
            //        ViewBag.MaxId = item.Id;
            //    }
            //}

//***************************************************************************
            // A1
            ViewBag.A1 = pointer.Membros.Max(m => m.Id);

            //A2
            ViewBag.A2 = pointer.Equipas.Min(m => m.Id);

            //A3
            ViewBag.A3 = pointer.Equipas.Sum(m => m.Id);

            //A4
            ViewBag.A4 = pointer.Equipas.Where(m => m.NomeEquipa == "Falcões do Picoto").Sum(m => m.Id);

            //A5
            ViewBag.A5 = pointer.Membros.Where(m => m.Equipa.NomeEquipa == "Falcões do Picoto").Sum(m => m.Id);

            //********************************************************************************************************

            //B
            ViewBag.B = pointer.Membros.Where(m => m.NomeMembro == "Abel").GroupBy(m => m.EquipaId).Count();

            //C
            ViewBag.C = pointer.Membros.Where(m => m.Equipa.NomeEquipa == "Maximinense" | m.Equipa.NomeEquipa == "Falcões do Picoto").Count();

            //D
            ViewBag.D = pointer.Membros.Where(m => m.Equipa.NomeEquipa == "Maximinense" || m.Equipa.NomeEquipa == "Falcões do Picoto").OrderBy(m => m.Id);




            return View();

        }
    }
}