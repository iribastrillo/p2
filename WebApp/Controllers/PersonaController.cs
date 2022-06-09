using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Dominio;
using Microsoft.AspNetCore.Http;

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

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            User buscado = instance.Login(email, password);
            if (instance.GetUser(email) != null)
            {

                HttpContext.Session.SetString("LogueadoEmail", buscado.Email);
                HttpContext.Session.SetString("LogueadoRol", buscado.Rol);
                // HttpContext.Session.SetString("LogueadoRol", buscado.GetType().Name);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.msg = "Error en los datos";

            }
            return View();

        }
    }
}
