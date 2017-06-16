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

    }
}
