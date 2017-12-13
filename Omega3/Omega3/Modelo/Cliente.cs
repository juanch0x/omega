using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
   public class Cliente
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
        private int _impositiva_id;
        private string _nombre1;
        private string _nombre2;
        private string _nombre3;
        private string _telefono1;
        private string _telefono2;
        private string _telefono3;
        private string _email1;
        private string _email2;
        private string _email3;
        private decimal _maximo_credito;
        private string _flete;
        private string _plazo;


        public int Impositiva_Id { get => _impositiva_id; set => _impositiva_id = value; }
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
        public string Nombre1 { get => _nombre1; set => _nombre1 = value; }
        public string Nombre2 { get => _nombre2; set => _nombre2 = value; }
        public string Nombre3 { get => _nombre3; set => _nombre3 = value; }
        public string Telefono1 { get => _telefono1; set => _telefono1 = value; }
        public string Telefono2 { get => _telefono2; set => _telefono2 = value; }
        public string Telefono3 { get => _telefono3; set => _telefono3 = value; }
        public string Email1 { get => _email1; set => _email1 = value; }
        public string Email2 { get => _email2; set => _email2 = value; }
        public string Email3 { get => _email3; set => _email3 = value; }
        public decimal Maximo_credito { get => _maximo_credito; set => _maximo_credito = value; }
        public string Flete { get => _flete; set => _flete = value; }
        public string Plazo { get => _plazo; set => _plazo = value; }
    }

}