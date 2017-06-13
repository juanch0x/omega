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
        private int _codigo_postal;
        private string _email;

        public long Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public string Nombre_proveedor { get => _nombre_proveedor; set => _nombre_proveedor = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public int Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public string Email { get => _email; set => _email = value; }
    }
    

}
