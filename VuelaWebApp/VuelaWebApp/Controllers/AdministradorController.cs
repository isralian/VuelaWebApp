using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VuelaWebApp.Models;

namespace VuelaWebApp.Controllers
{
    public class AdministradorController : Controller
    {
        private Entities db = new Entities();

        // GET: Administrador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usuario,idempleado,nombre,clave")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                db.insertarAdministrador(administrador.idempleado, administrador.usuario, administrador.nombre, administrador.clave);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            }

            return View(administrador);
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
