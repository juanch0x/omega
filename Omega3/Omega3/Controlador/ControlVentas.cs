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
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace Omega3.Controlador
{
    class ControlVentas
    {

        public static void llenarCondicion(ComboBox combo)
        {

            string query = "SELECT id, condicion from condicion_frente_al_iva";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "condicion";
            combo.DataSource = dt;

        }

        public static void llenarFacturas(ComboBox combo, int id_condicion)
        {

            string query = "SELECT c.id,c.factura FROM factura_x_condicion AS a INNER JOIN condicion_frente_al_iva AS b ON a.id_condicion = b.id INNER JOIN tipo_factura AS c ON a.id_factura = c.id WHERE a.id_condicion = " + id_condicion + "";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "factura";
            combo.DataSource = dt;

        }
        public static void llenarMedios_de_Pago(ComboBox combo)
        {

            string query = "SELECT id, descripcion from medio_de_pago WHERE id<>6";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
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
            System.Data.DataTable dt = new System.Data.DataTable();
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

            // combo.AutoCompleteCustomSource = coleccion;
            //combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            //combo.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        public static Cliente obtenerCliente(long documento)
        {
            Cliente cliente = new Cliente();
            cliente.Documento = documento;
            try
            {

                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT razon_social, direccion,condicion,mail_contacto,markup.valor,cliente.impositiva FROM (cliente INNER JOIN condicion_frente_al_iva ON cliente.impositiva = condicion_frente_al_iva.id) INNER JOIN markup ON cliente.lista = markup.id WHERE documento = '{0}'", cliente.Documento), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    cliente.Razon = _reader.GetString(0);
                    cliente.Direccion = _reader.GetString(1);
                    cliente.Impositiva = _reader.GetString(2);
                    cliente.Mail_contacto = _reader.GetString(3);
                    cliente.Lista = _reader.GetDecimal(4);
                    cliente.Impositiva_Id = _reader.GetInt32(5);
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
                    "SELECT documento, direccion,condicion,mail_contacto,markup.valor,cliente.impositiva FROM (cliente INNER JOIN condicion_frente_al_iva ON cliente.impositiva = condicion_frente_al_iva.id) INNER JOIN markup ON cliente.lista = markup.id WHERE razon_social = '{0}'", razon), Conexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    cliente.Documento = long.Parse(_reader.GetString(0));
                    cliente.Direccion = _reader.GetString(1);
                    cliente.Impositiva = _reader.GetString(2);
                    cliente.Mail_contacto = _reader.GetString(3);
                    cliente.Lista = _reader.GetDecimal(4);
                    cliente.Impositiva_Id = _reader.GetInt32(5);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }



            return cliente;
        }


        public static void generarFacturaNegro(DataGridView dgvdetalle, Factura_Negro Cabecera)
        {


            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {

                Detalle_Negro article = new Detalle_Negro();

                article.Cantidad = Convert.ToInt32(row.Cells[0].Value);
                article.Cod = Convert.ToString(row.Cells[1].Value);
                article.Descripcion = Convert.ToString(row.Cells[2].Value);
                //article.Precio = ((Convert.ToDecimal(row.Cells[5].Value)) / (Convert.ToInt32(row.Cells[4].Value) / 100 + 1)) / Convert.ToInt32(row.Cells[0].Value);
                article.Precio = ((Convert.ToDecimal(row.Cells[5].Value)) / Convert.ToInt32(row.Cells[0].Value));
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


        public static Producto llenarInformacionProducto(string cod)
        {
            Producto a = new Producto();

            try
            {

                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT producto, IF(dolar = 1, round(precio_compra * (SELECT valor FROM valor_dolar),2), precio_compra) as precio_venta, cantidad, id_categoria FROM productos WHERE cod_producto = {0}", cod), Conexion.ObtenerConexion());

                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    a.Precio_venta = decimal.Parse(_reader.GetString(1));
                    a.Nombre_producto = _reader.GetString(0);
                    a.Cantidad = Convert.ToInt32(_reader.GetString(2));
                    a.Categoria = Convert.ToInt32(_reader.GetInt32(3));


                }
            }
            catch (Exception e) { Console.WriteLine(e); }


            return a;


        }

        public static long AgregarVenta(DataGridView dgv_tabla, Venta venta, int tipo = 0)
        {

            int retorno;
            long lastinserted = 0;
            string fecha_vencimiento = convertirFecha(venta.fecha_vencimiento_cheque);
            string fecha_venta = convertirFecha(venta.fecha_venta);
            //MessageBox.Show(fecha_venta);
            string insertarventa;
            if (venta.medio_de_pago == 1 || venta.medio_de_pago == 3 || venta.medio_de_pago == 4)
            {
                insertarventa = string.Format("Insert into venta (cliente_documento, medio_de_pago, vencimiento, nro_factura, tipo_factura, fecha_venta,usuario,cobrada,fecha_cobro,tipo,remito,ordencompra) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','1',CURRENT_DATE,{7},{8},'{9}')",
                  venta.documento, venta.medio_de_pago, fecha_vencimiento, venta.nrofactura, venta.tipo_factura, fecha_venta, Usuario.User,tipo,venta.remito,venta.ordendeCompra);
            }
            else
            {
                insertarventa = string.Format("Insert into venta (cliente_documento, medio_de_pago, vencimiento, nro_factura, tipo_factura, fecha_venta,usuario,tipo,remito,ordencompra) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}',{7},{8},'{9}')",
                  venta.documento, venta.medio_de_pago, fecha_vencimiento, venta.nrofactura, venta.tipo_factura, fecha_venta, Usuario.User,tipo,venta.remito,venta.ordendeCompra);
            }



            try
            {

                MySqlCommand comando = new MySqlCommand(insertarventa, Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                lastinserted = comando.LastInsertedId;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }





            Factura_Negro Cabecera = new Factura_Negro();
            Detalle_Negro Detalle = new Detalle_Negro();
            string consulta = "INSERT INTO `detalle_venta`(id_venta, cantidad, codigo, descuento, iva, subtotal) VALUES";
            string update = "INSERT INTO productos (cod_producto,cantidad) VALUES";
            bool updatebool = false;
            bool contador = false;



            foreach (DataGridViewRow row in dgv_tabla.Rows)
            {

                if (contador)
                {
                    consulta += ", ((select max(id) from venta)," + row.Cells[0].Value + "," + row.Cells[1].Value + "," + row.Cells[6].Value + "," + row.Cells[4].Value + "," + row.Cells[5].Value + ")";
                }
                else
                {
                    consulta += "((select max(id) from venta)," + row.Cells[0].Value + "," + row.Cells[1].Value + "," + row.Cells[6].Value + "," + row.Cells[4].Value + "," + row.Cells[5].Value + ")";
                    contador = true;
                }
                //PARTE DE UPDATE
                if (updatebool)
                {

                    update += ", (" + row.Cells[1].Value + ",(SELECT cantidad as cantidod FROM productos as p WHERE cod_producto = " + row.Cells[1].Value + ")-" + row.Cells[0].Value + ")";

                }
                else
                {

                    update += "(" + row.Cells[1].Value + ",(SELECT cantidad as cantidod FROM productos as p WHERE cod_producto = " + row.Cells[1].Value + ")-" + row.Cells[0].Value + ")";
                    updatebool = true;
                }



            }

            update += " ON DUPLICATE KEY UPDATE cantidad = VALUES(cantidad)";

            Console.WriteLine(update);

            MySqlCommand detalle = new MySqlCommand(consulta, Conexion.ObtenerConexion());
            retorno = detalle.ExecuteNonQuery();

            if (tipo != 1)
            {
                MySqlCommand restastock = new MySqlCommand(update, Conexion.ObtenerConexion());
                retorno = restastock.ExecuteNonQuery();
            }


            //ACKHASHDASDASHDAKDJA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA 
            if (tipo != 1)
            {
                if (venta.medio_de_pago == 1 || venta.medio_de_pago == 3 || venta.medio_de_pago == 4)
                {
                    ControladorPagoParcial.agregarPagoVentaEfectivo(dgv_tabla, lastinserted, venta.medio_de_pago);
                }
            }

            return lastinserted;

            
        }
        public static String convertirFecha(DateTime dt)
        {
            string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return fecha;
        }

        public static int chequearStock(long cod)
        {

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


        public static void llenarComboComprobante(ComboBox combo, int impositiva)
        {

            string query = "SELECT factura, tipo_facturante FROM tipo_factura INNER JOIN factura_x_condicion ON tipo_factura.tipo_facturante = factura_x_condicion.id_factura WHERE factura_x_condicion.id_condicion = " + impositiva;

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da1.Fill(dt);

            combo.ValueMember = "tipo_facturante";
            combo.DisplayMember = "factura";
            combo.DataSource = dt;

        }


        public static void llenar_ventas_realizadas(DataGridView dgv_tabla)
        
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            //string sqlSelectAll = "SELECT v.id as Id, left (c.razon_social,15) as 'Razon Social', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, v.fecha_venta as Fecha,v.fecha_cobro as 'Fecha de Cobro',v.vencimiento as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta GROUP BY v.id";
            //  string sqlSelectAll = "SELECT v.id as Id, left (c.razon_social,15) as 'Razon Social', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, date(v.fecha_venta) as Fecha, date(v.fecha_cobro) as 'Fecha de Cobro',date(v.vencimiento) as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta WHERE tipo <> 1 GROUP BY v.id";
            string sqlSelectAll = "SELECT v.id as Id, c.razon_social as 'Razon Social', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, date(v.fecha_venta) as Fecha, date(v.fecha_cobro) as 'Fecha de Cobro',date(v.vencimiento) as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta WHERE tipo <> 1 GROUP BY v.id";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                 dgv_tabla.DataSource = bSource;

                // dgv_tabla.Columns["id"].Visible = false;
                
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de ventas: " + ex); }
            
        }
    

        public static void construirTablaVentasRealizadas(DataGridView dgv_tabla)
        {

             var id = new DataGridViewTextBoxColumn();
             var razon = new DataGridViewTextBoxColumn();
             var nrofactura = new DataGridViewTextBoxColumn();
             var tipo = new DataGridViewTextBoxColumn();
             var remito = new DataGridViewTextBoxColumn();
             var total = new DataGridViewTextBoxColumn();
             var fecha = new DataGridViewTextBoxColumn();
             var link = new DataGridViewTextBoxColumn();
             var url = new DataGridViewImageColumn();
             var cobrada = new DataGridViewCheckBoxColumn();
             var fecha_cobro = new DataGridViewTextBoxColumn();
             var fecha_vto = new DataGridViewTextBoxColumn();
             var vendedor = new DataGridViewTextBoxColumn();


             razon.HeaderText = "Razon Social";
            razon.DataPropertyName = "Razon Social";
            razon.Name = "Razon Social";
             razon.ReadOnly = true;
            razon.Width = 200;
             

             nrofactura.HeaderText = "Nro Factura";
             nrofactura.Name = "Nro Factura";
             nrofactura.ReadOnly = true;
             nrofactura.DataPropertyName = "Nro Factura";
            

             tipo.HeaderText = "Tipo";
             tipo.Name = "Tipo";
             tipo.DataPropertyName = "Tipo";
             tipo.ReadOnly = true;
//             tipo.Width = 45;

            remito.HeaderText = "Remito";
             remito.Name = "Remito";
             remito.DataPropertyName = "Remito";
             remito.ReadOnly = true;

             total.HeaderText = "Total";
             total.Name = "Total";
            total.DataPropertyName = "Total";
             total.ReadOnly = true;

             fecha.HeaderText = "Fecha";
             fecha.Name = "Fecha";
            fecha.DataPropertyName = "Fecha";
             fecha.ReadOnly = true;

             link.HeaderText = "Link";
             link.Name = "Link";
             link.DataPropertyName = "Link";
             link.ReadOnly = true;
            link.Visible = false;

             fecha_cobro.HeaderText = "Fecha de Cobro";
             fecha_cobro.Name = "Fecha de Cobro";
            fecha_cobro.DataPropertyName = "Fecha de Cobro";
             fecha_cobro.ReadOnly = true;

             cobrada.HeaderText = "Cobrada";
             cobrada.Name = "Cobrada";
            cobrada.DataPropertyName = "Cobrada";
             //cobrada.Visible = false;
             cobrada.ReadOnly = true;

             fecha_vto.HeaderText = "Vencimiento";
             fecha_vto.Name = "Vencimiento";
            fecha_vto.DataPropertyName = "Vencimiento";
             fecha_vto.ReadOnly = true;

             vendedor.HeaderText = "Vendedor";
             vendedor.Name = "Vendedor";
            vendedor.DataPropertyName = "Vendedor";
             vendedor.ReadOnly = true;

             id.HeaderText = "Id";
             id.Name = "Id";
            id.DataPropertyName = "Id";
             id.ReadOnly = true;
             id.Visible = false;

            url.Name = "URL";
            url.HeaderText = "URL";
            url.DataPropertyName = "URL";
            url.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] {id, razon, nrofactura, tipo, remito, total, fecha, fecha_vto, fecha_cobro, vendedor, cobrada, link,url });


            dgv_tabla.AutoGenerateColumns = false;

            llenar_ventas_realizadas(dgv_tabla);
            

        }



        public static decimal Total_Vendido_Hoy()
        {
            
            decimal resultado = new decimal();
            resultado = 0;

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "select sum(subtotal) from venta inner join detalle_venta on venta.id=detalle_venta.id_venta where venta.fecha_cobro = CURRENT_DATE"), Conexion.ObtenerConexion());

            if (Convert.ToString(_comando.ExecuteScalar()).Trim() != "")
            {
                resultado = Convert.ToDecimal(_comando.ExecuteScalar());
            }

            return resultado;
       
        }

        public static decimal  Total_Reparado_Hoy()
        {
            string aux;
            decimal resultado = new decimal();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT sum(detalle_reparaciones.subtotal) from reparaciones INNER JOIN detalle_reparaciones on reparaciones.id=detalle_reparaciones.id_reparacion WHERE reparaciones.fecha_pago=CURRENT_DATE"), Conexion.ObtenerConexion());

            aux = Convert.ToString(_comando.ExecuteScalar());
            if (aux.Trim() != "")
                resultado = Convert.ToDecimal(aux);
            else
                resultado = 0;
            

            return resultado;

        }


        public static decimal Total_Erogaciones_hoy()
        {
            decimal resultado = new decimal();
            resultado = 0;
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "select sum(erogaciones.monto) from erogaciones where erogaciones.fecha=CURRENT_DATE"), Conexion.ObtenerConexion());

            if (Convert.ToString(_comando.ExecuteScalar()).Trim() != "")
            {
                resultado = Convert.ToDecimal(_comando.ExecuteScalar());
            }

            return resultado;
        }


        public static int ModificarVenta(Modelo.Venta venta)
        {

            int retorno = 0;
            int aux;
            MySqlConnection conexion;


try { 
                conexion = Conexion.ObtenerConexion();

            if (venta.cobrada) { aux = 1; }else { aux = 0; }

       

            string consulta = string.Format("Update venta set nro_factura='{0}', cobrada='{1}', remito='{2}', fecha_cobro = CURRENT_DATE where id={3}",
                venta.nrofactura, aux, venta.remito, venta.id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            Console.WriteLine(consulta);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            }catch (MySqlException a) { Console.WriteLine(a); }
            return retorno;

        }


        ////**************************************************////
        ////ESTA ES LA FUNCióN QUE SE USA EN UN HILO SECUNDARIO///
        ////*****PARA ACTUALIZAR EL NRO FACTURA Y LA URL******////
        ////**************************************************////

        public int ActualizarFacturaYUrl(string id_comprobante,long id)
        {

            ControlVenta control = new ControlVenta();
            MySqlConnection conexion = Conexion.ObtenerConexion();

            System.Threading.Thread.Sleep(30000);

            string[] info;

            info = control.obtenerDatosComprobanteVenta(id_comprobante);

            string numfactura = info[1] + "-";

            for (int i = 0; i < 8 - info[2].Length; i++)
            {
                numfactura += "0";
            }

            numfactura += info[2];

              



            int retorno=0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Update venta set nro_factura='{0}', URL='{1}' where id={2}",
                    numfactura, info[0], id), conexion);
                MessageBox.Show("La factura creada ya fue aceptada, y está disponible para su descarga en la sección de ventas realizadas");
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex) { MessageBox.Show("Error "+ex.ToString());
                MessageBox.Show("Hubo un error creando el comprobante, porfavor cheuqueelo en Facturante");
            }
            return retorno;


        }


        public static void construirTablaPresupuestos(DataGridView dgv_tabla)
        {

            var id = new DataGridViewTextBoxColumn();
            var razon = new DataGridViewTextBoxColumn();
            var total = new DataGridViewTextBoxColumn();
            var fecha = new DataGridViewTextBoxColumn();
            var url = new DataGridViewImageColumn();
            var vendedor = new DataGridViewTextBoxColumn();


            razon.HeaderText = "Razon Social";
            razon.DataPropertyName = "Razon Social";
            razon.Name = "Razon Social";
            razon.ReadOnly = true;
            razon.Width = 200;
                      

            total.HeaderText = "Total";
            total.Name = "Total";
            total.DataPropertyName = "Total";
            total.ReadOnly = true;

            fecha.HeaderText = "Fecha";
            fecha.Name = "Fecha";
            fecha.DataPropertyName = "Fecha";
            fecha.ReadOnly = true;
                       

            vendedor.HeaderText = "Vendedor";
            vendedor.Name = "Vendedor";
            vendedor.DataPropertyName = "Vendedor";
            vendedor.ReadOnly = true;

            id.HeaderText = "Nº Presupuesto";
            id.Name = "Id";
            id.DataPropertyName = "Id";
            id.ReadOnly = true;
            

            url.Name = "URL";
            url.HeaderText = "Ver";
            url.DataPropertyName = "URL";
            url.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { id, razon, total, fecha, vendedor, url });


            dgv_tabla.AutoGenerateColumns = false;

            llenar_presupuestos(dgv_tabla);


        }


        public static void llenar_presupuestos(DataGridView dgv_tabla)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            //string sqlSelectAll = "SELECT v.id as Id, c.razon_social as 'Razon Social', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, v.fecha_venta as Fecha,v.fecha_cobro as 'Fecha de Cobro',v.vencimiento as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta GROUP BY v.id";
            string sqlSelectAll = "SELECT v.id as Id, c.razon_social as 'Razon Social', sum(d.subtotal) as Total, date(v.fecha_venta) as Fecha, v.usuario as Vendedor FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta WHERE tipo = 1 GROUP BY v.id";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;

                // dgv_tabla.Columns["id"].Visible = false;

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de ventas: " + ex); }

        }


        public static int obtenerCategoria (long cod_producto)
        {
            int id_categoria = 0;
            MySqlCommand insere = new MySqlCommand();

            using (MySqlConnection MyConn = new MySqlConnection(Conexion.connectionString))
            {
                MyConn.Open();
                insere.Connection = MyConn;
                insere.CommandText = "SELECT id_categoria FROM productos where cod_producto = @cod";
                insere.Parameters.AddWithValue("@cod", cod_producto);
                using (MySqlDataReader _reader = insere.ExecuteReader())
                {
                    while (_reader.Read())
                    {

                        id_categoria = _reader.GetInt32(0);

                    }
                    _reader.Close();
                }
                MyConn.Close();
            }



            return id_categoria;

            
            

            


        }


        public static void armarExcelVentasRealizadas(DataGridView dgv_tabla)
        {
            ControladorFuncVariadas control = new ControladorFuncVariadas();
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Interactive = false;


            try
            {


                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                
                Excel.WindowState = XlWindowState.xlMaximized;
                Microsoft.Office.Interop.Excel.Range cabecera = null;

                
               
               ws.Cells[1, 1] = "Ventas Realizadas";
               ws.Range[ws.Cells[1, 1], ws.Cells[3, 11]].Merge();
               cabecera = ws.get_Range("a1", "k3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;


                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;


                ws.Range[ws.Cells[4, 1], ws.Cells[4, 2]].Merge();
                ws.Cells[4, 1] = "Razón Social";
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range razon = ws.get_Range("a4", "b4");
                razon.BorderAround2();
                razon.Interior.Color = Color.White;
                //razon.Columns.AutoFit();

                                
                ws.Cells[4, 3] = "Nro Factura";
                ws.Cells[4, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range nrofactura = ws.get_Range("c4", "c4");
                nrofactura.BorderAround2();
                nrofactura.Interior.Color = Color.White;

                ws.Cells[4, 4] = "Tipo";
                ws.Cells[4, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 4].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 4].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range tipo = ws.get_Range("d4", "d4");
                tipo.BorderAround2();
                tipo.Interior.Color = Color.White;


                ws.Cells[4, 5] = "Remito";
                ws.Cells[4, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range remito = ws.get_Range("e4", "e4");
                remito.BorderAround2();
                remito.Interior.Color = Color.White;


                ws.Cells[4, 6] = "Total";
                ws.Cells[4, 6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 6].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 6].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range total = ws.get_Range("f4", "f4");
                total.BorderAround2();
                total.Interior.Color = Color.White;

                ws.Cells[4, 7] = "Fecha";
                ws.Cells[4, 7].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 7].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 7].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range fecha = ws.get_Range("g4", "g4");
                fecha.BorderAround2();
                fecha.Interior.Color = Color.White;

                ws.Cells[4, 8] = "Vencimiento";
                ws.Cells[4, 8].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 8].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 8].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range vencimiento = ws.get_Range("h4", "h4");
                vencimiento.BorderAround2();
                vencimiento.Interior.Color = Color.White;


                ws.Cells[4, 9] = "Fecha Cobro";
                ws.Cells[4, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 9].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 9].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range fecha_cobro = ws.get_Range("i4", "i4");
                fecha_cobro.BorderAround2();
                fecha_cobro.Interior.Color = Color.White;


                ws.Cells[4, 10] = "Vendedor";
                ws.Cells[4, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 10].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 10].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range vendedor = ws.get_Range("j4", "j4");
                vendedor.BorderAround2();
                vendedor.Interior.Color = Color.White;


                ws.Cells[4, 11] = "Cobrada";
                ws.Cells[4, 11].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 11].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 11].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range cobrada = ws.get_Range("k4", "k4");
                cobrada.BorderAround2();
                cobrada.Interior.Color = Color.White;



                //********************
                //Empiezo por cantidad
                //********************

                    int fila = 5;
                    int columnas = 10;
                    
                    for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {

                            if (j == 0)
                            {
                                ws.Range[ws.Cells[fila, 1], ws.Cells[fila, 2]].Merge();
                                ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells["Razon Social"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Range[ws.Cells[fila, 1], ws.Cells[fila, 2]].Borders);
                                
                                //ws.Cells[fila, 1].Color = Color.White;

                            }
                            
                            else if (j == 1)
                            {
                                ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells["Nro Factura"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                                //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                            }
                            
                            else if (j == 2)
                            {

                                ws.Cells[fila, 4] = dgv_tabla.Rows[i].Cells["Tipo"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                                // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                            }
                            
                            else if (j == 3)
                            {

                                ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells["Remito"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                                //ws.Cells[fila, 7].Color = Color.White;
                            }
                            
                            else if (j == 4)
                            {
                                ws.Cells[fila, 6] = dgv_tabla.Rows[i].Cells["Total"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Cells[fila, 6].Borders);
                            }
                            else if (j == 5)
                            {
                                ws.Cells[fila, 7] = dgv_tabla.Rows[i].Cells["Fecha"].Value;
                                ControladorFuncVariadas.AllBorders(ws.Cells[fila, 7].Borders);
                            }

                        else if (j == 6)
                        {
                            ws.Cells[fila, 8] = dgv_tabla.Rows[i].Cells["Vencimiento"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 8].Borders);
                        }

                        else if (j == 7)
                        {
                            ws.Cells[fila, 9] = dgv_tabla.Rows[i].Cells["Fecha de Cobro"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 9].Borders);
                        }

                        else if (j == 8)
                        {
                            ws.Cells[fila, 10] = dgv_tabla.Rows[i].Cells["Vendedor"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 10].Borders);
                        }
                        else if (j == 9)
                        {
                            if (dgv_tabla.Rows[i].Cells["Cobrada"].Value.ToString() == "True")
                                ws.Cells[fila, 11] = "Sí";
                            else
                                ws.Cells[fila, 11] = "No";
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 11].Borders);
                        }

                    }


                        fila++;
                    }
                    ws.Columns[2].NumberFormat = "######";

                    ws.Columns[6].NumberFormat = "$ #.###,00";
                ws.Columns.AutoFit();


                Excel.Interactive = true;
                Excel.Visible = true;
                 
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }

        }

        public static void llenarVentasPorCategoria(DataGridView dgv_tabla, string query)
        {
            string sqlSelectAll = query;
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;




            }
            catch (MySqlException ex) { MessageBox.Show("Hubo un problema " + ex.ToString()); }
            {

            }
        }

        public static void armarExcelProductosVendidos(DataGridView dgv_tabla)
        {
            ControladorFuncVariadas control = new ControladorFuncVariadas();
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Interactive = false;


            try
            {


                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;

                Excel.WindowState = XlWindowState.xlMaximized;
                Microsoft.Office.Interop.Excel.Range cabecera = null;



                ws.Cells[1, 1] = "Productos Vendidos";
                ws.Range[ws.Cells[1, 1], ws.Cells[3, 7]].Merge();
                cabecera = ws.get_Range("a1", "g3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;


                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;


                ws.Cells[4, 1] = "Producto";
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range producto = ws.get_Range("a4", "a4");
                producto.BorderAround2();
                producto.Interior.Color = Color.White;
                

                ws.Cells[4, 2] = "Código";
                ws.Cells[4, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 2].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range codigo = ws.get_Range("b4", "b4");
                codigo.BorderAround2();
                codigo.Interior.Color = Color.White;

                ws.Cells[4, 3] = "Cantidad";
                ws.Cells[4, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range cantidad = ws.get_Range("c4", "c4");
                cantidad.BorderAround2();
                cantidad.Interior.Color = Color.White;


                ws.Cells[4, 4] = "Precio de Compra";
                ws.Cells[4, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 4].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 4].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range precio_compra = ws.get_Range("d4", "d4");
                precio_compra.BorderAround2();
                precio_compra.Interior.Color = Color.White;


                ws.Cells[4, 5] = "Precio de Venta";
                ws.Cells[4, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range precio_venta = ws.get_Range("e4", "e4");
                precio_venta.BorderAround2();
                precio_venta.Interior.Color = Color.White;

                ws.Cells[4, 6] = "Total";
                ws.Cells[4, 6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 6].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 6].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range total = ws.get_Range("f4", "f4");
                total.BorderAround2();
                total.Interior.Color = Color.White;

                ws.Cells[4, 7] = "Fecha";
                ws.Cells[4, 7].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 7].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 7].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range fecha = ws.get_Range("g4", "g4");
                fecha.BorderAround2();
                fecha.Interior.Color = Color.White;

               

                               

                int fila = 5;
                int columnas = 7;

                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == 0)
                        {
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells["Producto"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);
                                                        

                        }

                        else if (j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla.Rows[i].Cells["Codigo"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);
                            
                        }

                        else if (j == 2)
                        {

                            ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells["Cantidad"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                            

                        }

                        else if (j == 3)
                        {

                            ws.Cells[fila, 4] = dgv_tabla.Rows[i].Cells["Precio Compra"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
                        }

                        else if (j == 4)
                        {
                            ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells["Precio Venta"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                        }
                        else if (j == 5)
                        {
                            ws.Cells[fila, 6] = dgv_tabla.Rows[i].Cells["Total"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 6].Borders);
                        }

                        else if (j == 6)
                        {
                            ws.Cells[fila, 7] = dgv_tabla.Rows[i].Cells["Fecha"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 7].Borders);
                        }

                        
                    }


                    fila++;
                }
                ws.Columns[2].NumberFormat = "######";

                ws.Columns[4].NumberFormat = "$ #.###,00";
                ws.Columns[5].NumberFormat = "$ #.###,00";
                ws.Columns[6].NumberFormat = "$ #.###,00";
                ws.Columns.AutoFit();


                Excel.Interactive = true;
                Excel.Visible = true;

            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }

        }


        public static void armarExcelVentasPorCategoria(DataGridView dgv_tabla)
        {
            ControladorFuncVariadas control = new ControladorFuncVariadas();
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Interactive = false;


            try
            {


                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;

                Excel.WindowState = XlWindowState.xlMaximized;
                Microsoft.Office.Interop.Excel.Range cabecera = null;



                ws.Cells[1, 1] = "Ventas por Categoría";
                ws.Range[ws.Cells[1, 1], ws.Cells[3, 3]].Merge();
                cabecera = ws.get_Range("a1", "c3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;


                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;


                ws.Cells[4, 1] = "Categoría";
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range categoria = ws.get_Range("a4", "a4");
                categoria.BorderAround2();
                categoria.Interior.Color = Color.White;


                ws.Cells[4, 2] = "Precio de Compra";
                ws.Cells[4, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 2].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range precio_compra = ws.get_Range("b4", "b4");
                precio_compra.BorderAround2();
                precio_compra.Interior.Color = Color.White;

                ws.Cells[4, 3] = "Precio de Venta";
                ws.Cells[4, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range precio_venta = ws.get_Range("c4", "c4");
                precio_venta.BorderAround2();
                precio_venta.Interior.Color = Color.White;


               

                int fila = 5;
                int columnas = 3;

                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == 0)
                        {
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells["Categoria"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);


                        }

                        else if (j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla.Rows[i].Cells["Precio Compra"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);

                        }

                        else if (j == 2)
                        {

                            ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells["Precio Venta"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);


                        }

                     
                    }


                    fila++;
                }
                

                ws.Columns[2].NumberFormat = "$ #.###,00";
                ws.Columns[3].NumberFormat = "$ #.###,00";
                
                ws.Columns.AutoFit();


                Excel.Interactive = true;
                Excel.Visible = true;

            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }

        }




    }


    }




    

