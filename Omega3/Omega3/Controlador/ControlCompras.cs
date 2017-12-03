using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;

namespace Omega3.Controlador
{
    class ControlCompras
    {

        public static int Insertarnuevacompra(ComprasaProveedores compras)
        {

            int retorno = 0;

            string fecha = ControladorFuncVariadas.convertirFecha(compras.Vencimiento);

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into compras (proveedor,motivo,vencimiento,monto,pagada,detalle) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                   compras.Proveedor, compras.Motivo, fecha, compras.Monto, compras.Pagada, compras.Detalle), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Test");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }

            return retorno;


        }

    }
}
