using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Omega3.Controlador
{
    class ControlRendiciones
    {

        public static void llenarUsuarios(ComboBox combo)
        {

            string query = "SELECT usuario FROM usuarios";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da1.Fill(dt);

            combo.ValueMember = "usuario";
            combo.DisplayMember = "usuario";
            combo.DataSource = dt;

        }

        public static void llenar_reparaciones_realizadas(DataGridView dgv_tabla,string query)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();


            string sqlSelectAll = query;

            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                System.Data.DataTable table = new System.Data.DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;

                
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de reparaciones: " + ex); }
        }



        public static void armarExcelRendiciones(DataGridView dgv_tabla_venta, DataGridView dgv_tabla_reparacion, DateTime desde, DateTime hasta, string usuario)
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



                ws.Cells[1, 1] = "RENDICIÓN "+usuario;
                ws.Range[ws.Cells[1, 1], ws.Cells[3, 6]].Merge();
                cabecera = ws.get_Range("a1", "f3");


                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;
                
                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;

                ws.Cells[4, 1] = "Entre " + desde.ToString("dd/MM/yyyy") + " y " + hasta.ToString("dd/MM/yyyy");
                ws.Range[ws.Cells[4, 1], ws.Cells[4, 6]].Merge();
                Range desdehasta = null;
                desdehasta = ws.get_Range("a4", "f4");

                ws.Cells[4, 1].Font.Bold = true;
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Size = 11;

                desdehasta.BorderAround2();
                desdehasta.Interior.Color = Color.White;




                ws.Cells[5, 1] = "ID VENTA";
                ws.Cells[5, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range id_venta = ws.get_Range("a5", "a5");
                id_venta.BorderAround2();
                id_venta.Interior.Color = Color.White;

                ws.Cells[5, 2] = "Fecha";
                ws.Cells[5, 2].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                ws.Cells[5, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 2].Font.Bold = true;

                Range venta_fecha = ws.get_Range("b5", "b5");
                venta_fecha.BorderAround2();
                venta_fecha.Interior.Color = Color.White;


                ws.Cells[5, 3] = "Vendedor";
                ws.Cells[5, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range venta_vendedor = ws.get_Range("c5", "c5");
                venta_vendedor.BorderAround2();
                venta_vendedor.Interior.Color = Color.White;

                ws.Cells[5, 4] = "Cliente";
                ws.Cells[5, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 4].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 4].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range venta_cliente = ws.get_Range("d5", "d5");
                venta_cliente.BorderAround2();
                venta_cliente.Interior.Color = Color.White;


                ws.Cells[5, 5] = "Monto";
                ws.Cells[5, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range venta_monto = ws.get_Range("e5", "e5");
                venta_monto.BorderAround2();
                venta_monto.Interior.Color = Color.White;


                ws.Cells[5, 6] = "Cobrado";
                ws.Cells[5, 6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 6].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 6].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range venta_cobrado = ws.get_Range("f5", "f5");
                venta_cobrado.BorderAround2();
                venta_cobrado.Interior.Color = Color.White;
                
                
                //********************
                //Empiezo por cantidad
                //********************

                int fila = 6;
                int columnas = 6;

                for (int i = 0; i < dgv_tabla_venta.Rows.Count; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == 0)
                        {
                            ws.Cells[fila, 1] = dgv_tabla_venta.Rows[i].Cells["Id Venta"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);
                                                        

                        }

                        else if (j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla_venta.Rows[i].Cells["Fecha"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);
                        }

                        else if (j == 2)
                        {
                            ws.Cells[fila, 3] = dgv_tabla_venta.Rows[i].Cells["Vendedor"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                            //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                        }

                        else if (j == 3)
                        {

                            ws.Cells[fila, 4] = dgv_tabla_venta.Rows[i].Cells["Cliente"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                            // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                        }

                        else if (j == 4)
                        {

                            ws.Cells[fila, 5] = dgv_tabla_venta.Rows[i].Cells["Monto"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
                        }

                        else if (j == 5)
                        {
                            ws.Cells[fila, 6] = dgv_tabla_venta .Rows[i].Cells["Cobrado"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 6].Borders);
                        }
                                                
                    }


                    fila++;
                }



                ws.Cells[fila, 1] = "ID REPARACIÓN";
                ws.Cells[fila, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range id_reparacion = ws.get_Range("a"+fila, "a"+fila);
                id_reparacion.BorderAround2();
                id_reparacion.Interior.Color = Color.White;

                ws.Cells[fila, 2] = "Fecha";
                ws.Cells[fila, 2].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 2].Font.Bold = true;

                Range reparacion_fecha = ws.get_Range("b"+fila, "b"+fila);
                reparacion_fecha.BorderAround2();
                reparacion_fecha.Interior.Color = Color.White;


                ws.Cells[fila, 3] = "Vendedor";
                ws.Cells[fila, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range reparacion_vendedor = ws.get_Range("c"+fila, "c"+fila);
                reparacion_vendedor.BorderAround2();
                reparacion_vendedor.Interior.Color = Color.White;

                ws.Cells[fila, 4] = "Cliente";
                ws.Cells[fila, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 4].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 4].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range reparacion_cliente = ws.get_Range("d"+fila, "d"+fila);
                reparacion_cliente.BorderAround2();
                reparacion_cliente.Interior.Color = Color.White;


                ws.Cells[fila, 5] = "Monto";
                ws.Cells[fila, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range reparacion_monto = ws.get_Range("e"+fila, "e"+fila);
                reparacion_monto.BorderAround2();
                reparacion_monto.Interior.Color = Color.White;


                ws.Cells[fila, 6] = "Cobrado";
                ws.Cells[fila, 6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[fila, 6].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[fila, 6].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range reparacion_cobrado = ws.get_Range("f"+fila, "f"+fila);
                reparacion_cobrado.BorderAround2();
                reparacion_cobrado.Interior.Color = Color.White;

                fila++;

                for (int i = 0; i < dgv_tabla_reparacion.Rows.Count; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == 0)
                        {
                            ws.Cells[fila, 1] = dgv_tabla_reparacion.Rows[i].Cells["Id Venta"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 1].Borders);


                        }

                        else if (j == 1)
                        {
                            ws.Cells[fila, 2] = dgv_tabla_reparacion.Rows[i].Cells["Fecha"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 2].Borders);
                        }

                        else if (j == 2)
                        {
                            ws.Cells[fila, 3] = dgv_tabla_reparacion.Rows[i].Cells["Vendedor"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 3].Borders);
                            //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                        }

                        else if (j == 3)
                        {

                            ws.Cells[fila, 4] = dgv_tabla_reparacion.Rows[i].Cells["Cliente"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 4].Borders);
                            // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                        }

                        else if (j == 4)
                        {

                            ws.Cells[fila, 5] = dgv_tabla_reparacion.Rows[i].Cells["Monto"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 5].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
                        }

                        else if (j == 5)
                        {
                            ws.Cells[fila, 6] = dgv_tabla_reparacion.Rows[i].Cells["Cobrado"].Value;
                            ControladorFuncVariadas.AllBorders(ws.Cells[fila, 6].Borders);
                        }

                    }


                    fila++;
                }





                //ws.Columns[2].NumberFormat = "######";
                ws.Columns[5].NumberFormat = "$ #.###,00";
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
