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

        public IActionResult Registro()
        {
            return View();
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
                } else
                {
                    ViewBag.msg = "Error en los datos";
                }
            }
            else
            {
                ViewBag.msg = "Error en los datos";

            }
            return View();
        }
        public void Like ()
        {

        }
    }
}
