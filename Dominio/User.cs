using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    abstract public class User
    {
        private string email;
        private string rol;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Password { get => password; set => password = value; }

        public User(string email, string password, string rol)
        {
            this.email = email;
            this.password = password;
            this.rol = rol;
        }

        public static bool ValidoUser(string email, string pass)
        {
            return !string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(pass);
        }


        public override string ToString()
        {
            return $"{Email} || {Rol}";
        }

        public override bool Equals(object obj)
        {
            return obj is User user && email == user.Email && rol == user.Rol && password == user.Password;
        }
    }
}
