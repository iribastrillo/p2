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
        public IActionResult Registro()
        {
            if (!instance.IsLoggedIn())
            {
                return View();
            } else
            {
                return RedirectToAction("Index", "Dish");
            }
            
        }
        public IActionResult Logout()
        {
            if (instance.IsLoggedIn())
            {
                instance.Logout();
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Dish");
            } else
            {
                return RedirectToAction("Index", "Dish");
            }
            
        }
        public IActionResult Login()
        {
            if (!instance.IsLoggedIn())
            {
                return View();
            } else
            {
                return RedirectToAction("Index", "Dish");
            }    
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (!instance.IsLoggedIn())
            {
                User buscado = instance.Login(email, password);
                if (buscado != null)
                {
                    HttpContext.Session.SetString("LogueadoEmail", buscado.Email);
                    HttpContext.Session.SetString("LogueadoRol", buscado.Rol);
                    return RedirectToAction("Index", "Dish");
                }
                else
                {
                    ViewBag.msg = "Error en los datos";
                    return View();
                }
            } else
            {
                return Forbid();
            }
        }
        [HttpPost]
        public IActionResult Registro(string name, string lastname, string email, string password)
        {
            if (!instance.IsLoggedIn())
            {
                User buscado = instance.GetUser(email);
                bool contraSegura = Validation.Validator.EsSegura(password);
                if (buscado == null && contraSegura)
                {
                    if (instance.AltaCliente(name, lastname, email, password) != null)
                    {
                        instance.AltaCliente(name, lastname, email, password);
                        ViewBag.msg = "Alta exitosa! Inicie sesión.";
                    }
                    else
                    {
                        ViewBag.msg = "Error en los datos";
                    }
                }
                else
                {
                    ViewBag.msg = "Error en los datos";

                }
                return View();
            } else
            {
                return Forbid();
            }
            
        }
    }
}
