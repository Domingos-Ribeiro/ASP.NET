using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class IController : Controller
    {
        // Não esquecer...
        private EquipasMembrosContext db = new EquipasMembrosContext();
        
        // GET: I
        public ActionResult Index(int? id)
        {
            // A: Todas as equipas Usando o LINQ
            // GET: A
            var a = db.Equipas.ToList();
            ViewBag.A = a;
            //ViewBag.A = db.Equipas.ToList();

            //-----------------------------------------------------------

            //B: Quantas equipas
            // GET: B
            var b = db.Equipas.Count();
            ViewBag.b = b;

            //-----------------------------------------------------------            

            //C: Ordenar equipas
            // GET: C
            var c = db.Equipas.OrderBy(i => i.NomeEquipa).ToList();
            ViewBag.C = c;

            //-----------------------------------------------------------

            //D: Ordenar equipas
            // GET: D
            var d = db.Equipas.OrderByDescending(i => i.NomeEquipa).ToList();
            ViewBag.D = d;

            //-----------------------------------------------------------

            //E: Qual é a equipa número 3?
            // GET: E
            int numero = 3;
            Equipa registo = new Equipa();

            //Procura a chave Primária nº 3
            registo = db.Equipas.Find(numero);
            ViewBag.E = registo.NomeEquipa;

            //-----------------------------------------------------------

            //F: Qual é a equipa número 88?
            // GET: F
            int numF = 88;
            Equipa registoF = new Equipa();

            //Procura a chave Primária nº 88 
            registoF = db.Equipas.Find(numF);

            if (registoF == null)
            {
                ViewBag.F = "A equipa nº " + numF + " não existe.";
            }
            else
            {
                ViewBag.F = registoF.NomeEquipa;
            }

    //-----------------------------------------------------------

            //G: Qual a primeira equipa?
            // GET: G

            {
                Equipa registoG = new Equipa();
                registoG = db.Equipas.First();
                ViewBag.G = registoG.NomeEquipa;
            }


            //-----------------------------------------------------------

            //H: Existe a equipa "Portinhola"?
            // GET: H

            string sh = "Portinhola";
            var h = db.Equipas.Where(i => i.NomeEquipa.Equals(sh)).ToList();
            int numRegistos = h.Count();
            if (numRegistos == 0)
            {
                ViewBag.H = "Não existe essa equipa";
            }
            else if (numRegistos == 1)
            {
                ViewBag.H = "Sim, existe";
            }
            else

                ViewBag.H = "Há mais do que uma equipa com esse nome!";



            //-----------------------------------------------------------





            return View();
        }
    }
}