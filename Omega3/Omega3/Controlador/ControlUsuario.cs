using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Omega3.Controlador
{
    class ControlUsuario
    {
        public Boolean login()
        {
            Boolean retorno = false;

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT count(usuario) FROM usuarios  where usuario ='{0}' AND password='{1}'", Usuario.User, Usuario.Password), Conexion.ObtenerConexion());
            string resultado = Convert.ToString(_comando.ExecuteScalar());
            if (resultado == "1")
            {
                MessageBox.Show("Bienvenido " + Usuario.User + " que disfrutes de tu trabajo!");
                retorno = true;
            }
            else
            {
                MessageBox.Show("Usuario invalido, vuelva a intentarlo");
                retorno = false;
            }
            return retorno;

        }
    }
}
