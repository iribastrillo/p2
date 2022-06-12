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
    public class HomeController : Controller
    {

        Manager.Manager instance = Manager.Manager.GetInstance();


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string logueadoRol = HttpContext.Session.GetString("LogueadoRol");
            if (logueadoRol != null)
            {
                if (logueadoRol == "mozo" || logueadoRol == "cliente" || logueadoRol== "repartidor")
                {
                    string email = HttpContext.Session.GetString("LogueadoEmail");
                    string rol = HttpContext.Session.GetString("LogueadoRol");
                    User user = instance.GetUser(email);
                    ViewBag.msg = $"Hola {user.Email} ";
                    ViewBag.mes = $" {rol} ";
                } 

            }
            else
            {
                ViewBag.msg = $"Inicie sesión para acceder";
            }

            return View();
        }

        public IActionResult Cathalog ()
        {
            return null;
        }

        public IActionResult Team()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
