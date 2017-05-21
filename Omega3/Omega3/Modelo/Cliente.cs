using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Cliente
    {
        private long _id_cliente;
        private string _nombre_cliente;
        private long _telefono;
        private string _direccion;
        private string _provincia;
        private string _localidad;
        private string _email;

        public long Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public string Nombre_cliente { get => _nombre_cliente; set => _nombre_cliente = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
