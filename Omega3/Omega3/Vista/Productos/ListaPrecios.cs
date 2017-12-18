using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Controlador;
using Microsoft.Office.Interop.Excel;

namespace Omega3.Vista.Productos
{
    public partial class ListaPrecios : Form
    {
        int listaprecio;
        public ListaPrecios(int listaprecio)
        {
            InitializeComponent();
            this.listaprecio = listaprecio;
            construirTabla();
            armarExcel();
        }


        public void construirTabla()
        {

            var cod_producto = new DataGridViewTextBoxColumn();
            var producto = new DataGridViewTextBoxColumn();
            var categoria = new DataGridViewTextBoxColumn();
            var precio = new DataGridViewTextBoxColumn();

            cod_producto.HeaderText = "Cod Producto";
            cod_producto.Name = "Cod Producto";
            cod_producto.DataPropertyName = "Cod Producto";
            cod_producto.ReadOnly = true;

            producto.Name = "Producto";
            producto.HeaderText = "Producto";
            producto.DataPropertyName = "Producto";
            producto.ReadOnly = true;

            categoria.HeaderText = "Categoria";
            //categoria.Name = "Categoria;
            categoria.Name = "Categoria";
            categoria.DataPropertyName = "Categoria";
            categoria.ReadOnly = true;

            precio.HeaderText = "Precio";
            precio.Name = "Precio";
            precio.DataPropertyName = "Precio";
            precio.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cod_producto, producto, categoria,precio  });



            string query = "SELECT cod_producto AS 'Cod Producto',producto as Producto,ROUND(if(productos.id_categoria<>1,if(productos.dolar = 1,precio_compra * (SELECT valor from valor_dolar where id = 1) * (((SELECT	valor from markup where id= " + listaprecio + ")/100)+1),precio_compra * (((SELECT	valor from markup where id= " + listaprecio + ")/100)+1)), precio_compra),2)as Precio,categoria as 'Categoria' FROM productos LEFT JOIN categoria_producto on productos.id_categoria = categoria_producto.id";
            ControlCliente.llenarListaClienteExcel(dgv_tabla, query);
        }

        private void ListaPrecios_Load(object sender, EventArgs e)
        {

        }


        public void armarExcel()
        {
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Interactive = false;
            
            
            try
            {




                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.WindowState = XlWindowState.xlMaximized;



                ws.Range[ws.Cells[1, 1], ws.Cells[3, 7]].Merge();


                ws.Cells[1, 1] = "LISTA DE PRECIOS SIN IVA";
                ws.Cells[1, 1].Font.Bold = true;
                ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[1, 1].Font.Size = 20;

                Microsoft.Office.Interop.Excel.Range cabecera = ws.get_Range("a1", "g4");
                cabecera.BorderAround2();
                cabecera.Interior.Color = Color.White;

                ws.Range[ws.Cells[4, 1], ws.Cells[4, 7]].Merge();
                ws.Cells[4, 1] = "Fecha : " + DateTime.Now.Date.ToString("dd/MM/yyyy");
                ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[4, 1].Font.Bold = true;


                //ws.Range[ws.Cells[5, 1], ws.Cells[5, 2]].Merge();
                ws.Cells[5, 1] = "COD";
                ws.Cells[5, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range lista = ws.get_Range("a5", "a5");
                lista.BorderAround2();
                lista.Interior.Color = Color.White;

                ws.Range[ws.Cells[5, 2], ws.Cells[5, 4]].Merge();
                ws.Cells[5, 2] = "Producto";
                ws.Cells[5, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 2].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 2].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range razon = ws.get_Range("b5", "d5");
                razon.BorderAround2();
                razon.Interior.Color = Color.White;

                ws.Range[ws.Cells[5, 5], ws.Cells[5, 6]].Merge();
                ws.Cells[5, 5] = "Categoría";
                ws.Cells[5, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range email = ws.get_Range("e5", "f5");
                email.BorderAround2();
                email.Interior.Color = Color.White;

                
                ws.Cells[5, 7] = "Precio";
                ws.Cells[5, 7].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 7].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 7].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range precio = ws.get_Range("g5", "g5");
                precio.BorderAround2();
                precio.Interior.Color = Color.White;


                int fila = 6;

                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        if (j == 0)
                        {
                            
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells[j].Value;
                            AllBorders(ws.Cells[fila, 1].Borders);
                            //ws.Cells[fila, 1].Color = Color.White;

                        }
                        else if (j == 1)
                        {
                            ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Merge();
                            ws.Cells[fila, 2] = dgv_tabla.Rows[i].Cells[j].Value;
                            AllBorders(ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Borders);
                            //ws.Range[ws.Cells[fila, 2], ws.Cells[fila, 4]].Color = Color.White;

                        }
                        else if (j == 3)
                        {

                            ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Merge();
                            ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells[j].Value;
                            AllBorders(ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Borders);
                           // ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 6]].Color = Color.White;


                        }
                        else if (j == 2)
                        {
                            
                            ws.Cells[fila, 7] = dgv_tabla.Rows[i].Cells[j].Value;
                            AllBorders(ws.Cells[fila, 7].Borders);
                            //ws.Cells[fila, 7].Color = Color.White;
                        }

                    }


                    fila++;
                }
                ws.Columns[1].NumberFormat = "######";

                //ws.Range("A1:F20").Borders.LineStyle = xlContinuous



                //AllBorders(ws.get_Range("a1", "zz9999").Borders);
                
                ws.Columns[7].NumberFormat = "$ #.###,00";

                Excel.Interactive = true;
                Excel.Visible = true;
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void AllBorders(Borders _borders)
        {
            _borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            _borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            _borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            _borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            _borders.Color = Color.Black;
        }

    }
}
