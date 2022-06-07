using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Dominio
{
    public abstract class Employee : User
    {
        private static int n = 0;

        private int iD;
        private string name;
        private string lastName;

        public Employee(string name, string lastName, string email, string password, string rol) : base(email,  password,  rol)
        {
            ID = n;
            Name = name;
            LastName = lastName;

            n++;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
