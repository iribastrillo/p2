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
    public class MozoController : Controller
    {

        Manager.Manager instance = Manager.Manager.GetInstance();

        public IActionResult Atendidos()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Atendidos(DateTime f1, DateTime f2)
        {
            string logueadoEmail = HttpContext.Session.GetString("LogueadoEmail");

            List<Local> filtradas = instance.ServiciosAtendidos(f1, f2, logueadoEmail);

            return View(filtradas);
        }
    }
}
