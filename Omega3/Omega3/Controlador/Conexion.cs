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
            MySqlConnection conectar = new MySqlConnection("server=192.168.1.41; database=omega; Uid=Omega; pwd=asdqwe123;Convert Zero Datetime=true;");
            try
            {              

                conectar.Open();
                
            }
            catch (MySqlException e) { Console.WriteLine("Error en la base de datos" + e); }

            return conectar;

        }

    }
}
