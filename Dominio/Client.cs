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
        private List<Dish> orden;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<Dish> Orden { get => orden; set => orden = value; }

        public Client (string name, string lastName, string email, string password, string rol) : base(email, password, rol)
        {
            this.ID = n;
            this.name = name;
            this.lastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Rol = "cliente";
            this.Orden = new List<Dish>();
            n++;
        }

        public static int CompareByLastName (Client client_one, Client client_two)
        {
            return String.Compare(client_one.LastName, client_two.LastName);
        }

        public static bool IsValid (string name, string last_name, string email, string password)
        {
            bool isValidName = !string.IsNullOrEmpty(name) && SinNumeros(name);
            bool isValidLastName = !string.IsNullOrEmpty(last_name) && SinNumeros(last_name);
            bool isValidEmail = EsValido(email);
            bool isValidPassword = EsSegura(password);

            bool isValid = isValidName && isValidLastName && isValidEmail && isValidPassword;
            return isValid;
        }

        public List<Dish> GetPedido ()
        {
            return Orden;
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
