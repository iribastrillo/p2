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
        public IActionResult Delivery ()
        {
            Client client = instance.SessionUser as Client;
            if (instance.IsClient(instance.SessionUser))
            {
                
                Pedido pedido = instance.BuildPedido(true);
                client.Pedido = pedido;
                ViewBag.Checkout = false;
                return View(client.Pedido);
            } else
            {
                if (client.Pedido.Open)
                {
                    return RedirectToAction("Open", "Pedido", client.Pedido);
                }
                else
                {
                    ViewBag.Checkout = false;
                    return View(client.Pedido);
                }
            }
        }
        public IActionResult MayorPrecio()
        {
            List<Pedido> retorno = instance.ObtenerMayorPrecio();
            return View(retorno);
        }

        [HttpPost]
        public IActionResult VerServicios(DateTime f1, DateTime f2)
        {
            List<Pedido> retorno = instance.VerServiciosPorFecha(f1, f2);
            return View(retorno);
        }

        public IActionResult VerPedidosPorPlato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerPedidosPorPlato(string plato)
        {
            List<Pedido> retorno = instance.VerPedidosPorPlato(plato);
            return View(retorno);
        }

    }
}
