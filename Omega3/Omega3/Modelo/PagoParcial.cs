using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class PagoParcial
    {
        public long id {get;set;}
        public long id_venta { get; set; }
        public decimal monto { get; set; }
        public int medio_de_pago { get; set; }
        public string comprobante { get; set; }
        public DateTime fecha { get; set; }
        public DateTime vencimiento { get; set; }
        public string razon_social { get; set; }
        public string banco { get; set; }
        

        public PagoParcial()
        {
            monto = new decimal(0);
            comprobante = "";
            fecha = DateTime.Now;
            vencimiento = DateTime.Now;
            razon_social = "";
            banco = "";
            

        }


    }



}
