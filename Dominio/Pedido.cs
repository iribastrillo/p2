using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Dominio
{
    public class Pedido
    {
        private Service service;
        private Client client;
        private DateTime date;
        private bool open;
        private float finalPrice;
        [Display(Name = "Precio final")]
        public float FinalPrice { get => finalPrice; set => finalPrice = value; }

        public Service Service { get => service; set => service = value; }

        public Client Client { get => client; set => client = value; }
        [Display(Name = "Fecha")]
        public DateTime Date { get => date; set => date = value; }
        public bool Open { get => open; set => open = value; }

        public void Settle()
        {
            FinalPrice = Service.CalculateTotal();
        }
        public Pedido(Service service, Client client)
        {
            this.service = service;
            this.client = client;
            this.date = DateTime.Now;
            this.open = false;
        }
        public Pedido ()
        {

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
