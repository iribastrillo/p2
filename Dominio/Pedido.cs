using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pedido
    {
        private Service service;
        private Client client;
        private DateTime date;
        private float finalPrice;



        public float FinalPrice { get => finalPrice; set => finalPrice = value; }

        public Service Service { get => service; set => service = value; }

        public Client Client { get => client; set => client = value; }

        public DateTime Date { get => date; set => date = value; }


        public Pedido(Service service, Client client)
        {
            this.service = service;
            this.client = client;
            this.date = DateTime.Now;
        }

        public override string ToString()
        {
            if (service is Delivery)
            {
                Delivery delivery = (Delivery)service;
                return $"{service} || {client} || {date} || Delivery: {delivery.Deliveryman.Name}";
            }  else
            {
                return $"{service} || {client} || {date}";
            }
            
        }

    }
}
