using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Omega3.Controlador
{
    class ControlVentas
    {

        public static void llenarCondicion(ComboBox combo)
        {
           
                string query = "SELECT id, condicion from condicion_frente_al_iva";

                MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                combo.ValueMember = "id";
                combo.DisplayMember = "condicion";
                combo.DataSource = dt;
                    
        }

        public static void llenarFacturas(ComboBox combo, int id_condicion)
        {

            string query = "SELECT c.id,c.factura FROM factura_x_condicion AS a INNER JOIN condicion_frente_al_iva AS b ON a.id_condicion = b.id INNER JOIN tipo_factura AS c ON a.id_factura = c.id WHERE a.id_condicion = "+id_condicion+"";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "factura";
            combo.DataSource = dt;

        }
        public static void llenarMedios_de_Pago(ComboBox combo)
        {

            string query = "SELECT id, descripcion from medio_de_pago";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "descripcion";
            combo.DataSource = dt;

        }

        public static Cliente obtenerCliente(long documento)
        {
            Cliente cliente = new Cliente();
            cliente.Documento = documento;
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT razon_social, direccion,impositiva,mail_contacto FROM cliente  WHERE documento ={0}", documento), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    cliente.Razon = _reader.GetString(0);
                    cliente.Direccion = _reader.GetString(1);
                    cliente.Impositiva = _reader.GetString(2);
                    cliente.Mail_contacto = _reader.GetString(3);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
            


            return cliente;

        }
        public static Cliente obtenerCliente(string razon)
        {

            Cliente cliente = new Cliente();
            cliente.Razon = razon;
            try
            {
                
                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT documento, direccion,impositiva,mail_contacto FROM cliente WHERE razon_social ='{0}'", razon), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    cliente.Documento = long.Parse(_reader.GetString(0));
                    cliente.Direccion = _reader.GetString(1);
                    cliente.Impositiva = _reader.GetString(2);
                    cliente.Mail_contacto = _reader.GetString(3);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }



            return cliente;
        }


        public static void generarFacturaNegro(DataGridView dgvdetalle) {
            //
            //Hacemos una instancia de la clase EFactura para
            //llenarla con los valores contenidos en los controles del Formulario
            Factura_Negro Cabecera = new Factura_Negro();
            Cabecera.Nombre = "Martín Mestre";
            Cabecera.Documento = "2234755449222";
            Cabecera.Direccion = "Av. Siempre Viva 289381 Perón";
            Cabecera.Fecha = DateTime.Now;
            Cabecera.Total = Convert.ToDecimal("22.2");
            

            //Recorremos los Rows existentes actualmente en el control DataGridView
            //para asignar los datos a las propiedades
            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {

                Detalle_Negro article = new Detalle_Negro();
                //
                //Vamos tomando los valores de las celdas del row que estamos 
                //recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
                //
                article.Cantidad = Convert.ToInt32(row.Cells[0].Value);
                article.Cod = Convert.ToString(row.Cells[1].Value);
                article.Descripcion = Convert.ToString(row.Cells[2].Value);
                article.Precio = Convert.ToDecimal(row.Cells[3].Value);
                article.Lista = Convert.ToInt32(row.Cells[4].Value);
                article.subtotal = Convert.ToDecimal(row.Cells[5].Value);

                //
                //Vamos agregando el Item a la lista del detalle
                //
                Cabecera.Detail.Add(article);
            }

            //
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
             Vista.Venta.Comprobante_Oscuro frm = new Vista.Venta.Comprobante_Oscuro();

            //
            //Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
            //que se mostrara en los parametros creados en el LocalReport, para este ejemplo
            //estamos Seteando los valores directamente pero usted puede usar algun control
            //

            //
            //Recuerde que invoice es una Lista Generica declarada en el FacturaRtp, es una lista
            //porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
            //implementen IEnumerable.
            //
            //Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
            frm.Cabecera.Add(Cabecera);
            //
            //Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
            //es un lista del tipo EArticulo bastara con igualarla
            //
            frm.Detalle = Cabecera.Detail;
            frm.Show();

        }


    }
}
