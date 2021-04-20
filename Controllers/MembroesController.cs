using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EquipasMembros.DAL;
using EquipasMembros.Models;

namespace EquipasMembros.Controllers
{
    public class MembroesController : Controller
    {
        private EquipasMembrosContext db = new EquipasMembrosContext();

        // GET: Membroes
        public ActionResult Index()
        {
            var membros = db.Membros.Include(m => m.Equipa);
            return View(membros.ToList());
        }

        // GET: Membroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        // GET: Membroes/Create
        public ActionResult Create()
        {
            ViewBag.EquipaId = new SelectList(db.Equipas, "Id", "NomeEquipa");
            return View();
        }

        // POST: Membroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeMembro,EquipaId")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.Membros.Add(membro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EquipaId = new SelectList(db.Equipas, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // GET: Membroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            ViewBag.EquipaId = new SelectList(db.Equipas, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // POST: Membroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeMembro,EquipaId")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(membro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EquipaId = new SelectList(db.Equipas, "Id", "NomeEquipa", membro.EquipaId);
            return View(membro);
        }

        // GET: Membroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        // POST: Membroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro membro = db.Membros.Find(id);
            db.Membros.Remove(membro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
