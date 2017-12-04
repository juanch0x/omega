using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
using System.Data.SqlClient;

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

                DataTable table = new DataTable();
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

                DataTable table = new DataTable();
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
            string sqlSelectAll = "SELECT cod_producto as Cod, producto as Producto, ROUND(IF( dolar = 1, precio_compra * (SELECT valor FROM valor_dolar WHERE id = 1), precio_compra)*" + lista + ",2) AS Precio, cantidad AS 'Stock' FROM productos";

            Console.WriteLine(sqlSelectAll);
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
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
        public static void llenarComentarios(TextBox comentarios,long id)
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

        public static void sumarStockEliminadoDeDetalle(DataGridView dgv_tabla)
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
                            delete += " OR cod_producto = '" + row.Cells["Codigo"].Value + "'";
                        }
                        else
                        {
                            delete += "cod_producto = '" + row.Cells["Codigo"].Value + "'";
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


        public static int FinalizarReparacion(long id_reparacion, Reparacion informacion)
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
                    consulta = string.Format("Update reparaciones set entregado='{0}', fecha_pago = CURRENT_DATE,	medio_de_pago = '{1}',	vencimiento = '{2}', tipo_factura = '{3}', usuario = '{4}',	cobrada = '{5}',fecha_cobro = CURRENT_DATE where id={6}", 1, informacion.medio_de_pago, informacion.vencimiento, informacion.tipo_factura, Usuario.User, cobrada, id_reparacion);
                }
                else
                {
                    consulta = string.Format("Update reparaciones set entregado='{0}', fecha_pago = CURRENT_DATE,	medio_de_pago = '{1}',	vencimiento = '{2}', tipo_factura = '{3}', usuario = '{4}',	cobrada = '{5}' where id={6}", 1, informacion.medio_de_pago, fecha_vencimiento, informacion.tipo_factura, Usuario.User, cobrada, id_reparacion);
                }

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            Console.WriteLine(consulta);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
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
            /*
                        try
                        {
                            MySqlCommand comando = new MySqlCommand(string.Format("Update venta set nro_factura='{0}', URL='{1}' where id={2}",
                                numfactura, info[0], id), conexion);
                            MessageBox.Show("La factura creada ya fue aceptada, y está disponible para su descarga en la sección de ventas realizadas");
                            retorno = comando.ExecuteNonQuery();
                            conexion.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error " + ex.ToString());
                            MessageBox.Show("Hubo un error creando el comprobante, porfavor cheuqueelo en Facturante");
                        }*/


            MessageBox.Show("Fatura " + numfactura + "URL" + info[0]);

            return retorno;


        }


    }
}


    
