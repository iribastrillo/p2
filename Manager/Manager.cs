using System.Collections.Generic;
using Dominio;
using System;

namespace Manager
{
    public class Manager
    {
        public static Manager instance { get; set; }

        private List<Dish> dishes = new List<Dish>();
        private List<Client> clients = new List<Client>();
        private List<Waiter> waiters = new List<Waiter>();
        private List<Service> services = new List<Service>();
        private List<Deliveryman> repartidores = new List<Deliveryman>();
        private List<Pedido> pedidos = new List<Pedido>();
        private List<User> usuarios = new List<User>();
        private List<Local> locales = new List<Local>();
        private List<Delivery> aDomicilio = new List<Delivery>();

        private Manager()
        {
            PrecargarDatos();
        }

        public static Manager GetInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }

        public List<Dish> GetDishes()
        {
            dishes.Sort(PorNombreDish);
            return dishes;
        }

        private int PorNombreDish(Dish a, Dish b)
        {
            if (a.Name.CompareTo(b.Name) > 0)
            {
                return 1;
            }
            else if (a.Name.CompareTo(b.Name) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        private int PorFechaRepartos(Delivery a, Delivery b)
        {
            if (a.Delivered.CompareTo(b.Delivered) > 0)
            {
                return 1;
            }
            else if (a.Delivered.CompareTo(b.Delivered) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        // ERA INTERNAL pero no me andaba
        public User Login(string email, string password)
        {
            User u = null;
            foreach (User user in Usuarios)
            {
                if (user.Email.Equals(email) && user.Password.Equals(password))
                {
                    u = GetUser(user.Email);
                    break;
                }
            }
            return u;

        }

        public User GetUser(string email)
        {
            foreach (User u in Usuarios)
            {
                if (u.Email.Equals(email))
                {
                    return u;
                }
            }
            return null;
        }

        public void PrecargarDatos()
        {
            Dish plato1 = AltaPlato("Sushi", 490);
            Dish plato2 = AltaPlato("Ñoquis", 600);
            Dish plato3 = AltaPlato("Pizza", 490);
            Dish plato4 = AltaPlato("Napolitana", 660);
            Dish plato5 = AltaPlato("Ensalada", 390);
            Dish plato6 = AltaPlato("Chivito", 550);
            Dish plato7 = AltaPlato("Rabas", 900);
            Dish plato8 = AltaPlato("Sandwich Caliente", 220);
            Dish plato9 = AltaPlato("Pollo", 450);
            Dish plato10 = AltaPlato("Hamburguesa", 350);

            Waiter waiter1 = AltaMozo("Hernan", "Pereira", "hernanpereira@gmail.com", "Hernan123");
            Waiter waiter2 = AltaMozo("Florencia", "Sánchez", "hernanpereira1@gmail.com", "Hernan123");
            Waiter waiter3 = AltaMozo("Facundo", "Ricaldoni", "hernanpereira2@gmail.com", "Hernan123");
            Waiter waiter4 = AltaMozo("Romina", "Hernández", "hernanpereira3@gmail.com", "Hernan123");
            Waiter waiter5 = AltaMozo("Sofía", "Siena", "hernanpereira4@gmail.com", "Hernan123");

            Deliveryman repartidor1 = AltaRepartidor("Agustina", "Balsas", Vehicle.Moto, "agu@hotmail.com", "Agustina123");
            Deliveryman repartidor2 = AltaRepartidor("Juan", "Pérez", Vehicle.Bicicleta, "agustina2@hotmail.com", "Agustina123");
            Deliveryman repartidor3 = AltaRepartidor("Gonzalo", "Pereira", Vehicle.Pie, "agustina3@hotmail.com", "Agustina123");
            Deliveryman repartidor4 = AltaRepartidor("Alejandro", "Marella", Vehicle.Bicicleta, "agustina4@hotmail.com", "Agustina123");
            Deliveryman repartidor5 = AltaRepartidor("Roberto", "Sánchez", Vehicle.Moto, "agustina5@hotmail.com", "Agustina123");

            Delivery delivery1 = AltaDelivery("Calle Falsa 122", 20, repartidor1, new List<Dish>() { plato1, plato7 });
            Delivery delivery2 = AltaDelivery("Calle Falsa 126", 20, repartidor2, new List<Dish>() { plato5, plato10, plato6 });
            Delivery delivery3 = AltaDelivery("Calle Falsa 123", 20, repartidor4, new List<Dish>() { plato6 });
            Delivery delivery4 = AltaDelivery("Calle Falsa 123", 20, repartidor1, new List<Dish>() { plato3, plato4 });
            Delivery delivery5 = AltaDelivery("Calle Falsa 123", 20, repartidor5, new List<Dish>() { plato9, plato8 });

            Client cliente1 = AltaCliente("Agustina", "Balsas", "agus@hotmail.com", "Agustina1B");
            Client cliente2 = AltaCliente("Ignacio", "Ribas", "ignacio@gmail.com", "Ignacio1R");
            Client cliente3 = AltaCliente("Alejo", "Krucheff", "alejo@outlook.com", "Alejo13B");
            Client cliente4 = AltaCliente("Anaru", "Martínez", "anaru@gmail.com", "Anaru1");
            Client cliente5 = AltaCliente("Juan", "Rodríguez", "juanr@outlook.com", "juanR13");

            Local local1 = AltaLocal(2, cliente1, new List<Dish>() { plato1, plato2 }, waiter2);
            Local local2 = AltaLocal(4, cliente2, new List<Dish>() { plato6, plato5, plato4 }, waiter3);
            Local local3 = AltaLocal(7, cliente3, new List<Dish>() { plato10 }, waiter1);
            Local local4 = AltaLocal(1, cliente4, new List<Dish>() { plato8, plato4 }, waiter4);
            Local local5 = AltaLocal(3, cliente5, new List<Dish>() { plato9, plato10, plato5 }, waiter5);

            Pedido pedido1 = AltaPedido(local1, cliente4);
            Pedido pedido2 = AltaPedido(local4, cliente5);
            Pedido pedido3 = AltaPedido(delivery4, cliente1);
            Pedido pedido4 = AltaPedido(local5, cliente2);
            Pedido pedido5 = AltaPedido(local2, cliente3);
            Pedido pedido6 = AltaPedido(local3, cliente5);
            Pedido pedido7 = AltaPedido(delivery1, cliente4);
            Pedido pedido8 = AltaPedido(delivery3, cliente1);
            Pedido pedido9 = AltaPedido(delivery2, cliente1);
            Pedido pedido10 = AltaPedido(delivery5, cliente3);
        }

        public List<Local> GetWaiterLocal(string email)
        {
            List<Local> ret = new List<Local>();
            if (email != null)
            {
                foreach (Local l in Locales)
                {
                    if (l.Mozo.Email == email)
                    {
                        ret.Add(l);
                    }
                }
            }
            return ret;

        }

        public List<Local> ServiciosAtendidos(DateTime f1, DateTime f2, string email)
        {
                List<Local> ret = new List<Local>();
                List<Local> propias = GetWaiterLocal(email);

            foreach (Pedido pedido in Pedidos)
            {
                foreach (Local p in propias)
                {
      
                    if (p.Equals(pedido.Service))
                        if (pedido.Date > f1 && pedido.Date < f2)
                    {
                        ret.Add(p);
                    }
                }

            }
                
                return ret;
            
        }


        public List<Delivery> PedidosEntregados(string email)
        {
            List<Delivery> ret = new List<Delivery>();
            foreach (Delivery d in ADomicilio)
            {
                if (d.Delivered < DateTime.Now)
                {
                    if(d.Deliveryman.Email == email)
                    {
                        ret.Add(d);
                    }
                }
            }
             ret.Sort(PorFechaRepartos);

            return ret;
        }

        public Pedido AltaPedido(Service service, Client client)
        {
            Pedido pedido = new Pedido(service, client);
            pedidos.Add(pedido);
            
            return pedido;
        }

        public User GetPersonaPorEmail(string email)
        {
            foreach (User u in usuarios)
            {
                if (u.Email.Equals(email))
                {
                    return u;
                }
            }
            return null;
        }

        public Client AltaCliente(string name, string last_name, string email, string password)
        {
            bool validado = Client.IsValid(name, last_name, email, password);

            if (validado == false)
                return null;

            Client cliente = new Client(name, last_name, email, password, "cliente");

            if (Clients.Contains(cliente))
                cliente = null;
            else
            {
                clients.Add(cliente);
                usuarios.Add(cliente);
            }
            return cliente;
        }

        public Waiter AltaMozo(string name, string last_name, string email, string password)
        {
            bool validado = Waiter.ValidWaiter(name, last_name);

            if (validado == false)
                return null;

            Waiter waiter = new Waiter(name, last_name, email, password, "mozo");

            if (Waiters.Contains(waiter))
                waiter = null;
            else
            {
                waiters.Add(waiter);
                usuarios.Add(waiter);

            }
            return waiter;
        }


        public Deliveryman AltaRepartidor(string name, string last_name, Vehicle vehicle, string email, string password)
        {
            bool validado = Deliveryman.ValidoRepartidor(name, last_name);

            if (validado == false)
                return null;

            if (vehicle == Vehicle.Moto)
            {
                vehicle = Vehicle.Moto;
            }

            Deliveryman repartidor = new Deliveryman(name, last_name, vehicle, email, password, "repartidor");

            if (Deliverymen.Contains(repartidor))
                repartidor = null;
            else
            {
                repartidores.Add(repartidor);
                usuarios.Add(repartidor);
            }

            return repartidor;
        }

        public Delivery AltaDelivery(string address, float distance, Deliveryman deliveryman, List<Dish> dishes)
        {
            Delivery delivery = new Delivery(address, distance, deliveryman, dishes);
            services.Add(delivery);
            aDomicilio.Add(delivery);

            return delivery;
        }

        public Local AltaLocal(int table, Client cliente, List<Dish> dishes, Waiter mozo)
        {
            Local local = new Local(table, dishes, mozo);

            local.AddGuest(cliente);
            services.Add(local);
            locales.Add(local);
            
            return local;
        }

        public Dish AltaPlato(string name, float price)
        {
            bool validado = Dish.ValidarDatos(name, price);

            if (validado == false)
                return null;

            Dish plato = new Dish(name, price);

            if (Dishes.Contains(plato))
                plato = null;
            else
                Dishes.Add(plato);

            return plato;
        }


        public List<Deliveryman> Deliverymen
        {
            get
            {
                return repartidores;
            }

            set
            {
                repartidores = value;
            }
        }

        public List<Pedido> Pedidos
        {
            get
            {
                return pedidos;
            }

            set
            {
                pedidos = value;
            }
        }

        public List<Client> Clients
        {
            get
            {
                return clients;
            }

            set
            {
                clients = value;
            }
        }
        public List<Dish> Dishes
        {
            get
            {
                return dishes;
            }

            set
            {
                dishes = value;
            }
        }
        public List<Waiter> Waiters
        {
            get
            {
                return waiters;
            }

            set
            {
                waiters = value;
            }
        }
        public List<Service> Services
        {
            get
            {
                return services;
            }

            set
            {
                services = value;
            }
        }

        public List<User> Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }

        public List<Delivery> ADomicilio
        {
            get
            {
                return aDomicilio;
            }

            set
            {
                aDomicilio = value;
            }
        }

        public List<Local> Locales
        {
            get
            {
                return locales;
            }

            set
            {
                locales = value;
            }
        }
    }
}