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
        public IActionResult Cart ()
        {
            if (instance.IsClient(instance.SessionUser))
            {
                Client client = instance.SessionUser as Client;
                if (client.Pedido == null)
                {
                    ViewBag.Checkout = false;
                    return View(instance.GetCartForCurrentUser());
                } else
                {
                    if (client.Pedido.Open)
                    {
                        return RedirectToAction("Open", "Pedido", client.Pedido);
                    } else
                    {
                        ViewBag.Checkout = false;
                        return View(instance.GetCartForCurrentUser());
                    }
                }
            } else
            {
                return Forbid();
            }
        }
        public IActionResult Local ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delivery ()
        {
            Client client = instance.SessionUser as Client;
            if (instance.IsClient(instance.SessionUser))
            {
                Pedido pedido = instance.BuildPedido(true);
                client.Pedido = pedido;
                ViewBag.Checkout = false;
                ViewBag.Dishes = pedido.Service.Dishes;
                if (client.Pedido.Open)
                {
                    return RedirectToAction("Open", "Pedido", client.Pedido);
                }
                else
                {
                    ViewBag.Checkout = false;
                    return View(client.Pedido);
                }
            } else
            {
                return Forbid();
            }
           
        }
        [HttpPost]
        public IActionResult Delivery (string address)
        {
            Client client = instance.SessionUser as Client;
            Random random = new Random();
            if (instance.IsClient(instance.SessionUser))
            {
                Delivery delivery = client.Pedido.Service as Delivery;
                ViewBag.Dishes = delivery.Dishes;
                if (address != null)
                {
                    ViewBag.Checkout = true;
                    ViewBag.Costo = delivery.CalculateSubtotal();
                    ViewBag.Total = delivery.CalculateTotal();
                    ViewBag.Extra = delivery.Extra;
                    delivery.Address = address;
                    delivery.Distance = (float) random.NextDouble() * 50;
                    if (client.Pedido.Open)
                    {
                        return RedirectToAction("Open", "Pedido", client.Pedido);
                    }
                    else
                    {
                        ViewBag.Checkout = true;
                        return View(client.Pedido);
                    }
                } else
                {
                    ViewBag.Checkout = false;
                    ViewBag.ErrorAddress = "Debes ingresar una dirección para el delivery :)";
                    return View(client.Pedido);
                }
            } else
            {
                return Forbid();
            }
        }
        public IActionResult MayorPrecio()
        {
            string loggedEmail = HttpContext.Session.GetString("LogueadoEmail");
            List<Pedido> comienzo = instance.GetServicios(loggedEmail);
            List<Pedido> retorno = new List<Pedido>();

            Pedido elmayor = comienzo[0];
            foreach (Pedido p in comienzo)
            {
                if (p.FinalPrice > elmayor.FinalPrice)
                {
                    retorno.Add(p);
                    elmayor = p;
                } else if (p.FinalPrice == elmayor.FinalPrice)
                {
                    retorno.Add(p);
                }
            }

            return View(retorno);
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
