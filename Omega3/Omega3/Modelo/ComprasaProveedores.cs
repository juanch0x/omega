using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class ComprasaProveedores
    {
        private long _id;
        private string _proveedor;
        private string _motivo;
        private DateTime _vencimiento;
        private decimal _monto;
        private bool _pagada;
        private string _detalle;
        private string _comprobante;
        private decimal _iva;
        private string _razon;
        private DateTime _diaingreso;
        private DateTime _fechapago;
        private decimal _iva10;
        private decimal _nogravado;
        private decimal _percepcioniva;
        private decimal _percepcioniibb;

        public string Proveedor { get => _proveedor; set => _proveedor = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public DateTime Vencimiento { get => _vencimiento; set => _vencimiento = value; }
        public decimal Monto { get => _monto; set => _monto = value; }
        public bool Pagada { get => _pagada; set => _pagada = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }
        public string Comprobante { get => _comprobante; set => _comprobante = value; }
        public string Razon { get => _razon; set => _razon = value; }
        public decimal Iva { get => _iva; set => _iva = value; }
        public long Id { get => _id; set => _id = value; }
        public DateTime Diaingreso { get => _diaingreso; set => _diaingreso = value; }
        public DateTime Fechapago { get => _fechapago; set => _fechapago = value; }
        public decimal Iva10 { get => _iva10; set => _iva10 = value; }
        public decimal Nogravado { get => _nogravado; set => _nogravado = value; }
        public decimal Percepcioniva { get => _percepcioniva; set => _percepcioniva = value; }
        public decimal Percepcioniibb { get => _percepcioniibb; set => _percepcioniibb = value; }
    }
}
