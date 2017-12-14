using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using Omega3.Controlador;

namespace Omega3.Controlador
{
    class ControlCompras
    {

        public static int Insertarnuevacompra(ComprasaProveedores compras)
        {

            int retorno = 0;
            int pagada = 0;

            if (compras.Pagada) { pagada = 1; }

            string fecha = ControladorFuncVariadas.convertirFecha(compras.Vencimiento);

            

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into compras (proveedor,motivo,vencimiento,monto,pagada,detalle,comprobante,iva,razon) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}')",
                   compras.Proveedor, compras.Motivo, fecha, compras.Monto, pagada, compras.Detalle,compras.Comprobante, compras.Iva, compras.Razon), Conexion.ObtenerConexion());

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
