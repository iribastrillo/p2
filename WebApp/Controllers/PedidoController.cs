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
            string email = HttpContext.Session.GetString("LogueadoEmail");
            Client client = instance.GetUser(email) as Client;
            Pedido pedido = new Pedido(client.OpenService, client);
            pedido.Settle();
            return RedirectToAction("Details", pedido);
        }

        public IActionResult Details (Pedido pedido)
        {    
            return View("Pedido", pedido);
        }
    }
}
