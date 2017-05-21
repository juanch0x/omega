using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    public class Proveedor
    {

        private long _id_proveedor;
        private string _nombre_proveedor;
        private long _telefono;
        private string _direccion;
        private string _provincia;
        private string _localidad;
        private string _email;

        public long Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public string Nombre_proveedor { get => _nombre_proveedor; set => _nombre_proveedor = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string Email { get => _email; set => _email = value; }
    }
    

}
