using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Producto
    {

        private long cod_producto;
        private string producto;
        private int cantidad;
        private decimal precio_costo;
        private decimal precio_venta;

        public long Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string gsProducto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio_costo { get => precio_costo; set => precio_costo = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
    }
}
