using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    abstract class User
    {
        private string email;
        private string rol;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Password { get => password; set => password = value; }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        // public string AsignoRol()

        public static bool EsValido(string email, string pass)
        {
            return !string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(pass);
        }


        public override string ToString()
        {
            return $"{Email} || {Rol}";
        }

        public override bool Equals(object obj)
        {
            return obj is User user && idPersona == user.IdPersona && email == user.Email && rol == user.Rol && name == user.Name && lastname == user.Lastname && password == user.Password;
        }
    }
}
