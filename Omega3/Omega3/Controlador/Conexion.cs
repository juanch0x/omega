﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Omega3.Controlador
{
    class Conexion
    {
        //static MySqlConnection conectar = new MySqlConnection("server=192.168.1.106; database=omega; Uid=omega1; pwd=omega1;Convert Zero Datetime=true;");

        public static string connectionString = "server=localhost; database=omega; Uid=root; pwd=;Convert Zero Datetime=true;";

        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection(connectionString);
            //MySqlConnection conectar = new MySqlConnection("server=omegaredtest.zapto.org; database=omega; Uid=OmegaRed; pwd=asdqwe123;Convert Zero Datetime=true;");

            try
            {              

                conectar.Open();
                
            }
            catch (MySqlException e) { Console.WriteLine("Error en la base de datos" + e); }

            return conectar;

        }
        

    }
}
