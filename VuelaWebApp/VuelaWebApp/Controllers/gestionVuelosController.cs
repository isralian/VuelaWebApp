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
    public class gestionVuelosController : Controller
    {
        private Entities db = new Entities();


        // GET: gestionVuelos/Create
        public ActionResult CheckIn()
        {
            return View();
        }

        // POST: gestionVuelos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckIn([Bind(Include = "idPase,pasaporte")] gestionVuelo gestionVuelo)
        {
            if (ModelState.IsValid)
            {
                db.checkIn(gestionVuelo.idPase,gestionVuelo.pasaporte);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(gestionVuelo);
        }

        // GET: gestionVuelos/Create
        public ActionResult CancelarVuelo()
        {
            return View();
        }

        // POST: gestionVuelos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CancelarVuelo([Bind(Include = "idPase,pasaporte")] gestionVuelo gestionVuelo)
        {
            if (ModelState.IsValid)
            {
                db.cancelarVuelo(gestionVuelo.idPase, gestionVuelo.pasaporte);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(gestionVuelo);
        }


        // GET: gestionVuelos/Create
        public ActionResult CheckInAdmin()
        {
            return View();
        }

        // POST: gestionVuelos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckInAdmin([Bind(Include = "idPase,pasaporte")] gestionVuelo gestionVuelo)
        {
            if (ModelState.IsValid)
            {
                db.checkIn(gestionVuelo.idPase, gestionVuelo.pasaporte);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            }

            return View(gestionVuelo);
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
