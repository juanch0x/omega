using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Omega3.Modelo;


namespace Omega3.Controlador
{
    class ControlProveedor
    {
        public static int AgregarProveedor(Proveedor proveedor)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Proveedores (nombre, telefono, direccion, provincia, localidad, email) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                proveedor.Nombre_proveedor, proveedor.Telefono, proveedor.Direccion, proveedor.Provincia, proveedor.Localidad, proveedor.Email), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarCliente(Proveedor proveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update Proveedores set nombre='{1}', telefono='{2}', direccion='{3}', provincia='{4}', localidad='{5}', email='{6}' where id_proveedor={0}",
                proveedor.Id_proveedor, proveedor.Nombre_proveedor, proveedor.Telefono, proveedor.Direccion, proveedor.Provincia, proveedor.Localidad, proveedor.Email), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        public static int EliminarProveedor(Proveedor proveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Proveedores where id_proveedor='{0}'",
                proveedor.Id_proveedor), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
}
