﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using MySql.Data.MySqlClient;

namespace Omega3.Controlador
{
    class ControlAdministracion
    {

    public static int insertarerogacion (erogaciones erogacion)
        {
            int retorno;
           
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into erogaciones (id_usuario, destino, motivo, monto) values ('{0}','{1}','{2}', '{3}')",
                    erogacion.Id_usuario, erogacion.Destino, erogacion.Motivo, erogacion.Monto), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }
            return 0;
        }

    }
}