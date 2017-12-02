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

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into compras (proveedor,motivo,vencimiento,monto,pagada,detalle) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                   compras.Proveedor, compras.Motivo, compras.Vencimiento, compras.Monto, compras.Pagada, compras.Detalle), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }

            return retorno;


        }

    }
}
