using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Like
    {
        public Like(Dish dish, Client client)
        {
            Dish = dish;
            Client = client;
        }

        public Dish Dish { get; set; }
        public Client Client { get; set; }
    }
}
