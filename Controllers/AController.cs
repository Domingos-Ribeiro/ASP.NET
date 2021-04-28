using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class AController : Controller
    {
        // GET: A
        public ActionResult Index()
        {
            // Declarar a lista "Manual" para conter as strings:
            List<string> listaDeNomes = new List<string>(); // Sintaxe original
            listaDeNomes.Add("Anabela");
            listaDeNomes.Add("Joaquim");

            // Enviar lista criada em cima para a view
            ViewBag.LISTA = listaDeNomes;


            // Declarar lista "Manual" para conter as strings e aparecer na dropdown
            var listaDeClubes = new List<string>(); // Sintaxe Alternativa

            // Iniciar a lista:
            listaDeClubes.Add("Benfica");
            listaDeClubes.Add("Porto");
            listaDeClubes.Add("Braga");
            listaDeClubes.Add("Gilvicente");

            listaDeClubes.Sort(); // Ordenar a lista de clubes

            // Criar uma selectlist ou Dropdown com os elementos da lista:
            var sl = new SelectList(listaDeClubes);

            // Enviar lista para a view
            ViewBag.SELECTLIST = sl;

            return View();
        }
    }
}