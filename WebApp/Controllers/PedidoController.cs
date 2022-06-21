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
    public class PedidoController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirm ()
        {
            Client client = instance.SessionUser as Client;
            client.Pedido.Settle();
            return RedirectToAction("Details");
        }

        public IActionResult Details ()
        {
            Client client = instance.SessionUser as Client;
            if (client.Pedido.Open)
            {
                return RedirectToAction("Open");
            }
            ViewBag.isDelivery = false;
            ViewBag.Subtotal = client.Pedido.Service.CalculateSubtotal();
            ViewBag.Total = client.Pedido.FinalPrice;
            if (client.Pedido.Service is Delivery)
            {
                Delivery delivery = client.Pedido.Service as Delivery;
                ViewBag.isDelivery = true;
                ViewBag.Extra = delivery.Extra;
            } else
            {
                Local local = client.Pedido.Service as Local;
                ViewBag.Tip = local.Tip;
                ViewBag.CoverCost = local.CoverCost;
            }
            ViewBag.Service = client.Pedido.Service;
            ViewBag.Cart = client.Cart;
            return View("Pedido", client.Pedido);
        }
        public IActionResult Success()
        {
            if (instance.IsLoggedIn())
            {
                if (instance.IsClient (instance.SessionUser))
                {
                    Client client = instance.SessionUser as Client;
                    if (client.Pedido != null)
                    {
                        client.Confirm();
                        client.ClearCart();
                        return View();
                    }
                    else
                    {
                        return Forbid();
                    }
                } else
                {
                    return Forbid();
                }      
            } else
            {
                return Forbid();
            }
            
        }
        public IActionResult Cancel ()
        {
            Client client = instance.SessionUser as Client;
            client.Cancel();
            return View();
        }
        public IActionResult Close()
        {
            Client client = instance.SessionUser as Client;
            instance.AltaPedido(client.Pedido);
            client.Close();
            return RedirectToAction("Thanks");
        }
        public IActionResult Open()
        {
            if (instance.IsClient(instance.SessionUser))
            {
                Client client = instance.SessionUser as Client;
                return View(client.Pedido);
            }
            else
            {
                return Forbid();
            }
        }
        public IActionResult Thanks()
        {
            return View();
        }
    }
}
