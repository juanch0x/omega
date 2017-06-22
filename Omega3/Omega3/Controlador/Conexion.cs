using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omega3.Controlador
{
    class Conexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=omega; Uid=root; pwd=;Convert Zero Datetime=true;");
            try
            {              

                conectar.Open();
                
            }
            catch (MySqlException e) { Console.WriteLine("Error en la base de datos" + e); }

            return conectar;

        }

    }
}
