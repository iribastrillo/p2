using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;

namespace WebApp.Controllers
{
    public class ClientController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        public IActionResult Likes ()
        {
            return View();
        }
        public IActionResult Order ()
        {
            string loggedEmail = HttpContext.Session.GetString("LogueadoEmail");
            return View(instance.GetOpenOrderForCurrentUser(loggedEmail));
        }
    }
}
