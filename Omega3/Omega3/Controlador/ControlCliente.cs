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

            MessageBox.Show(aux);


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

        public static int AgregarCliente(Omega3.Modelo.Cliente cliente)
        {
            Console.WriteLine("ME EJECUTO");
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


    }
}
