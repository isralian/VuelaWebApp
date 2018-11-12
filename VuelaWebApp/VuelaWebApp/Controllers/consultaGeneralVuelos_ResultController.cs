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
    public class consultaGeneralVuelos_ResultController : Controller
    {
        private Entities db = new Entities();

        // GET: consultaGeneralVuelos_Result
        public ActionResult VuelosLista()
        {
            return View(db.consultaGeneralVuelos().ToList());
        }


        public ActionResult VuelosFiltrados(string paisOrigen, string paisDestino)
        {
            return View(db.consultaFitradaVuelos(paisOrigen,paisDestino).ToList());

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
