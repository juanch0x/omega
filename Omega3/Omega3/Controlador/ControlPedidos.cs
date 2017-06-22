using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Omega3.Controlador
{
    class ControlPedidos
    {

        public static int AgregarPedido(Pedido pedido)
        {

            int retorno = 0;
            
            string fecha = convertirFecha(pedido.Fecha_pedido);
            MessageBox.Show("FechaData" + fecha);
            pedido.Cantidad = 3;
            pedido.User_pedido = "juanch0x";
            pedido.Realizado = false;

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into Pedidos (id_producto, cantidad, user_pedido, fecha_pedido, realizado, id_proveedor) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                    pedido.Id_producto, pedido.Cantidad, pedido.User_pedido, fecha, pedido.Realizado, pedido.Id_proveedor), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            } catch(Exception ex) { MessageBox.Show("Error en AgregarPedido"+ ex); }

            return retorno;
        }

    public static String convertirFecha(DateTime dt)
        {
            string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return fecha;
        }


        //string sqlSelectAll = "SELECT pedidos.id_pedido AS ID_Pedido, productos.producto AS Producto, proveedores.proveedor AS Proveedor, pedidos.cantidad AS Cantidad_Solicitada, pedidos.user_pedido AS Usuario_Pedido , fecha_pedido AS Fecha_Pedido, user_compra AS Usuario_Compra, fecha_compra AS Fecha_Compra, cantidad_comprada AS Cantidad_Comprada FROM pedidos LEFT JOIN productos ON pedidos.id_producto = productos.cod_producto LEFT JOIN proveedores ON proveedores.id_proveedor = pedidos.id_proveedor";

        public static void llenarTabla(DataGridView cuadro)
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from pedidos";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de pedidos: " + ex); }
        }



    }
}
