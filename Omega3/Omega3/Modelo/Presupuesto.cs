using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Presupuesto
    {



    }
   
        public class EArticulo
        {
            public int Numero { get; set; }
            public string Cod { get; set; }
            public string Descripcion { get; set; }
            public decimal Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Importe { get; set; }
        }
    

        public class EFactura
        {
            public string Resumen { get; set; }
            public string Telefono { get; set; }
            public string Atencion { get; set; }
            public int Numero { get; set; }
            public string Nombre { get; set; }
            public string Documento { get; set; }
            public string Direccion { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Iva { get; set; }
            public decimal Total { get; set; }
            public DateTime FechaFacturacion { get; set; }

            //Creamos una lista con una nueva Instancia de la clase Articulo
            //esta lista contendra el detalle de la factura
            public List<EArticulo> Detail = new List<EArticulo>();
        
    }
}
