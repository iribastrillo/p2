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
            if (instance.IsLoggedIn())
            {
                if (instance.SessionUser is Waiter)
                {
                    return View();
                } else
                {
                    return RedirectToAction("Index", "Dish");
                }
            } else
            {
                return RedirectToAction("Index", "Dish");
            }
        }


        [HttpPost]
        public IActionResult Atendidos(DateTime f1, DateTime f2)
        {
            if (instance.IsLoggedIn())
            {
                if (instance.SessionUser is Waiter)
                {
                    string logueadoEmail = HttpContext.Session.GetString("LogueadoEmail");
                    List<Local> filtradas = instance.ServiciosAtendidos(f1, f2, logueadoEmail);

                    if (filtradas.Count == 0)
                    {
                        ViewBag.mensajeFechas = "No existen pedidos servidos en estas fechas";
                    }
                    return View(filtradas);
                }
                else
                {
                    return RedirectToAction("Index", "Dish");
                }
            }
            else
            {
                return RedirectToAction("Index", "Dish");
            }
            
        }
    }
}
