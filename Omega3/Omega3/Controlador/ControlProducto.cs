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
                producto.Nombre_producto, producto.Cantidad, producto.Precio_costo, producto.Precio_venta), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarProducto(Producto producto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update Productos set producto='{0}', cantidad='{1}', precio_compra='{2}', precio_venta='{3}' where cod_producto={4}",
                producto.Nombre_producto, producto.Cantidad, producto.Precio_costo, producto.Precio_venta, producto.Cod_producto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        public static int EliminarProducto (Producto producto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Productos where Cod_producto='{0}'",
                producto.Cod_producto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

    }
}
