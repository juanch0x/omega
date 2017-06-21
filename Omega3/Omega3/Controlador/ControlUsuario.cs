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



            //  List<Cliente> _lista = new List<Cliente>();
          //  Usuario validar = new Usuario();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM usuarios  where usuario ='{0}' AND password='{1}'", Usuario.User, Usuario.Password), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    //Usuario validar = new Usuario();
                    Usuario.User = _reader.GetString(0);
                    Usuario.Password = _reader.GetString(1);
                    Usuario.Id_rol = _reader.GetInt32(2);
                  
                    
                }

          MessageBox.Show(Usuario.User);


            return false;

        }
    }
}
