using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaRequisiciones_WebApp.Models;

namespace SistemaRequisiciones_WebApp.Controllers
{
    public class RequisicionesController : Controller
    {
        private dbRequisicionesEntities2 db = new dbRequisicionesEntities2();

        // GET: Requisiciones
        public ActionResult Index()
        {
            return View(db.Requisiciones.ToList());
        }

        // GET: Requisiciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisiciones requisiciones = db.Requisiciones.Find(id);
            if (requisiciones == null)
            {
                return HttpNotFound();
            }
            return View(requisiciones);
        }

        // GET: Requisiciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requisiciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoRequisicion,Fecha,Area,Tipo,EntregarEn,Prioridad,FechaSurtido,CompraServicio")] Requisiciones requisiciones)
        {
            if (ModelState.IsValid)
            {
                db.Requisiciones.Add(requisiciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requisiciones);
        }

        // GET: Requisiciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisiciones requisiciones = db.Requisiciones.Find(id);
            if (requisiciones == null)
            {
                return HttpNotFound();
            }
            return View(requisiciones);
        }

        // POST: Requisiciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoRequisicion,Fecha,Area,Tipo,EntregarEn,Prioridad,FechaSurtido,CompraServicio")] Requisiciones requisiciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requisiciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requisiciones);
        }

        // GET: Requisiciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisiciones requisiciones = db.Requisiciones.Find(id);
            if (requisiciones == null)
            {
                return HttpNotFound();
            }
            return View(requisiciones);
        }

        // POST: Requisiciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Requisiciones requisiciones = db.Requisiciones.Find(id);
            db.Requisiciones.Remove(requisiciones);
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
