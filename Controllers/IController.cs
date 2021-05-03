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
            
            var a = db.Equipas.ToList();
            ViewBag.A = a;
            //ViewBag.A = db.Equipas.ToList();

    //-----------------------------------------------------------

            //B: Quantas equipas
            
            var b = db.Equipas.Count();
            ViewBag.b = b;

    //-----------------------------------------------------------            

            //C: Ordenar equipas
            
            var c = db.Equipas.OrderBy(i => i.NomeEquipa).ToList();
            ViewBag.C = c;

    //-----------------------------------------------------------

            //D: Ordenar equipas
            
            var d = db.Equipas.OrderByDescending(i => i.NomeEquipa).ToList();
            ViewBag.D = d;

    //-----------------------------------------------------------

            //E: Qual é a equipa número 3?
            
            int numero = 3;
            Equipa registo = new Equipa();

            //Procura a chave Primária nº 3
            registo = db.Equipas.Find(numero);
            ViewBag.E = registo.NomeEquipa;

    //-----------------------------------------------------------

            //F: Qual é a equipa número 88?
            
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
            

            {
                Equipa registoG = new Equipa();
                registoG = db.Equipas.First();
                ViewBag.G = registoG.NomeEquipa;
            }

    //-----------------------------------------------------------

            //H: Existe a equipa "Portinhola"?
            
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

            //I: Quantos membros tem a equipa 4 ?





    //-----------------------------------------------------------

            //J: Quantos membros tem a equipa "Bragões"?

            string st = "Bragões";
            int codequipa;

            //Localizar a chave primaria da equipa
            codequipa = db.Equipas.FirstOrDefault(i => i.NomeEquipa == st).Id;

            //Quantas vezes a chave primária é estrangeira?
            ViewBag.J = db.Membros.Where(i => i.EquipaId == codequipa).Count();


            //-----------------------------------------------------------

            //K: Quantos membros tem a equipa "Arsenal da Devesa"

            string arsenal = "Arsenal da Devesa";
            int codequipaArsenal;

            //Localizar chave primária da equipa
            try
            {
                codequipaArsenal = db.Equipas.FirstOrDefault(i => i.NomeEquipa == arsenal).Id;

            }
            catch (Exception)
            {

                codequipaArsenal = -1;
            }

            if (codequipaArsenal == -1)
            {
                ViewBag.K = "Equipa INEXISTENTE!";
            }
            else
                //Se existir contar os membros
                ViewBag.K = db.Membros.Where(i => i.EquipaId == codequipaArsenal).Count();
            
            return View();
        }
    }
}