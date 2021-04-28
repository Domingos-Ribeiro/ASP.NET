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
            List<Equipa> listaDasEquipas = new List<Equipa>();
            listaDasEquipas = dbPointer.Equipas.ToList();

            // Criar uma select list -> tipo dropdownlist
            SelectList sel1 = new SelectList(listaDasEquipas, "Id", "NomeEquipa");
            ViewBag.EQUIPAS = sel1;


            // Preparação da drop 2 com as Equipas, DUAS POSSIBILIDADES:
            //List<Membro> listaDosMembros = new List<Membro>();
            //SelectList sel2 = new SelectList(listaDosMembros, "Id", "NomeMembro");

            // OU

            ViewBag.MEMBROS = new SelectList(dbPointer.Membros.ToList(), "Id", "NomeMembro");

            return View();
        }
    }
}