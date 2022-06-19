using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DishController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        
        public IActionResult Index()
        {
            return View(instance.GetDishes());
        }
        public IActionResult Like (string id)
        {
            int ID = int.Parse(id);
            instance.Likes(ID);
            return RedirectToAction("Index", instance.GetDishes());
        }
        public IActionResult Add (string id)
        {
            int ID = int.Parse(id);
            instance.AddToOrder (ID);
            return View("Index", instance.GetDishes());
        }
        public IActionResult Remove (string id)
        {
            int ID = int.Parse(id);
            instance.RemoveFromOrder(ID);
            return RedirectToAction("Order", "Client", instance.GetCartForCurrentUser());
        }
    }
}
