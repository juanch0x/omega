using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Omega3.Modelo;

namespace Omega3.Controlador
{
    class ControlCliente
    {
        public static int AgregarCliente(Cliente cliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Clientes (nombre, telefono, direccion, provincia, localidad, email) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                cliente.Nombre_cliente, cliente.Telefono, cliente.Direccion, cliente.Provincia, cliente.Localidad, cliente.Email), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarCliente(Cliente cliente)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update Clientes set nombre='{1}', telefono='{2}', direccion='{3}', provincia='{4}', localidad='{5}', email='{6}' where id_cliente={0}",
                cliente.Id_cliente, cliente.Nombre_cliente, cliente.Telefono, cliente.Direccion, cliente.Provincia, cliente.Localidad, cliente.Email), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        public static int EliminarCliente(Cliente cliente)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Clientes where id_cliente='{0}'",
                cliente.Id_cliente), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
