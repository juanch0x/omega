using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Cliente
    {
        private int _tipo_documento;
        private long _documento;
        private string _razon;
        private string _direccion;
        private long _telefono;
        private int _cod_provincia;
        private string _localidad;
        private int _codigo_postal;
        private string _contacto;
        private string _mail_contacto;
        private string _mail_factura;
        private string _impositiva;
        private decimal _lista;
        private string _provincia;


        public int Tipo_documento { get => _tipo_documento; set => _tipo_documento = value; }
        public long Documento { get => _documento; set => _documento = value; }
        public string Razon { get => _razon; set => _razon = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public int Cod_provincia { get => _cod_provincia; set => _cod_provincia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public int Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string Mail_contacto { get => _mail_contacto; set => _mail_contacto = value; }
        public string Mail_factura { get => _mail_factura; set => _mail_factura = value; }
        public string Impositiva { get => _impositiva; set => _impositiva = value; }
        public decimal Lista { get => _lista; set => _lista = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
    }

}