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
            Client client = instance.SessionUser as Client;
            ViewBag.Open = false;
            if (client != null)
            {
                if (client.Cart != null)
                {
                    ViewBag.Cart = client.Cart;
                }
            }
            if (client != null)
            {
                if (client.Pedido != null)
                {
                    if (client.Pedido.Open)
                    {
                        ViewBag.Open = true;
                    }
                }
            }
            return View(instance.GetDishes());
        }
        public IActionResult Like (string id)
        {
            int ID = int.Parse(id);
            instance.Likes(ID);
            return RedirectToAction("Index");
        }
        //activado por actionLink
        public IActionResult Add (string id)
        {
            int ID = int.Parse(id);
            instance.AddToOrder (ID);
            return RedirectToAction("Index");
        }
        public IActionResult Remove (string id)
        {
            int ID = int.Parse(id);
            instance.RemoveFromOrder(ID);
            return RedirectToAction("Cart", "Client", instance.GetCartForCurrentUser());
        }
    }
}
