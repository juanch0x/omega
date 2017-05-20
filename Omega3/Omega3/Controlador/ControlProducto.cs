using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Omega3.Modelo;

namespace Omega3.Controlador
{
    class ControlProducto
    {

        public static int AgregarProducto(Producto producto)
        {

            int retorno = 0;


            producto.Precio_costo = 199.5m;
            Console.WriteLine(producto.Precio_costo);

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Productos (producto, cantidad, precio_compra, precio_venta) values ('{0}','{1}','{2}', '{3}')",
                producto.gsProducto, producto.Cantidad, producto.Precio_costo, producto.Precio_venta), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
