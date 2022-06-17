using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;

namespace WebApp.Controllers
{
    public class PedidoController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details ()
        {
            /* Controla acceso a la vista del pedido */
            return View();
        }
    }
}
