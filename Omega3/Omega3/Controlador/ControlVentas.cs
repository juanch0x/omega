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
        public static void llenarProductosCombo(ComboBox combo)
        {
            string query = "SELECT cod_producto, producto FROM productos";
            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "cod_producto";
            combo.DisplayMember = "producto";
            combo.DataSource = dt;


            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado 
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["producto"]));
            }

            combo.AutoCompleteCustomSource = coleccion;
            combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

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


        public static void generarFacturaNegro(DataGridView dgvdetalle, Factura_Negro Cabecera) {

            
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
                    "SELECT producto, IF(dolar = 1, round(precio_compra * (SELECT valor FROM valor_dolar),2), precio_compra) as precio_venta, cantidad FROM productos WHERE cod_producto = {0}", cod), Conexion.ObtenerConexion());

                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    
                    a.Precio_venta = decimal.Parse(_reader.GetString(1));
                    a.Nombre_producto = _reader.GetString(0);
                    a.Cantidad = Convert.ToInt32(_reader.GetString(2));
                    

                }
            }
            catch (Exception e) { Console.WriteLine(e); }


            return a;
           

        }

        public static void AgregarVenta(DataGridView dgv_tabla,Venta venta) {

            int retorno;

            string fecha_vencimiento = convertirFecha(venta.fecha_vencimiento_cheque);
            string fecha_venta = convertirFecha(venta.fecha_venta);
            //MessageBox.Show(fecha_venta);
             try
          {

              MySqlCommand comando = new MySqlCommand(string.Format("Insert into venta (cliente_documento, medio_de_pago, vencimiento, nro_factura, tipo_factura, fecha_venta) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                  venta.documento,venta.medio_de_pago,fecha_vencimiento,venta.nrofactura,venta.tipo_factura,fecha_venta), Conexion.ObtenerConexion());
              retorno = comando.ExecuteNonQuery();

          }
          catch (Exception e)
          {
              Console.WriteLine("Error" + e);
          }

            
      


            Factura_Negro Cabecera = new Factura_Negro();
            Detalle_Negro Detalle = new Detalle_Negro();
            string consulta = "INSERT INTO `detalle_venta`(id_venta, cantidad, codigo, lista, iva) VALUES";
            string update = "INSERT INTO productos (cod_producto,cantidad) VALUES";
            bool updatebool = false;
            bool contador = false;

            

            foreach (DataGridViewRow row in dgv_tabla.Rows)
            {

                if (contador) {
                    consulta += ", ((select max(id) from venta)," + row.Cells[0].Value+","+row.Cells[1].Value+","+row.Cells[6].Value+","+row.Cells[4].Value+")";
                }
                else
                {
                    consulta += "((select max(id) from venta)," + row.Cells[0].Value+","+row.Cells[1].Value+","+row.Cells[6].Value+","+row.Cells[4].Value+")";
                    contador = true;
                }
                //PARTE DE UPDATE
                if (updatebool)
                {
                    
                    update += ", (" + row.Cells[1].Value + ",(SELECT cantidad as cantidod FROM productos as p WHERE cod_producto = "+ row.Cells[1].Value +")-" + row.Cells[0].Value + ")";

                }
                else
                {
                 
                    update += "(" + row.Cells[1].Value + ",(SELECT cantidad as cantidod FROM productos as p WHERE cod_producto = "+ row.Cells[1].Value +")-" + row.Cells[0].Value + ")";
                    updatebool = true;
                }



            }

            update += " ON DUPLICATE KEY UPDATE cantidad = VALUES(cantidad)";

            Console.WriteLine(update);

            MySqlCommand detalle = new MySqlCommand(consulta,Conexion.ObtenerConexion());
            retorno = detalle.ExecuteNonQuery();

            MySqlCommand restastock = new MySqlCommand(update, Conexion.ObtenerConexion());
            retorno = restastock.ExecuteNonQuery();

            

    }
        public static String convertirFecha(DateTime dt)
        {
            string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return fecha;
        }

        public static int chequearStock(int cod) {

            int stock = 0;
            MySqlCommand _comando = new MySqlCommand(String.Format(
         "SELECT cantidad FROM productos WHERE cod_producto = {0}", cod), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                stock = Convert.ToInt32(_reader.GetString(0));


            }
           // MessageBox.Show(stock.ToString());
            return stock;
        }


    }
}
