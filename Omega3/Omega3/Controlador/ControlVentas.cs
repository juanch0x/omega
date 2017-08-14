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

            Factura_Negro Cabecera = new Factura_Negro();
            Cabecera.Nombre = "Martín Mestre";
            Cabecera.Documento = "2234755449222";
            Cabecera.Direccion = "Av. Siempre Viva 289381 Perón";
            Cabecera.Fecha = DateTime.Now;
            Cabecera.Total = Convert.ToDecimal("0");
            

            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {

                Detalle_Negro article = new Detalle_Negro();
       
                article.Cantidad = Convert.ToInt32(row.Cells[0].Value);
                article.Cod = Convert.ToString(row.Cells[1].Value);
                article.Descripcion = Convert.ToString(row.Cells[2].Value);
                article.Precio = Convert.ToDecimal(row.Cells[3].Value);
                article.Lista = Convert.ToInt32(row.Cells[4].Value);
                article.subtotal = Convert.ToDecimal(row.Cells[5].Value);
                Cabecera.Total += article.subtotal;

        
                Cabecera.Detail.Add(article);
            }

        
             Vista.Venta.Comprobante_Oscuro frm = new Vista.Venta.Comprobante_Oscuro();

         
            frm.Cabecera.Add(Cabecera);
       
            frm.Detalle = Cabecera.Detail;
            frm.Show();

        }


        public static Producto llenarInformacionProducto(string cod) {
            Producto a = new Producto();
            
            try
            {

                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT producto, precio_venta, cantidad FROM productos WHERE cod_producto = {0}", cod), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    
                    a.Precio_venta = decimal.Parse(_reader.GetString(1));
                    a.Nombre_producto = _reader.GetString(0);
                    a.Cantidad = Convert.ToInt32(_reader.GetString(2));
                    MessageBox.Show(a.Nombre_producto);

                }
            }
            catch (Exception e) { Console.WriteLine(e); }


            return a;
           

        }

        public static void AgregarVenta(DataGridView dgv_tabla) {

            Factura_Negro Cabecera = new Factura_Negro();
            Detalle_Negro Detalle = new Detalle_Negro();
            string consulta = "INSERT INTO `detalle_venta`(id_venta, cantidad, codigo, lista, iva) VALUES";
            bool contador = false;

            foreach (DataGridViewRow row in dgv_tabla.Rows)
            {

                if (contador) {
                    consulta += ", ("+0+","+row.Cells[0].Value+","+row.Cells[1].Value+","+1+","+row.Cells[4].Value+")";
                }
                else
                {
                    consulta += "(2,1,0,10,21)";
                    contador = true;
                }

            }

            Console.WriteLine(consulta);

              /*  try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (tipo_documento, documento, razon_social, direccion, telefono, cod_provincia, localidad, cod_postal, contacto, mail_contacto, mail_factura, impositiva) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    cliente.Tipo_documento, cliente.Documento, cliente.Razon, cliente.Direccion, cliente.Telefono, cliente.Cod_provincia, cliente.Localidad, cliente.Codigo_postal, cliente.Contacto, cliente.Mail_contacto, cliente.Mail_factura, cliente.Impositiva), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }

            
        }*/

    }


    }
}
