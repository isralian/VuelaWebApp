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
    public class crearClienteController : Controller
    {
        private Entities db = new Entities();

        // GET: crearCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: crearCliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usuario,nombre,clave,pasaporte,correo,paisResidencia")] crearCliente crearCliente)
        {
            if (ModelState.IsValid)
            {
                db.insertarCliente(crearCliente.usuario, crearCliente.clave, crearCliente.nombre, crearCliente.correo, crearCliente.paisResidencia, crearCliente.pasaporte);
                db.SaveChanges();
                return RedirectToAction("Login", "Login");
            }

            return View(crearCliente);
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
