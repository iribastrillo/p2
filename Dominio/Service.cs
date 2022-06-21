using System;
using System.Collections.Generic;

namespace Dominio
{
    public abstract class Service
    {
        protected List<Dish> dishes;

        public List<Dish> Dishes { get => dishes; set => dishes = value; }

        public Service (List<Dish> dishes)
        {
            this.dishes = dishes;
        }
        public abstract float CalculateTotal();
        public abstract float CalculateSubtotal();

        public void AddDish (Dish dish)
        {
            Dishes.Add(dish);
        }

    }
    
    public class Delivery : Service
    {
        private string address;
        private float distance;
        private Deliveryman deliveryman;
        private float extra;
        public DateTime Delivered { get; set; }
        public void Deliver()
        {
            Delivered = new DateTime(01/01/2020);
        }

        public Delivery (string address, float distance, Deliveryman deliveryman, List<Dish> dishes) : base ( dishes)
        {
            this.address = address;
            this.distance = distance;
            this.deliveryman = deliveryman;
            this.extra = 0;
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public float Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public Deliveryman Deliveryman { get => deliveryman; set => deliveryman = value; }
        public float Extra { get => extra; set => extra = value; }

        public override float CalculateSubtotal()
        {
            float subtotal = 0;
            foreach (var dish in Dishes)
            {
                subtotal += dish.Price;
            }
            return subtotal;
        }

        public override float CalculateTotal()
        {
             /*
             * Si la entrega es mediante Delivery se agregan $50 de envío
             * en las distancias menores a 2 km, y va a aumentando $10 por
             * cada kilómetro, hasta un máximo de $100. 
             */
            float total = 0;
            float extra = 0;

            foreach (var dish in Dishes)
            {
                total += dish.Price;
            }

            if (distance >= 2)
            {
                for (int i = 0; i < distance - 2; i++)
                {
                    extra += 10;
                    extra = Math.Min(extra, 100);
                }
            }
            Extra = extra;
            return total + extra;
        }
        public override string ToString()
        {
            return $"{address} || {distance}";
        }

        public int CompareTo(Delivery other)
        {
            if (Delivered.CompareTo(other.Delivered) > 0)
            {
                return 1;
            }
            else if (Delivered.CompareTo(other.Delivered) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    } 

    public class Local : Service
    {
        private Waiter mozo;
        private float tip;
        private float coverCost;
        private int table;
        private int guests;
        private static float cover = 100;
        

        public Local (int table, List<Dish> dishes, Waiter mozo) : base (dishes)
        {
            this.table = table;
            this.Guests = 0;
            this.mozo = mozo;
            this.tip = 0;
            this.coverCost = 0;
        }
        public int Table
        {
            get
            {
                return table;
            }

            set
            {
                table = value;
            }
        }

        public Waiter Mozo
        {
            get
            {
                return mozo;
            }

            set
            {
                mozo = value;
            }
        }
        public override float CalculateSubtotal()
        {
            float subtotal = 0;
            foreach (var dish in Dishes)
            {
                subtotal += dish.Price;
            }
            return subtotal;
        }

        public override float CalculateTotal ()
        {
            float total = 0;
            for (int i = 0; i < Guests; i++)
            {
                CoverCost += Cover;
            }
            total += CalculateSubtotal();
            total += CoverCost;
            Tip = (float)(total * 0.1);
            return total + Tip;
        }

        public float Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
            }
        }

        public float Tip { get => tip; set => tip = value; }
        public int Guests { get => guests; set => guests = value; }
        public float CoverCost { get => coverCost; set => coverCost = value; }

        public override string ToString()
        {
            return $" {mozo.Name} || {table} || {cover}";
          
        }

        public override bool Equals(object obj)
        {
            return obj is Local local && mozo == local.Mozo && table == local.Table && Guests == local.Guests && cover == local.Cover;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

    }
}