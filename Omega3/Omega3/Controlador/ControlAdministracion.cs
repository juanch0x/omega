using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using Microsoft.Office.Interop.Excel;

namespace Omega3.Controlador
{
    class ControlAdministracion
    {

    public static int insertarerogacion (erogaciones erogacion)
        {
            int retorno;
           
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into erogaciones (id_usuario, destino, motivo, monto,tipo,fecha) values ('{0}','{1}','{2}', '{3}', '{4}',CURRENT_DATE)",
                    erogacion.Id_usuario, erogacion.Destino, erogacion.Motivo, erogacion.Monto, erogacion.Tipogasto), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }
            return 0;
        }
//
        public static void construirTablaPagos(DataGridView dgv_tabla,string query)
        {

            var titulo = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
    
            

            titulo.HeaderText = "Titulo";
            titulo.Name = "Titulo";
            titulo.DataPropertyName = "Titulo";
            titulo.ReadOnly = true;
            

            monto.Name = "Monto";
            monto.HeaderText = "Monto";
            monto.DataPropertyName = "Monto";
            monto.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { titulo,monto });


            dgv_tabla.AutoGenerateColumns = false;

            llenarPagos(dgv_tabla,query);


        }
        public static void llenarPagos(DataGridView dgv_tabla,string query) {
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
            catch (MySqlException ex) { MessageBox.Show("Hubo un problema "+ex.ToString());}
            {

            }
         }



        public static void armarExcelListaCompras(DataGridView dgv_tabla)
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



                ws.Cells[1, 1] = "Lista Compras";
                ws.Range[ws.Cells[1, 1], ws.Cells[3, 11]].Merge();
                cabecera = ws.get_Range("a1", "k3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;


                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;


                ws.Cells[4, 1] = "Proveedor";
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range proveedor = ws.get_Range("a4", "a4");
                proveedor.BorderAround2();
                proveedor.Interior.Color = Color.White;
                

                ws.Cells[4, 2] = "Motivo";
                ws.Cells[4, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 2].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range motivo = ws.get_Range("b4", "b4");
                motivo.BorderAround2();
                motivo.Interior.Color = Color.White;

                ws.Cells[4, 3] = "Vencimiento";
                ws.Cells[4, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range vencimiento = ws.get_Range("c4", "c4");
                vencimiento.BorderAround2();
                vencimiento.Interior.Color = Color.White;

                ws.Cells[4, 4] = "Monto";
                ws.Cells[4, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 4].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 4].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range monto = ws.get_Range("d4", "d4");
                monto.BorderAround2();
                monto.Interior.Color = Color.White;


                ws.Cells[4, 5] = "Fecha de Ingreso";
                ws.Cells[4, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range pagada = ws.get_Range("e4", "e4");
                pagada.BorderAround2();
                pagada.Interior.Color = Color.White;


                ws.Cells[4, 6] = "Detalle";
                ws.Cells[4, 6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 6].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 6].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range detalle = ws.get_Range("f4", "f4");
                detalle.BorderAround2();
                detalle.Interior.Color = Color.White;

                ws.Cells[4, 7] = "Razón Social";
                ws.Cells[4, 7].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 7].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 7].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range razon = ws.get_Range("g4", "g4");
                razon.BorderAround2();
                razon.Interior.Color = Color.White;

                ws.Cells[4, 8] = "IVA";
                ws.Cells[4, 8].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 8].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 8].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range iva = ws.get_Range("h4", "h4");
                iva.BorderAround2();
                iva.Interior.Color = Color.White;


                ws.Cells[4, 9] = "Fecha de Pago";
                ws.Cells[4, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 9].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 9].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range fecha_pago = ws.get_Range("i4", "i4");
                fecha_pago.BorderAround2();
                fecha_pago.Interior.Color = Color.White;


                ws.Cells[4, 10] = "Comprobante";
                ws.Cells[4, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 10].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 10].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range comprobante = ws.get_Range("j4", "j4");
                comprobante.BorderAround2();
                comprobante.Interior.Color = Color.White;


                ws.Cells[4, 11] = "Pagada";
                ws.Cells[4, 11].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 11].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 11].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range fecha_ingreso = ws.get_Range("k4", "k4");
                fecha_ingreso.BorderAround2();
                fecha_ingreso.Interior.Color = Color.White;



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
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells["Proveedor"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);
                        }

                        if (j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla.Rows[i].Cells["Motivo"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);
                        }

                        else if (j == 2)
                        {
                            ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells["Vencimiento"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                            //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                        }

                        else if (j == 3)
                        {

                            ws.Cells[fila, 4] = dgv_tabla.Rows[i].Cells["Monto"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                            // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                        }

                        else if (j == 10)
                        {

                            ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells["Fecha Ingreso"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
                        }

                        else if (j == 5)
                        {
                            ws.Cells[fila, 6] = dgv_tabla.Rows[i].Cells["Detalle"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 6].Borders);
                        }
                        else if (j == 6)
                        {
                            ws.Cells[fila, 7] = dgv_tabla.Rows[i].Cells["Razon Social"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 7].Borders);
                        }

                        else if (j == 7)
                        {
                            ws.Cells[fila, 8] = dgv_tabla.Rows[i].Cells["Iva"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 8].Borders);
                        }

                        else if (j == 8)
                        {
                            if(ControladorFuncVariadas.validarDateTimeVacio(Convert.ToDateTime(dgv_tabla.Rows[i].Cells["Fecha Pago"].Value.ToString())))
                                ws.Cells[fila, 9] = dgv_tabla.Rows[i].Cells["Fecha Pago"].Value;
                            else
                                ws.Cells[fila, 9] = "Pendiente";
                            
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 9].Borders);
                        }

                        else if (j == 9)
                        {
                            ws.Cells[fila, 10] = dgv_tabla.Rows[i].Cells["Comprobante"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 10].Borders);
                        }
                        else if (j == 4)
                        {
                            if (dgv_tabla.Rows[i].Cells["Pagada"].Value.ToString() == "True")
                                ws.Cells[fila, 11] = "Sí";
                            else
                                ws.Cells[fila, 11] = "No";
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 11].Borders);
                        }

                    }


                    fila++;
                }
                //ws.Columns[2].NumberFormat = "######";

                ws.Columns[4].NumberFormat = "$ #.###,00";
                ws.Columns[6].NumberFormat = "$ #.###,00";
                ws.Columns[8].NumberFormat = "$ #.###,00";
                ws.Columns[3].NumberFormat = "dd/MM/yyyy";
                ws.Columns[5].NumberFormat = "dd/MM/yyyy";
                ws.Columns[9].NumberFormat = "dd/MM/yyyy";
                ws.Columns.AutoFit();


                Excel.Interactive = true;
                Excel.Visible = true;

            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }

        }


        public static Deuda obtenerDeudas(long documento)
        {

            Deuda deuda = null;


            string query = string.Empty;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                query = "SELECT * FROM venta";

                Factura_Negro Cabecera = new Factura_Negro();
                Cabecera.Total = 0;
                using (var MyConn = new MySqlConnection(Conexion.connectionString))
                {
                    MyConn.Open();
                    using (var comando = new MySqlCommand())
                    {
                        comando.Connection = MyConn;
                        /*comando.CommandText = "SELECT " +
                        "(SELECT sum(detalle_venta.subtotal) FROM detalle_venta INNER JOIN venta on detalle_venta.id_venta = venta.id WHERE venta.cliente_documento = @dni AND venta.tipo <> 1) as 'Total Comprado' " +
                        ", (SELECT sum(pagosparciales.monto) FROM pagosparciales WHERE pagosparciales.documento = @dni) as 'Total Pagado' " +
                        ", (SELECT sum(detalle_venta.subtotal) FROM detalle_venta INNER JOIN venta on detalle_venta.id_venta = venta.id WHERE venta.cliente_documento = @dni AND venta.tipo <> 1) " +
                        "- (SELECT sum(pagosparciales.monto) FROM pagosparciales WHERE pagosparciales.documento = @dni) as 'Deuda' " +
                        "FROM cliente WHERE cliente.documento = @dni";*/

                        comando.CommandText = "SELECT " +
                        "IFNULL((SELECT sum(detalle_venta.subtotal) FROM detalle_venta INNER JOIN venta on detalle_venta.id_venta = venta.id WHERE venta.cliente_documento = @dni AND venta.tipo <> 1),0) as 'Total Comprado' " +
                        ", IFNULL((SELECT sum(pagosparciales.monto) FROM pagosparciales WHERE pagosparciales.documento = @dni),0) as 'Total Pagado' " +
                        ", IFNULL((SELECT sum(detalle_venta.subtotal) FROM detalle_venta INNER JOIN venta on detalle_venta.id_venta = venta.id WHERE venta.cliente_documento = @dni AND venta.tipo <> 1) " +
                        "- (SELECT sum(pagosparciales.monto) FROM pagosparciales WHERE pagosparciales.documento = @dni),0) as 'Deuda' " +
                        "FROM cliente WHERE cliente.documento = @dni";

                        comando.Parameters.AddWithValue("@dni", documento);

                        using (MySqlDataReader _reader = comando.ExecuteReader())
                        {

                            while (_reader.Read())
                            {
                           
                                deuda = new Deuda
                                {
                                    total_comprado = _reader.GetString(0),
                                    total_pagado = _reader.GetString(1),
                                    deuda = _reader.GetString(2)

                                };                           

                            }
                        }

                    }


                }
            }catch(MySqlException ex) { Console.WriteLine("Excepción MYSQL"); }


                return deuda;
        }


    }
    public class Deuda
    {
    public string total_comprado { get; set; }
    public string total_pagado { get; set; }
    public string deuda { get; set; }

    public Deuda()
        {
            total_comprado = string.Empty;
            total_pagado = string.Empty;
            deuda = string.Empty;
        }
    }
}
