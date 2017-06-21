using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    static class Usuario
    {
        public static string _user;
        public static string _password;
        public static int _id_rol;
        public static string _nombre;

        public static string User { get => _user; set => _user = value; }
        public static string Password { get => _password; set => _password = value; }
        public static int Id_rol { get => _id_rol; set => _id_rol = value; }
        public static string Nombre { get => _nombre; set => _nombre = value; }
    }
}
