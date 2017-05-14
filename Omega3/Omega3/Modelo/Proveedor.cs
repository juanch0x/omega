using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    public class Proveedor
    {

        private long id_proveedor;
        private string proveedor;
        private long telefono;
        private string direccion;
        private string provincia;
        private string localidad;
        private string email;

        public long Id_proveedor {
            get { return this.id_proveedor; }
            set { this.id_proveedor = value; }
        }

        public string Proveedor {
            get { return this.proveedor; }
            set { this.proveedor = value; }

        }

    }
}
