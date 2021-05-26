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
    public class HController : Controller
    {
        // GET: H
        private EquipasMembrosContext db = new EquipasMembrosContext();
        
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

            ViewBag.TotalDeMembros = db.Membros.Count();

            if (id == -1)
            {
                ViewBag.TotalDeMembrosDaEquipa = "";
                
            }
            else
            
                
                {
                    int totequipa = db.Membros.Where((i => i.EquipaId == id)).Count();
                      if (totequipa > 0)
                          ViewBag.TotalDeMembrosDaEquipa = totequipa;
                      else
                          ViewBag.TotalDeMembrosDaEquipa = "0";
               
            }

            //---------------------------------------------------------------------------
            // Registo terá a estrutura do modelo Equipa
            // Só haverá um registo com aquele id:

            Equipa registo;

            if (id!= -1)
            {
                    registo = db.Equipas.Find(id);
                //ViewBag.EquipaSelecionada = registo.NomeEquipa.ToString();              
                //ViewBag.NumeroDaEquipaSelecionada = registo.Id;

                //NOTA: A ultima linha tornada em comentário também funciona porqu a Equipa é uma class
                // por isso pode ser usada no "cast"

                //ViewBag.EquipaSelecionada = (Equipa)db.Equipas.Find(id);
            }

            else
            {
                 ViewBag.EquipaSelecionada = "Não vi, clica outra vez";
                 ViewBag.NumeroDaEquipaSelecionada = "Não me lembro";
            }
            //----------------------------------------------------------------------------

            return View(viewModel);
        }
    }
}