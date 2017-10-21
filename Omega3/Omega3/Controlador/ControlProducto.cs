using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Omega3.Modelo;
using System.Data;

namespace Omega3.Controlador
{
    class ControlProducto
    {

        public static int AgregarProducto(Producto producto)
        {

            int retorno = 0;

             

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Productos (producto, cantidad, precio_compra, dolar, stock_minimo, cod_producto, id_categoria) values ('{0}','{1}','{2}', '{3}','{4}','{5}',{6})",
                producto.Nombre_producto, producto.Cantidad, producto.Precio_costo, producto.Dolar, producto.Stock_minimo,producto.Cod_producto,producto.Categoria), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            
            return retorno;
        }

        public static int ModificarProducto(Producto producto)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            
            MySqlCommand comando = new MySqlCommand(string.Format("Update Productos set producto='{0}', cantidad='{1}', precio_compra='{2}', dolar={3}, stock_minimo='{4}', id_categoria={5} where cod_producto={6}",
                producto.Nombre_producto, producto.Cantidad, producto.Precio_costo, producto.Dolar,producto.Stock_minimo, producto.Categoria, producto.Cod_producto), conexion);

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

        public static void llenarTabla(DataGridView cuadro) {
             

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT cod_producto, producto, cantidad, precio_compra, stock_minimo, categoria as Categoria, dolar as Dolar FROM productos INNER JOIN categoria_producto as C on productos.id_categoria = c.id";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;
            }catch(Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de productos: " + ex); }
        }

        public static void validarTextboxVacio(string campo) {
            MessageBox.Show("El campo "+campo+" es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        public static void AutoFill(DataGridView dgv_tabla)
        {
            dgv_tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int i;
            for (i = 0; i <= dgv_tabla.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dgv_tabla.Columns[i].Width;
                //remove autosizing
                dgv_tabla.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dgv_tabla.Columns[i].Width = colw;
            }
            
        }

      public static int modificarDolar(decimal dolar)
        {

            int retorno = 0;
            
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE valor_dolar SET valor={0} WHERE 1",
                dolar), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
            
        }

        public static decimal obtenerValorDolar()
        {
            
            decimal dolar = new decimal();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT valor FROM valor_dolar WHERE 1"), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                dolar = _reader.GetDecimal(0);
            }
       
            

            return dolar;

        }


        public static void llenarCategorias(ComboBox combo)
        {

            string query = "SELECT id, categoria FROM categoria_producto";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "categoria";
            combo.DataSource = dt;

        }

        public static bool validarCodigoExistente(string codigo)
        {
            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT count(cod_producto) FROM productos WHERE cod_producto = {0}", codigo), Conexion.ObtenerConexion());
            string resultado = Convert.ToString(_comando.ExecuteScalar());
            if (resultado == "1")
                return true;
            else
                return false;
        }


    }

 }
