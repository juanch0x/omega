﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace Omega3.Controlador
{
    class ControlReparaciones
    {

        public static void llenarTablaClientes(DataGridView cuadro)
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT documento as Documento, razon_social as 'Razon Social' FROM cliente";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Clientes: " + ex); }
        }


        public static void AutoFill(DataGridView dgv_tabla)
        {
            dgv_tabla.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            int i;
            for (i = 0; i <= dgv_tabla.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dgv_tabla.Columns[i].Width;
                //remove autosizing
                dgv_tabla.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dgv_tabla.Columns[i].Width = colw;
            }

        }

        public static int AgregarReparacion(Reparacion a)
        {

            int retorno = 0;

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO reparaciones (documento, problema, fecha_salida, id_motor, maquina, comentarios) VALUES('{0}','{1}','{2}', '{3}','{4}','{5}')",
                               a.documento, a.problema, ControladorFuncVariadas.convertirFecha(a.fecha_salida), a.id_motor, a.maquina, a.comentarios), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }

            return retorno;
        }


        public static void llenarTablaReparaciones(DataGridView cuadro)
        {

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT c.documento, c.razon_social as 'Cliente', problema as 'Problema', fecha_salida as 'Fecha de Salida' , id_motor as 'Num. Motor', maquina as 'Maquina',r.id as ID, markup.lista, markup.valor FROM (reparaciones r LEFT JOIN cliente c ON r.documento = c.documento) LEFT JOIN markup ON c.lista = markup.id WHERE r.entregado = 0";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;

                cuadro.Columns[1].Visible = false;
                cuadro.Columns[9].Visible = false;

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Reparaciones: " + ex); }

        }

        public static void llenarTablaProducto(DataGridView cuadro, Decimal lista)
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT cod_producto as Cod,producto as Producto,ROUND(IF( dolar = 1, precio_compra * (SELECT valor FROM valor_dolar WHERE id = 1), precio_compra)*IF(id_categoria = 1, 1,"+lista+"),2)AS Precio,cantidad AS 'Stock' FROM productos";

            Console.WriteLine(sqlSelectAll);
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;


            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Productos: " + ex); }

        }

        public static void armarTablaRepuestos(DataGridView dgv_tabla)
        {

            // I created these columns at function scope but if you want to access 
            // easily from other parts of your class, just move them to class scope.
            // E.g. Declare them outside of the function...
            var cantidad = new DataGridViewTextBoxColumn();
            var codigo = new DataGridViewTextBoxColumn();
            var descripcion = new DataGridViewTextBoxColumn();
            var precio = new DataGridViewTextBoxColumn();
            var iva = new DataGridViewTextBoxColumn();
            var descuento = new DataGridViewTextBoxColumn();
            var borrar = new DataGridViewImageColumn();
            var nuevoItem = new DataGridViewCheckBoxColumn();
            var subtotal = new DataGridViewTextBoxColumn();

            cantidad.HeaderText = "Cant.";
            cantidad.Name = "Cantidad";
            cantidad.ReadOnly = true;

            codigo.HeaderText = "Código";
            codigo.Name = "Codigo";
            codigo.ReadOnly = true;

            descripcion.HeaderText = "Descripción";
            descripcion.Name = "Descripcion";
            descripcion.ReadOnly = true;

            precio.HeaderText = "Precio Unitario";
            precio.Name = "Precio";
            precio.ReadOnly = true;

            iva.HeaderText = "IVA";
            iva.Name = "iva";
            iva.ReadOnly = true;

            descuento.HeaderText = "Bonif.";
            descuento.Name = "Bonificacion";
            descuento.ReadOnly = true;

            borrar.HeaderText = "Quitar";
            borrar.Name = "Borrar";
            borrar.ReadOnly = true;

            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "Subtotal";
            subtotal.ReadOnly = true;

            nuevoItem.HeaderText = "Nuevo Item";
            nuevoItem.Name = "nuevoitem";
            nuevoItem.Visible = false;
            nuevoItem.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cantidad, codigo, descripcion, precio, iva, descuento, subtotal, borrar,nuevoItem });
        }

        public static void armarTablaReestablecerStock(DataGridView dgv_tabla)
        {
            var cantidad = new DataGridViewTextBoxColumn();
            var codigo = new DataGridViewTextBoxColumn();
            

            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "Cantidad";

            codigo.HeaderText = "Código";
            codigo.Name = "Codigo";
            
            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cantidad, codigo });
            dgv_tabla.AllowUserToAddRows = false;
        }

        public static int actualizarReparacion(Modelo.Reparacion reparacion, DataGridView dgv_tabla,bool nuevasFilas)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            int entregado=0;
            if (reparacion.entregado)
                entregado = 1;


            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Update reparaciones set problema = '{0}', comentarios ='{1}', fecha_salida ='{2}', entregado='{3}' where id={4}",
                    reparacion.problema, reparacion.comentarios, ControladorFuncVariadas.convertirFecha(reparacion.fecha_salida), entregado,reparacion.id), conexion);
                Console.WriteLine(comando.CommandText);
                Console.WriteLine(comando);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();

                

            }

            catch (Exception ex) { MessageBox.Show("Error en el metodo Actualizar Reparacion\n" + ex); }
            insertarDetalleReparacion(dgv_tabla, reparacion.id,nuevasFilas);
            return retorno;

        }

        public static void llenarComentarios(System.Windows.Forms.TextBox comentarios,long id)
        {
            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT comentarios FROM reparaciones WHERE id = {0}", id), Conexion.ObtenerConexion());
            comentarios.Text = Convert.ToString(_comando.ExecuteScalar());
        }


        public static void insertarDetalleReparacion(DataGridView dgv_tabla, long id, bool nuevasFilas)
        {
            string consulta = "INSERT INTO detalle_reparaciones (id_reparacion, cod_producto, precio, cantidad, iva, bonificacion, subtotal) VALUES";
            string update = "INSERT INTO productos (cod_producto,cantidad) VALUES";
            bool updatebool = false;
            bool contador = false;
            bool hayupdatecantidad = false;

            if (nuevasFilas)
            {

                foreach (DataGridViewRow row in dgv_tabla.Rows)
                    if (Convert.ToInt32(row.Cells["nuevoitem"].Value) == 1)
                    {
                        {

                            if (contador)
                            {
                                consulta += ", (" + id + ",'" + row.Cells["Codigo"].Value + "'," + row.Cells["Precio"].Value + "," + row.Cells["Cantidad"].Value + "," + row.Cells["iva"].Value + "," + row.Cells["Bonificacion"].Value + "," + row.Cells["Subtotal"].Value + ")";
                            }
                            else
                            {
                                consulta += "(" + id + ",'" + row.Cells["Codigo"].Value + "'," + row.Cells["Precio"].Value + "," + row.Cells["Cantidad"].Value + "," + row.Cells["iva"].Value + "," + row.Cells["Bonificacion"].Value + "," + row.Cells["Subtotal"].Value + ")";
                                contador = true;
                            }
                            
                            if (updatebool)
                            {
                                if (Convert.ToString(row.Cells["Codigo"].Value) != "R")
                                {
                                    update += ", (" + row.Cells["Codigo"].Value + ",(SELECT cantidad FROM productos as p WHERE cod_producto = " + row.Cells["Codigo"].Value + ")-" + row.Cells["Cantidad"].Value + ")";
                                    
                                }
                            }
                            else
                            {
                                if (Convert.ToString(row.Cells["Codigo"].Value) != "R")
                                {
                                    update += "(" + row.Cells["Codigo"].Value + ",(SELECT cantidad FROM productos as p WHERE cod_producto = " + row.Cells["Codigo"].Value + ")-" + row.Cells["Cantidad"].Value + ")";
                                    updatebool = true;
                                    hayupdatecantidad = true;
                                }
                            }

                        }
                    }

                update += " ON DUPLICATE KEY UPDATE cantidad = VALUES(cantidad)";

                Console.WriteLine(consulta);
                int retorno = 0;
                MySqlCommand detalle = new MySqlCommand(consulta, Conexion.ObtenerConexion());
                retorno = detalle.ExecuteNonQuery();
                if (hayupdatecantidad)
                {
                    MySqlCommand restastock = new MySqlCommand(update, Conexion.ObtenerConexion());
                    retorno = restastock.ExecuteNonQuery();
                }
            }
        }

        public static void sumarStockEliminadoDeDetalle(DataGridView dgv_tabla, long id_reparacion)
        {
            string delete = "DELETE FROM detalle_reparaciones WHERE ";
            string update = "INSERT INTO productos (cod_producto,cantidad) VALUES";
            bool updatebool = false;
            bool contador = false;
            bool hayupdatecantidad = false;

            if (dgv_tabla.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dgv_tabla.Rows)

                {
                    {

                        if (contador)
                        {
                            delete += " OR cod_producto = '" + row.Cells["Codigo"].Value + "' AND id_reparacion = "+id_reparacion;
                        }
                        else
                        {
                            delete += "cod_producto = '" + row.Cells["Codigo"].Value + "' AND id_reparacion = "+id_reparacion;
                            contador = true;
                        }

                        if (updatebool)
                        {
                            if (Convert.ToString(row.Cells["Codigo"].Value) != "R")
                            {
                                update += ", (" + row.Cells["Codigo"].Value + ",(SELECT cantidad FROM productos as p WHERE cod_producto = " + row.Cells["Codigo"].Value + ")+" + row.Cells["Cantidad"].Value + ")";
                                
                            }
                        }
                        else
                        {
                            if (Convert.ToString(row.Cells["Codigo"].Value) != "R")
                            {
                                update += "(" + row.Cells["Codigo"].Value + ",(SELECT cantidad FROM productos as p WHERE cod_producto = " + row.Cells["Codigo"].Value + ")+" + row.Cells["Cantidad"].Value + ")";
                                updatebool = true;
                                hayupdatecantidad = true;

                            }
                        }

                    }
                }

                update += " ON DUPLICATE KEY UPDATE cantidad = VALUES(cantidad)";

                
                int retorno = 0;
                MySqlCommand detalle = new MySqlCommand(delete, Conexion.ObtenerConexion());
                retorno = detalle.ExecuteNonQuery();
                 if (hayupdatecantidad)
                 {
                     MySqlCommand restastock = new MySqlCommand(update, Conexion.ObtenerConexion());
                    Console.WriteLine(delete);
                    retorno = restastock.ExecuteNonQuery();
                 }
            }
            }
        
        

        public static void llenarTablaArticulosReparacion(DataGridView dgv_tabla, long id_reparacion)
        {
            int cantidad;
            string descripcion;
            string cod_producto;
            double precio = new double();
            double iva = new double();
            double bonificacion = new double();
            double subtotal = new double();

            //  dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cantidad, codigo, descripcion, precio, iva, descuento, subtotal, borrar });
            MySqlCommand _comando = new MySqlCommand(String.Format(
                 "SELECT d.cantidad, d.cod_producto, d.precio, d.iva, d.bonificacion, d.subtotal, IF(d.cod_producto = 'R','Mano de Obra',p.producto) FROM detalle_reparaciones d LEFT JOIN productos p on d.cod_producto = p.cod_producto WHERE id_reparacion ={0}", id_reparacion), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cantidad = _reader.GetInt32(0);
                cod_producto = _reader.GetString(1);
                precio = _reader.GetDouble(2);
                iva = _reader.GetDouble(3);
                bonificacion = _reader.GetDouble(4);
                subtotal = _reader.GetDouble(5);
                descripcion = _reader.GetString(6);
                dgv_tabla.Rows.Add(cantidad, cod_producto, descripcion, precio, iva, bonificacion, subtotal, null,false);
            }

        }


        public static int FinalizarReparacion(long id_reparacion, Reparacion informacion, int tipo = 0)
        {
            int retorno = 0;

            int cobrada;

            string consulta = string.Empty;
            string fecha_vencimiento = ControladorFuncVariadas.convertirFecha(informacion.vencimiento);
            if (informacion.cobrada) { cobrada = 1; } else { cobrada = 0; }

            MySqlConnection conexion;
                try { 
           conexion = Conexion.ObtenerConexion();

                if (informacion.cobrada)
                {
                    consulta = string.Format("Update reparaciones set entregado='{0}', fecha_pago = CURRENT_DATE,	medio_de_pago = '{1}',	vencimiento = '{2}', tipo_factura = '{3}', usuario = '{4}',	cobrada = '{5}',fecha_cobro = CURRENT_DATE, tipo = {7}, remito = {8}, ordencompra = '{9}' where id={6}", 1, informacion.medio_de_pago, informacion.vencimiento, informacion.tipo_factura, Usuario.User, cobrada, id_reparacion,tipo, informacion.remito,informacion.ordenDeCompra);
                }
                else
                {
                    consulta = string.Format("Update reparaciones set entregado='{0}', fecha_pago = CURRENT_DATE,	medio_de_pago = '{1}',	vencimiento = '{2}', tipo_factura = '{3}', usuario = '{4}',	cobrada = '{5}', tipo = {7}, remito = {8}, ordencompra = '{9}' where id={6}", 1, informacion.medio_de_pago, fecha_vencimiento, informacion.tipo_factura, Usuario.User, cobrada, id_reparacion,tipo,informacion.remito,informacion.ordenDeCompra);
                }

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

                if (informacion.medio_de_pago == 1 || informacion.medio_de_pago == 3 || informacion.medio_de_pago == 4)
                {
                    
                    ControladorPagoParcial.agregarPagoReparacionEfectivo(id_reparacion, informacion.medio_de_pago, informacion.documento);
                }

            }catch (MySqlException a) { Console.WriteLine(a); }
            return retorno;
            
        }

        



        public int ActualizarFacturaYUrl(string id_comprobante, long id)
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





            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Update reparaciones set nro_factura='{0}', URL='{1}' where id={2}",
                    numfactura, info[0], id), conexion);
                MessageBox.Show("La factura creada ya fue aceptada, y está disponible para su descarga en la sección de ventas realizadas");
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
                MessageBox.Show("Hubo un error creando el comprobante, porfavor cheuqueelo en Facturante");
            }
            return retorno;


        }
        

        public static void construirTablaReparacionesRealizadas(DataGridView dgv_tabla)
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
            var informacion = new DataGridViewImageColumn();
            var maquina = new DataGridViewTextBoxColumn();
            var problema = new DataGridViewTextBoxColumn();
            var documento = new DataGridViewTextBoxColumn();


            razon.HeaderText = "Razon Social";
            razon.DataPropertyName = "Razon Social";
            razon.Name = "Razon Social";
            razon.ReadOnly = true;
            razon.Width = 200;

            maquina.HeaderText = "Máquina";
            maquina.DataPropertyName = "Maquina";
            maquina.ReadOnly = true;

           // problema.HeaderText = "Problema";
            //problema.DataPropertyName = "Problema";
            //problema.ReadOnly = true;

            nrofactura.HeaderText = "Nro Factura";
            nrofactura.Name = "Nro Factura";
            nrofactura.ReadOnly = true;
            nrofactura.DataPropertyName = "Nro Factura";


            tipo.HeaderText = "Tipo";
            tipo.Name = "Tipo";
            tipo.DataPropertyName = "Tipo";
            tipo.ReadOnly = true;
            

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

            informacion.Name = "Informacion";
            informacion.HeaderText = "Info";
            informacion.DataPropertyName = "Informacion";
            informacion.ReadOnly = true;

            documento.Name = "Documento";
            documento.HeaderText = "Documento";
            documento.DataPropertyName = "Documento";
            documento.ReadOnly = true;
            documento.Visible = false;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { id,razon,maquina, tipo,nrofactura, remito, total, fecha, fecha_vto, fecha_cobro, vendedor, cobrada, link, informacion,url, documento });


            dgv_tabla.AutoGenerateColumns = false;

            llenar_reparaciones_realizadas(dgv_tabla);


        }

        public static void llenar_reparaciones_realizadas(DataGridView dgv_tabla)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            //string sqlSelectAll = "SELECT v.id as Id, c.razon_social as 'Razon Social', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, v.fecha_venta as Fecha,v.fecha_cobro as 'Fecha de Cobro',v.vencimiento as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link FROM venta v INNER JOIN cliente c on c.documento = v.cliente_documento INNER JOIN detalle_venta d on v.id = d.id_venta GROUP BY v.id";
            string sqlSelectAll = "SELECT v.id as Id, left (c.razon_social,20) as 'Razon Social', v.maquina as 'Maquina', v.problema as 'Problema', v.nro_factura as 'Nro Factura', v.tipo_factura as Tipo, v.remito as Remito, sum(d.subtotal) as Total, date(v.fecha_pago) as Fecha, date(v.fecha_cobro) as 'Fecha de Cobro', date(v.vencimiento) as Vencimiento, v.cobrada as Cobrada, v.usuario as Vendedor, v.URL as Link, v.documento as Documento FROM reparaciones v INNER JOIN cliente c on c.documento = v.documento LEFT JOIN detalle_reparaciones d on v.id = d.id_reparacion WHERE entregado=1 GROUP BY v.id";

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
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de reparaciones: " + ex); }
        }


        public static Modelo.Reparacion obtenerReparacion(long id)
        {

            Modelo.Reparacion a = new Reparacion();

            string query = string.Empty;
            query = "SELECT r.problema, r.fecha_salida, r.id_motor, r.maquina, r.comentarios, c.razon_social FROM reparaciones r INNER JOIN cliente c on r.documento = c.documento WHERE r.id = " + id;
            Console.WriteLine(query);
            try
            {
                               

                MySqlCommand _comando = new MySqlCommand(query, Conexion.ObtenerConexion());

                MySqlDataReader _reader = _comando.ExecuteReader();
                _reader.Read();
                a.id = id;
                a.problema = _reader.GetString(0);
                a.fecha_salida = _reader.GetDateTime(1);
                a.id_motor = _reader.GetString(2);
                a.maquina = _reader.GetString(3);
                a.comentarios = _reader.GetString(4);
                a.razon_social = _reader.GetString(5);
                
            }
            catch (MySqlException ex) { MessageBox.Show("Hubo un error cargando la reparación, contacte al administrador. "+ex);}

                return a;
            
        }



        public static int ModificarReparacionCobro(Modelo.Reparacion reparacion)
        {

            int retorno = 0;
            int aux;
            MySqlConnection conexion;


            try
            {
                conexion = Conexion.ObtenerConexion();

                if (reparacion.cobrada) { aux = 1; } else { aux = 0; }



                string consulta = string.Format("Update reparaciones set nro_factura='{0}', cobrada='{1}', remito='{2}', fecha_cobro = CURRENT_DATE where id={3}",
                    reparacion.nro_factura, aux, reparacion.remito, reparacion.id);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                Console.WriteLine(consulta);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (MySqlException a) { Console.WriteLine(a); }
            return retorno;

        }

        public static void armarExcelReparacionesRealizadas(DataGridView dgv_tabla)
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



                ws.Cells[1, 1] = "Reparaciones Realizadas";
                ws.Range[ws.Cells[1, 1], ws.Cells[3, 11]].Merge();
                cabecera = ws.get_Range("a1", "k3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;


                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;


                
                ws.Cells[4, 1] = "Razón Social";
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range razon = ws.get_Range("a4", "a4");
                razon.BorderAround2();
                razon.Interior.Color = Color.White;

                ws.Cells[4, 2] = "Máquina";
                ws.Cells[4, 2].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                ws.Cells[4, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 2].Font.Bold = true;

                Range maquina = ws.get_Range("b4", "b4");
                maquina.BorderAround2();
                maquina.Interior.Color = Color.White;


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
                int columnas = 11;

                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == 0)
                        {
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells["Razon Social"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);

                            //ws.Cells[fila, 1].Color = Color.White;

                        }

                        else if(j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla.Rows[i].Cells[2].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);
                        }

                        else if (j == 2)
                        {
                            ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells["Nro Factura"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                            //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                        }

                        else if (j == 3)
                        {

                            ws.Cells[fila, 4] = dgv_tabla.Rows[i].Cells["Tipo"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                            // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                        }

                        else if (j == 4)
                        {

                            ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells["Remito"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
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

                        else if (j == 7)
                        {
                            ws.Cells[fila, 8] = dgv_tabla.Rows[i].Cells["Vencimiento"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 8].Borders);
                        }

                        else if (j == 8)
                        {
                            ws.Cells[fila, 9] = dgv_tabla.Rows[i].Cells["Fecha de Cobro"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 9].Borders);
                        }

                        else if (j == 9)
                        {
                            ws.Cells[fila, 10] = dgv_tabla.Rows[i].Cells["Vendedor"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 10].Borders);
                        }
                        else if (j == 10)
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


    }
}


    
