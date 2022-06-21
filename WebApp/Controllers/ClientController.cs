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
    public class ClientController : Controller
    {
        Manager.Manager instance = Manager.Manager.GetInstance();
        public IActionResult VerServicios()
        {
            if (instance.IsLoggedIn())
            {
                if (instance.SessionUser is Client)
                {
                    return View();
                } else
                {
                    return RedirectToAction("Index", "Dish");
                }
            } else
            {
                return RedirectToAction("Index", "Dish");
            }
        }
        public IActionResult Cuenta()
        {
            if (instance.IsLoggedIn())
            {
                if (instance.SessionUser is Client)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Dish");
                }
            }
            else
            {
                return RedirectToAction("Index", "Dish");
            }
        }
        public IActionResult Cart ()
        {
            if (instance.IsLoggedIn ())
            {
                if (instance.IsClient(instance.SessionUser))
                {
                    Client client = instance.SessionUser as Client;
                    if (client.Pedido == null)
                    {
                        return View(instance.GetCartForCurrentUser());
                    }
                    else
                    {
                        if (client.Pedido.Open)
                        {
                            return RedirectToAction("Open", "Pedido", client.Pedido);
                        }
                        else
                        {
                            return View(instance.GetCartForCurrentUser());
                        }
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Dish");
                }
            } else
            {
                return RedirectToAction("Index", "Dish");
            }
            
        }
        [HttpGet]
        public IActionResult Local()
        {
            Client client = instance.SessionUser as Client;
            if (instance.IsClient(instance.SessionUser))
            {
                //Hay que cambiar esto, no hacer el alta hasta que el usuario confirme.
                Pedido pedido = instance.BuildPedido(false);
                client.Pedido = pedido;
                ViewBag.Dishes = pedido.Service.Dishes;
                if (client.Pedido.Open)
                {
                    return RedirectToAction("Open", "Pedido", client.Pedido);
                }
                else
                {
                    return View(client.Pedido);
                }
            }
            else
            {
                return Forbid();
            }

        }
        [HttpPost]
        public IActionResult Local(string guests)
        {
            Client client = instance.SessionUser as Client;
            Random random = new Random();
            if (instance.IsClient(instance.SessionUser))
            {
                Local local = client.Pedido.Service as Local;
                ViewBag.Dishes = local.Dishes;
                if (guests != null)
                {
                    int n = int.Parse(guests);
                    local.Guests = n;
                    if (client.Pedido.Open)
                    {
                        return RedirectToAction("Open", "Pedido", client.Pedido);
                    }
                    else
                    {
                        return RedirectToAction("Confirm", "Pedido", client.Pedido);
                    }
                }
                else
                {
                    ViewBag.ErrorAddress = "Debes ingresar la cantidad de comensales :)";
                    return View(client.Pedido);
                }
            }
            else
            {
                return Forbid();
            }
        }
        [HttpGet]
        public IActionResult Delivery ()
        {
            Client client = instance.SessionUser as Client;
            if (instance.IsClient(instance.SessionUser))
            {
                Pedido pedido = instance.BuildPedido(true);
                client.Pedido = pedido;
                ViewBag.Dishes = pedido.Service.Dishes;
                if (client.Pedido.Open)
                {
                    return RedirectToAction("Open", "Pedido", client.Pedido);
                }
                else
                {
                    return View(client.Pedido);
                }
            } else
            {
                return Forbid();
            }
           
        }
        [HttpPost]
        public IActionResult Delivery (string address)
        {
            Client client = instance.SessionUser as Client;
            Random random = new Random();
            if (instance.IsClient(instance.SessionUser))
            {
                Delivery delivery = client.Pedido.Service as Delivery;
                ViewBag.Dishes = delivery.Dishes;
                if (address != null)
                {
                    ViewBag.Costo = delivery.CalculateSubtotal();
                    ViewBag.Total = delivery.CalculateTotal();
                    ViewBag.Extra = delivery.Extra;
                    delivery.Address = address;
                    delivery.Distance = (float) random.NextDouble() * 50;
                    if (client.Pedido.Open)
                    {
                        return RedirectToAction("Open", "Pedido", client.Pedido);
                    }
                    else
                    {
                        return RedirectToAction ("Confirm", "Pedido", client.Pedido);
                    }
                } else
                {
                    ViewBag.ErrorAddress = "Por favor, ingresar una dirección para el delivery :)";
                    return View(client.Pedido);
                }
            } else
            {
                return Forbid();
            }
        }
        public IActionResult MayorPrecio()
        {
            List<Pedido> retorno = instance.ObtenerMayorPrecio();
            return View(retorno);
        }

        [HttpPost]
        public IActionResult VerServicios(DateTime? f1, DateTime? f2)
        {
            if (f1 == null || f2 == null)
            {
                ViewBag.mensajeFechas = "Ingrese fechas";
            }

            List<Pedido> retorno = instance.VerServiciosPorFecha(f1, f2);


            return View(retorno);
        }

        public IActionResult VerPedidosPorPlato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerPedidosPorPlato(string plato)
        {
            List<Pedido> retorno  = instance.VerPedidosPorPlato(plato);

            if (retorno.Count() == 0)
            {
                ViewBag.mensajeVer = "Plato no existe";
            }
            return View(retorno);
        }

    }
}
