using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    public class Venta

    {

        public long documento { get; set; }
        public int medio_de_pago { get; set; }
        public DateTime fecha_vencimiento_cheque { get; set; }
        public string nrofactura { get; set; }
        public string tipo_factura { get; set; }
        public DateTime fecha_venta { get; set; }
        public long id { get; set; }
        public long remito { get; set; }
        public string ordendeCompra { get; set; }
        public bool cobrada { get; set; }
}

    public class Detalle_Facturante
    {
        public decimal Bonificacion;
        public int cantidad;
        public string codigo;
        public string detalle;
        public bool gravado;
        public decimal iva;
        public decimal precio_unitario;
        public decimal total;
        public int elemento;
    }

    public class Detalle_Negro
    {
        public int Numero { get; set; }
        public string Cod { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Lista { get; set; }
        public decimal subtotal { get; set; }
        
    }


    public class Factura_Negro
    {
        public string Resumen { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public List<Detalle_Negro> Detail = new List<Detalle_Negro>();



    }

}