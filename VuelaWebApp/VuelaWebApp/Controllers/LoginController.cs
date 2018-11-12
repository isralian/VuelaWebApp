using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuelaWebApp.Models;

namespace VuelaWebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            var email = form["correoElectronico"];
            var pass = form["contraseña"];
            if (ModelState.IsValid)
            {
                using (Entities db = new Entities())
                {
                    var u = db.cuenta.Where(a => a.usuario.Equals(email) && a.clave.Equals(pass)).FirstOrDefault();
                    if (u != null)//existe la cuenta
                    {
                        var tipo=db.tipoUsuario(email).FirstOrDefault();
                        if(tipo == "administrador")
                        {
                            empleado empleado = new empleado();
                            empleado.usuario = u.usuario;
                            Session["USER"] = empleado.usuario;
                            return RedirectToAction("Index", "Home");
                        }
                        else if(tipo == "cliente")
                        {
                            cliente cliente = new cliente();
                            cliente.usuario = u.usuario;
                            Session["USER"] = cliente.usuario;
                            return RedirectToAction("About", "Home");
                        }
                        else
                        {
                            ViewBag.Error = "Correo o Contraseña incorrecta";
                        }
                    }
                    else
                    {
                        ViewBag.Error = "La cuenta no existe";
                    }
                }
            }
            return PartialView(form);
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}

