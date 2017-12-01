using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class ComprasaProveedores
    {
        private String _proveedor;
        private String _motivo;
        private DateTime _vencimiento;
        private Decimal _monto;
        private Boolean _pagada;
        private String _detalle;

        public string Proveedor { get => _proveedor; set => _proveedor = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public DateTime Vencimiento { get => _vencimiento; set => _vencimiento = value; }
        public decimal Monto { get => _monto; set => _monto = value; }
        public bool Pagada { get => _pagada; set => _pagada = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }
    }
}
