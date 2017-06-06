using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Producto
    {

        private long _cod_producto;
        private string _nombre_producto;
        private int _cantidad;
        private decimal _precio_costo;
        private decimal _precio_venta;
        private int _stock_minimo;

        public long Cod_producto { get => _cod_producto; set => _cod_producto = value; }
        public string Nombre_producto { get => _nombre_producto; set => _nombre_producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal Precio_costo { get => _precio_costo; set => _precio_costo = value; }
        public decimal Precio_venta { get => _precio_venta; set => _precio_venta = value; }
        public int Stock_minimo { get => _stock_minimo; set => _stock_minimo = value; }
    }
}
