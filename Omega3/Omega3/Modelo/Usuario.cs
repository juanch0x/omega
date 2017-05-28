using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Usuario
    {
        string _user;
        string _password;
        int _id_rol;
        string _nombre;

        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
        public int Id_rol { get => _id_rol; set => _id_rol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
