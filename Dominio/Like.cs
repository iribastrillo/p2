using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Like
    {
        // instancia el like en un plato y un cliente específico
        public Like(Dish dish, Client client)
        {
            Dish = dish;
            Client = client;
        }

        public Dish Dish { get; set; }
        public Client Client { get; set; }
    }
}
