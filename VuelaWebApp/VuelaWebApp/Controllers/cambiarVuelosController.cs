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
    public class cambiarVuelosController : Controller
    {
        private Entities db = new Entities();

        

        // GET: cambiarVuelos/Create
        public ActionResult CambiarVuelo()
        {
            return View();
        }

        // POST: cambiarVuelos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CambiarVuelo([Bind(Include = "idPase,pasaporte,idLineaVuelo")] cambiarVuelo cambiarVuelo)
        {
            if (ModelState.IsValid)
            {
                db.cambiarVuelo(cambiarVuelo.idPase,cambiarVuelo.pasaporte,cambiarVuelo.idLineaVuelo);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(cambiarVuelo);
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
