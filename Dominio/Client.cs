using System;
using System.Collections.Generic;
using static Validation.Validator;


namespace Dominio
{
    public class Client : User
    {
        private static int n = 0;

        private int iD;
        private string name;
        private string lastName;
        private List<Dish> cart;
        private Pedido pedido;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<Dish> Cart { get => cart; set => cart = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }

        public Client (string name, string lastName, string email, string password, string rol) : base(email, password, rol)
        {
            this.ID = n;
            this.name = name;
            this.lastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Rol = "cliente";
            this.Cart = new List<Dish>();
            this.Pedido = null;
            n++;
        }

        public static int CompareByLastName (Client client_one, Client client_two)
        {
            return String.Compare(client_one.LastName, client_two.LastName);
        }
        public void Cancel ()
        {
            ClearCart();
            Pedido = null;
        }
        public void Confirm ()
        {
            // pedido queda abierto
            Pedido.Open = true;
        }
        public void Close ()
        {
            Pedido.Open = false;
            Pedido = null;
        }
        public static bool IsValid (string name, string last_name, string email, string password)
        {
            bool isValidName = !string.IsNullOrEmpty(name) && SinNumeros(name) && EsTexto(name);
            bool isValidLastName = !string.IsNullOrEmpty(last_name) && SinNumeros(last_name) && EsTexto(name);
            bool isValidEmail = EsValido(email);
            bool isValidPassword = EsSegura(password);

            bool isValid = isValidName && isValidLastName && isValidEmail && isValidPassword;
            return isValid;
        }

        public List<Dish> GetCart ()
        {
            return Cart;
        }

        public void ClearCart ()
        {
            Cart = new List<Dish>();
        }

        public override string ToString()
        {
            return $"{Name} {LastName} || {Email}";
        }

        public override bool Equals(object obj)
        {
             return obj is Client client && Name == client.Name && LastName == client.LastName && Email == client.Email;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
