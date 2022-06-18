using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Dominio;
using Microsoft.AspNetCore.Http;
using Validation;

namespace WebApp.Controllers
{
    public class PersonaController : Controller
    {

        Manager.Manager instance = Manager.Manager.GetInstance();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            User buscado = instance.Login(email, password);
            if (buscado != null)
            {

                HttpContext.Session.SetString("LogueadoEmail", buscado.Email);
                HttpContext.Session.SetString("LogueadoRol", buscado.Rol);
                // HttpContext.Session.SetString("LogueadoRol", buscado.GetType().Name);
                return RedirectToAction("Index", "Dish");
            }
            else
            {
                ViewBag.msg = "Error en los datos";
                return View();
            }
        }
        [HttpPost]
        public IActionResult Registro(string name, string lastname, string email, string password)
        {

            User buscado = instance.GetUser(email);
            bool contraSegura = Validation.Validator.EsSegura(password);
            if (buscado == null && contraSegura)
            {
                if (instance.AltaCliente(name, lastname, email, password) != null)
                {
                    instance.AltaCliente(name, lastname, email, password);
                    ViewBag.msg = "Alta exitosa! Inicie sesión.";
                } else                {
                    ViewBag.msg = "Error en los datos";
                }
            }
            else
            {
                ViewBag.msg = "Error en los datos";

            }
            return View();
        }
    }
}
