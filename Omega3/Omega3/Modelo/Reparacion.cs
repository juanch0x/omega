using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Reparacion
    {

        public long id { get; set; }
        public long documento { get; set; }
        public string problema { get; set; }
        public DateTime fecha_entrada {get;set;}
        public DateTime fecha_salida { get; set; }
        public string id_motor { get; set; }
        public string maquina { get; set; }
        public string comentarios { get; set; }

    }
}
