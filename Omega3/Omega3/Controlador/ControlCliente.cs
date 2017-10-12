using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Omega3.Modelo;
using System.Data;


namespace Omega3.Controlador
{
    class ControlCliente
    {
        public static string obtenerProvinia(int id)
        {
            string aux = null;


            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT provincia_nombre FROM provincia  WHERE id ={0}", id), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                aux = _reader.GetString(0);
            }

             return aux;

        }

        public static void llenarProvincias(ComboBox combo)
        {

            string query = "SELECT id, provincia_nombre FROM provincia";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "provincia_nombre";
            combo.DataSource = dt;

        }
        public static void llenarTipoDocumento(ComboBox combo)
        {

            string query = "SELECT id, descripcion FROM tipo_documento";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "descripcion";
            combo.DataSource = dt;

        }

        public static int AgregarCliente(Cliente cliente)
        {
            
            Console.WriteLine(cliente.Razon + cliente.Documento);


            int retorno = 0;
            
            try {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (tipo_documento, documento, razon_social, direccion, telefono, cod_provincia, localidad, cod_postal, contacto, mail_contacto, mail_factura, impositiva) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    cliente.Tipo_documento, cliente.Documento, cliente.Razon, cliente.Direccion, cliente.Telefono, cliente.Cod_provincia, cliente.Localidad, cliente.Codigo_postal, cliente.Contacto, cliente.Mail_contacto, cliente.Mail_factura, cliente.Impositiva), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch ( Exception e)
            {
                Console.WriteLine("Error" +e);
            }

            return retorno;
        }

        public static string obtenerTipodocumento(int id)
        {
            string aux = null;


            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT descripcion FROM tipo_documento  WHERE id ={0}", id), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                aux = _reader.GetString(0);
            }

            MessageBox.Show(aux);

            ComprobantesClient client = new ComprobantesClient();

        
            return aux;

        }

        public static Boolean validardocumento(long documento)
        {
            Boolean retorno = false;

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT count(documento) FROM cliente  where documento ='{0}'", documento), Conexion.ObtenerConexion());
            string resultado = Convert.ToString(_comando.ExecuteScalar());
            if (resultado == "1")
            {
                retorno = true;
            }
            else
            {
                
                retorno = false;
            }
            return retorno;
        }

        public static Cliente obtenerCliente(long documento)
        {

            Cliente cliente = new Cliente();


            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT tipo_documento, razon_social, direccion, telefono, provincia_nombre, localidad, cod_postal, contacto, mail_contacto, mail_factura, impositiva FROM cliente INNER JOIN provincia ON cliente.cod_provincia = provincia.id WHERE documento = {0}", documento), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cliente.Tipo_documento = _reader.GetInt32(0);
                cliente.Razon = _reader.GetString(1);
                cliente.Direccion = _reader.GetString(2);
                cliente.Telefono = long.Parse(_reader.GetString(3));
                cliente.Provincia = _reader.GetString(4);
                cliente.Localidad = _reader.GetString(5);
                cliente.Codigo_postal = _reader.GetInt32(6);
                cliente.Contacto = _reader.GetString(7);
                cliente.Mail_contacto = _reader.GetString(8);
                cliente.Mail_factura = _reader.GetString(9);
                cliente.Impositiva = _reader.GetString(10);
            }


            return cliente;
        }


    }
}
