using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using NominaDePago.Models;

namespace NominaDePago.Controllers
{
    public class EmpleadoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmpleadoModels
        public ActionResult Index()
        {
            return View(db.EmpleadoModels.ToList());
        }

        // GET: EmpleadoModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoModel empleadoModel = db.EmpleadoModels.Find(id);
            if (empleadoModel == null)
            {
                return HttpNotFound();
            }
            return View(empleadoModel);
        }

        // GET: EmpleadoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LastName,Identification,PhoneNumber,Address,DateOfBirth,BankAccount")] EmpleadoModel empleadoModel)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadoModels.Add(empleadoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadoModel);
        }

        // GET: EmpleadoModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoModel empleadoModel = db.EmpleadoModels.Find(id);
            if (empleadoModel == null)
            {
                return HttpNotFound();
            }
            return View(empleadoModel);
        }

        // POST: EmpleadoModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LastName,Identification,PhoneNumber,Address,DateOfBirth,BankAccount")] EmpleadoModel empleadoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadoModel);
        }

        // GET: EmpleadoModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadoModel empleadoModel = db.EmpleadoModels.Find(id);
            if (empleadoModel == null)
            {
                return HttpNotFound();
            }
            return View(empleadoModel);
        }

        // POST: EmpleadoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadoModel empleadoModel = db.EmpleadoModels.Find(id);
            db.EmpleadoModels.Remove(empleadoModel);
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
