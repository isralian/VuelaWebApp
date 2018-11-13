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
    public class crearEquipajeController : Controller
    {
        private Entities db = new Entities();

        // GET: Equipaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipaje/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idequipaje,pasaporte,peso,idlineavuelo")] crearEquipaje crearEquipaje)
        {
            if (ModelState.IsValid)
            {
                db.insertarEquipaje(crearEquipaje.idequipaje, crearEquipaje.pasaporte, crearEquipaje.peso, crearEquipaje.idlineavuelo);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            }

            return View(crearEquipaje);
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
