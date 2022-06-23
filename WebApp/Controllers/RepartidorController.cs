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
<<<<<<< HEAD
            if (instance.IsDeliveryman(instance.SessionUser))
            {
                string emailLog = HttpContext.Session.GetString("LogueadoEmail");

                List<Delivery> misOperaciones = instance.PedidosEntregados(emailLog);

=======
<<<<<<< HEAD
            string emailLog = HttpContext.Session.GetString("LogueadoEmail");
            List<Pedido> pedidos = new List<Pedido>();
            if (instance.IsDeliveryman(instance.SessionUser))
            {
                Deliveryman deliveryman = instance.SessionUser as Deliveryman;
                pedidos = instance.ServiciosAtendidos(deliveryman);
            }
            return View(pedidos);
=======
            if (instance.IsDeliveryman(instance.SessionUser))
            {
                string emailLog = HttpContext.Session.GetString("LogueadoEmail");

                List<Delivery> misOperaciones = instance.PedidosEntregados(emailLog);

>>>>>>> pulidita
                return View(misOperaciones);
            } else
            {
                return Forbid();
            }
<<<<<<< HEAD
=======
>>>>>>> fb45374611b67ef36a89a4e8293d5d94e2bd0c8e
>>>>>>> pulidita
        }
    }
}
