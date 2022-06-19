using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Dominio;

namespace WebApp.Controllers
{
    public class ClientController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        public IActionResult Likes()
        {
            return View();
        }
        public IActionResult VerServicios()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Order ()
        {
            ViewBag.Checkout = false;
            string loggedEmail = HttpContext.Session.GetString("LogueadoEmail");
            return View(instance.GetOpenOrderForCurrentUser(loggedEmail));
        }
        [HttpPost]
        public IActionResult Order (bool asDelivery)
        {
            string email = HttpContext.Session.GetString("LogueadoEmail");
            Service service = instance.BuildService(email, false);
            Client client = instance.GetUser(email) as Client;

            if (!asDelivery)
            {
                Local openService = client.OpenService as Local;
                ViewBag.Costo = openService.CalculateSubtotal();
                ViewBag.Cubierto = openService.Cover;
            }
            ViewBag.Total = client.OpenService.CalculateTotal();
            ViewBag.Checkout = true;
            return View(instance.GetOpenOrderForCurrentUser(email));
        }

        [HttpPost]
        public IActionResult VerServicios(DateTime f1, DateTime f2)
        {
            string loggedEmail = HttpContext.Session.GetString("LogueadoEmail");
            List<Pedido> comienzo = instance.GetServicios(loggedEmail);
            List<Pedido> retorno = new List<Pedido>();
            foreach (Pedido p in comienzo)
            {
                if (p.Date > f1 && p.Date < f2)
                {
                    retorno.Add(p);
                }
            }
            return View(retorno);
        }

    }
}
