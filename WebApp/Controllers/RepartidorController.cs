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

            string emailLog = HttpContext.Session.GetString("LogueadoEmail");

            List<Delivery> misOperaciones = instance.PedidosEntregados(emailLog);

            return View(misOperaciones);
        }

    }
}
