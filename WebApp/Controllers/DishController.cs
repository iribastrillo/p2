<<<<<<< HEAD
﻿using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
=======
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
>>>>>>> 8eba32cac26465a3452c0ab76ca4cf05e9fbf103
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
            instance.Likes(HttpContext.Session.GetString("LogueadoEmail"), id);
            return View("Index", instance.GetDishes());
        }

        public IActionResult Add (string id)
        {
            int ID = int.Parse(id);
            string email = HttpContext.Session.GetString("LogueadoEmail");
            instance.AddToOrder (email, ID);
            return View("Index", instance.GetDishes());
        }
    }
}
