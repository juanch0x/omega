using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    public class Reparacion
    {

        public long id { get; set; }
        public long documento { get; set; }
        public string problema { get; set; }
        public DateTime fecha_entrada {get;set;}
        public DateTime fecha_salida { get; set; }
        public string id_motor { get; set; }
        public string maquina { get; set; }
        public string comentarios { get; set; }
        public decimal lista { get; set; }
        public bool entregado { get; set; }
        public int medio_de_pago { get; set; }
        public DateTime vencimiento { get; set; }
        public string nro_factura { get; set; }
        public string tipo_factura { get; set; }
        public bool cobrada { get; set; }
        public DateTime fecha_cobro { get; set; }
        public long remito { get; set; }
        public string url { get; set; }
        public bool presupuesto { get; set; }
        public string razon_social { get; set; }



    }
}
