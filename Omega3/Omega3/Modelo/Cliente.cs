using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Cliente
    {
        private long id_cliente;
        private string cliente;
        private long telefono;
        private string direccion;
        private string provincia;
        private string localidad;
        private string email;

        public long gsid_cliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }

        public string gsproveedor
        {
            get { return this.cliente; }
            set { this.cliente = value; }

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
