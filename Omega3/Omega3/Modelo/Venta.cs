using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Venta

    {


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