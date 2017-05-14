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

        public string gsproveedor {
            get { return this.proveedor; }
            set { this.proveedor = value; }

        }

        public long gstelefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string gsdireccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string gsprovincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }

        public string gslocalidad
        {
            get { return this.localidad; }
            set { this.localidad = value; }
        }

        public string gsemail
        {
            get { return this.email; }
            set { this.email = value; }
        }

    }
}
