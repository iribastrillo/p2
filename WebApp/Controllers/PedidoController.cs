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
        public IActionResult DisplayOpen ()
        {
            Client client = instance.SessionUser as Client;
            client.Pedido.Settle();
            return RedirectToAction("Details");
        }

        public IActionResult Details ()
        {
            Client client = instance.SessionUser as Client;
            ViewBag.Service = client.Pedido.Service;
            ViewBag.Cart = client.Cart;
            return View("Pedido", client.Pedido);
        }
        public IActionResult Success()
        {
            Client client = instance.SessionUser as Client;
            client.Confirm();
            client.ClearCart();
            return View();
        }
    }
}
