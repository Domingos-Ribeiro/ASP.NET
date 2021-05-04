using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;


namespace EquipasMembros.Controllers
{
    public class S1Controller : Controller
    {
        EquipasMembrosContext db = new EquipasMembrosContext();
        // GET: S1
        public ActionResult Index(string S)
        {

            var T = db.Membros.ToList();

            if (!string.IsNullOrEmpty(S))
            {
                T = db.Membros.Where(m => m.NomeMembro.Contains(S)).ToList();
            }


            return View(T);
        }
    }
}