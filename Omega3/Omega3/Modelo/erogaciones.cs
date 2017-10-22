using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    public class erogaciones
    {

        private String _id_usuario;
        private String _destino;
        private String _motivo;
        private decimal _monto;

        
        public string Destino { get => _destino; set => _destino = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public decimal Monto { get => _monto; set => _monto = value; }
        public string Id_usuario { get => _id_usuario; set => _id_usuario = value; }
    }
}
