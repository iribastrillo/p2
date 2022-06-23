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
    public class RepartidorController : Controller
    {

        Manager.Manager instance = Manager.Manager.GetInstance();


        public IActionResult PedidosEntregados()
        {
            List<Pedido> pedidos = new List<Pedido>();
            if (instance.IsDeliveryman(instance.SessionUser))
            {
                Deliveryman deliveryman = instance.SessionUser as Deliveryman;
                pedidos = instance.ServiciosAtendidos(deliveryman);
            }
            return View(pedidos);
        }
    }
}
