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
        public IActionResult VerServicios()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cart ()
        {
            ViewBag.Checkout = false;
            string loggedEmail = HttpContext.Session.GetString("LogueadoEmail");
            return View(instance.GetCartForCurrentUser());
        }
        [HttpPost]
        public IActionResult Cart (string isDelivery)
        {
            Pedido pedido = instance.BuildPedido(false);
            Local service = pedido.Service as Local;
            ViewBag.Costo = pedido.Service.CalculateSubtotal();
            ViewBag.Cubierto = service.Cover;
            ViewBag.Total = pedido.Service.CalculateSubtotal();
            ViewBag.Checkout = true;
            return View(instance.GetCartForCurrentUser());
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
