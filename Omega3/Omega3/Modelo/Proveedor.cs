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
        private string _email2;
        private string _email3;
        private string _nombre1;
        private string _nombre2;
        private string _nombre3;
        private string _telefono1;
        private string _telefono2;
        private string _telefono3;

        private PuntajeProveedor _puntaje;

        public long Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public string Nombre_proveedor { get => _nombre_proveedor; set => _nombre_proveedor = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public int Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public string Email { get => _email; set => _email = value; }
        public string Email2 { get => _email2; set => _email2 = value; }
        public string Email3 { get => _email3; set => _email3 = value; }
        
        public PuntajeProveedor puntaje { get => _puntaje; set => _puntaje = value; }
        public string Nombre1 { get => _nombre1; set => _nombre1 = value; }
        public string Nombre2 { get => _nombre2; set => _nombre2 = value; }
        public string Nombre3 { get => _nombre3; set => _nombre3 = value; }
        public string Telefono1 { get => _telefono1; set => _telefono1 = value; }
        public string Telefono2 { get => _telefono2; set => _telefono2 = value; }
        public string Telefono3 { get => _telefono3; set => _telefono3 = value; }

        public Proveedor()
        {

            puntaje = new PuntajeProveedor();

        }

    }

    public class PuntajeProveedor
    {
        public int transporte_posicion { get; set; }
        public int transporte_Prestigio { get; set; }
        public int transporte_antecedentes { get; set; }
        public int transporte_financiera { get; set; }
        public int transporte_transporte { get; set; }
        public int transporte_capacidad { get; set; }
        public int calidad_plazos { get; set; }
        public int calidad_costo { get; set; }
        public int calidad_cuidado { get; set; }
        public int pago_plazo { get; set; }
        public int pago_descuento { get; set; }
        public int otros_respuesta { get; set; }
        public int otros_administrativa { get; set; }
        public int otros_pedidos { get; set; }


    }
    

}
