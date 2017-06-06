﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Omega3.Modelo;

namespace Omega3.Controlador
{
    class ControlProducto
    {

        public static int AgregarProducto(Producto producto)
        {

            int retorno = 0;


            //producto.Precio_costo = 199.5m;
            

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Productos (producto, cantidad, precio_compra, precio_venta, stock_minimo, cod_producto) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                producto.Nombre_producto, producto.Cantidad, producto.Precio_costo, producto.Precio_venta, producto.Stock_minimo,producto.Cod_producto), Conexion.ObtenerConexion());
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

        public static void autoCompletarProducto(ComboBox combo_producto) {

            try
            {
             
                
                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT producto FROM productos"), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
             
                    combo_producto.AutoCompleteCustomSource.Add(_reader["producto"].ToString());
                    Console.WriteLine(_reader["producto"].ToString());
                    combo_producto.Items.Add(_reader["producto"].ToString());

                }
                _reader.Close();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error funcion autoCompletarProducto" + ex.ToString());
            }
        }

        public static string obtenerCodigoPorNombre(string producto) {
            string auxiliar = null;
            try
            {


                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT cod_producto FROM productos WHERE producto='{0}'",producto), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    auxiliar = _reader["cod_producto"].ToString();

                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error funcion obtenerCodigoPorNombre" + ex.ToString());
            }

            return auxiliar;
        }

    }
}
