using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ContenidoController : Controller
    {

        Manager.Manager instance = Manager.Manager.GetInstance();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerServicio()
        {
            if (HttpContext.Session.GetString("LogueadoRol") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (HttpContext.Session.GetString("LogueadoRol") == "mozo")
            {
                return RedirectToAction("Index", "Home");
            }

            if (HttpContext.Session.GetString("LogueadoRol") == "repartidor")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        [HttpPost]
        public IActionResult VerServicio(DateTime f1, DateTime f2)
        {
            string email = HttpContext.Session.GetString("LogueadoEmail");
            List<Pedido> filtrada = instance.ObtenerOperacionesEntre(f1, f2, email);

            return View(filtrada);
        }
    }
}
