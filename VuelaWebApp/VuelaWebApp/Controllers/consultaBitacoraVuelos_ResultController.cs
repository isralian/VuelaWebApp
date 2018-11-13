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
    public class consultaBitacoraVuelos_ResultController : Controller
    {
        private Entities db = new Entities();

        // GET: consultaBitacoraVuelos_Result
        public ActionResult HistorialVuelos()
        {
            return View(db.consultaBitacoraVuelos(Session["USER"].ToString()).ToList());//db.consultaBitacoraVuelos((Session["USERID"].ToString())).ToList()
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
