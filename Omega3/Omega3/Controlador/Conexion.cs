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
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=omega; Uid=root; pwd=;");
            MySqlConnection conectar = new MySqlConnection("server=sql10.freesqldatabase.com; database=sql10176067; Uid=sql10176067; pwd=CYqWFnZbsq;");

            conectar.Open();
            return conectar;
        }

    }
}
