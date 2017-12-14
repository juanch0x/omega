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

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (tipo_documento, documento, razon_social, direccion, telefono, cod_provincia, localidad, cod_postal, contacto, mail_contacto, mail_factura, impositiva, lista,nombre1,nombre2,nombre3,email1,email2,email3,telefono1,telefono2,telefono3,flete,demora,maximo_credito) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}',{24})",
                    cliente.Tipo_documento, cliente.Documento, cliente.Razon, cliente.Direccion, cliente.Telefono, cliente.Cod_provincia, cliente.Localidad, cliente.Codigo_postal, cliente.Contacto, cliente.Mail_contacto, cliente.Mail_factura, cliente.Impositiva,cliente.Lista,cliente.Nombre1,cliente.Nombre2,cliente.Nombre3,cliente.Email1,cliente.Email2,cliente.Email3,cliente.Telefono1,cliente.Telefono2,cliente.Telefono3,cliente.Flete,cliente.Plazo,cliente.Maximo_credito), Conexion.ObtenerConexion());
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

            cliente.Documento = documento;

            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT tipo_documento, razon_social, direccion, telefono, provincia_nombre, localidad, cod_postal, contacto, mail_contacto, mail_factura, impositiva,lista FROM cliente INNER JOIN provincia ON cliente.cod_provincia = provincia.id WHERE documento = {0}", documento), Conexion.ObtenerConexion());
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
                cliente.Impositiva_Id = _reader.GetInt32(10);
                cliente.Lista = _reader.GetInt32(11);

            }


            return cliente;
        }

        public static void llenarListas(ComboBox combo)
        {
                string query = "SELECT id, lista FROM markup";

                MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                combo.ValueMember = "id";
                combo.DisplayMember = "lista";
                combo.DataSource = dt;

            
        }

        public static int ModificarCliente(Cliente cliente)
        {

            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string consulta = string.Format("Update cliente set razon_social='{0}', direccion='{1}', telefono='{2}', cod_provincia={3}, localidad='{4}', cod_postal='{5}', contacto='{6}', mail_contacto='{7}',lista={8},impositiva={9},flete='{10}',demora='{11}',maximo_credito={12},nombre1='{13}',nombre2='{14}',nombre3='{15}',telefono1='{16}',telefono2='{17}',telefono3='{18}',email1='{19}',email2='{20}',email3='{21}' where documento={22}",
                cliente.Razon, cliente.Direccion, cliente.Telefono, cliente.Cod_provincia, cliente.Localidad, cliente.Codigo_postal, cliente.Contacto, cliente.Mail_contacto, cliente.Lista, cliente.Impositiva_Id, cliente.Flete, cliente.Plazo, cliente.Maximo_credito, cliente.Nombre1, cliente.Nombre2, cliente.Nombre3, cliente.Telefono1, cliente.Telefono2, cliente.Telefono3, cliente.Email1, cliente.Email2, cliente.Email3, cliente.Documento);
            try
            {

                /*MySqlCommand comando = new MySqlCommand(string.Format("Update cliente set razon_social='{0}', direccion='{1}', telefono='{2}', cod_provincia={3}, localidad='{4}', cod_postal={5}, contacto={6}, mail_contacto={7},lista={8},impositiva={9} where documento={10}",
                cliente.Razon, cliente.Direccion, cliente.Telefono, cliente.Cod_provincia, cliente.Localidad, cliente.Codigo_postal, cliente.Contacto, cliente.Mail_contacto, cliente.Lista, cliente.Impositiva_Id, cliente.Documento), conexion);
                */
                MySqlCommand comando = new MySqlCommand(consulta,conexion);
                Console.WriteLine(consulta);
                retorno = comando.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error" + e);
            }

            return retorno;
        }

        public static void ListarClientes(DataGridView dgv_tabla)
        {

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT documento as Documento, razon_social as 'Razon Social',direccion as Direccion, telefono as Telefono, contacto as Contacto, markup.lista as Lista  FROM cliente INNER JOIN markup on cliente.lista = markup.id";
            try
           {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Clientes: " + ex); }




        }

    }
}
