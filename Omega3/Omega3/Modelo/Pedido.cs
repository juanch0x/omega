using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega3.Modelo
{
    class Pedido
    {

        private long _id_pedido;
        private long _id_producto;
        private long _id_proveedor;
        private int _cantidad;
        private int _cantidad_comprada;
        private string _user_pedido;
        private string _user_compra;
        private DateTime _fecha_pedido;
        private DateTime _fecha_compra;
        private bool _realizado;

        public long Id_pedido { get => _id_pedido; set => _id_pedido = value; }
        public long Id_producto { get => _id_producto; set => _id_producto = value; }
        public long Id_proveedor { get => _id_proveedor; set => _id_proveedor = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Cantidad_comprada { get => _cantidad_comprada; set => _cantidad_comprada = value; }
        public string User_pedido { get => _user_pedido; set => _user_pedido = value; }
        public string User_compra { get => _user_compra; set => _user_compra = value; }
        public DateTime Fecha_pedido { get => _fecha_pedido; set => _fecha_pedido = value; }
        public DateTime Fecha_compra { get => _fecha_compra; set => _fecha_compra = value; }
        public bool Realizado { get => _realizado; set => _realizado = value; }

        public Pedido()
        {
            Id_proveedor = 0;
            Realizado = false;
        }
    
        
    }
}
