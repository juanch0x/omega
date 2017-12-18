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

namespace Omega3.Vista.Clientes
{
    public partial class ExportarClientesExcel : Form
    {
        public ExportarClientesExcel()
        {
            InitializeComponent();
            construirTabla();
            armarExcel();
        }

        private void ExportarClientesExcel_Load(object sender, EventArgs e)
        {
           

        }

        public void construirTabla()
        {
            
            var lista = new DataGridViewTextBoxColumn();
            var razon_social = new DataGridViewTextBoxColumn();
            var email = new DataGridViewTextBoxColumn();

            lista.HeaderText = "Lista";
            lista.Name = "Lista";
            lista.DataPropertyName = "Lista";
            lista.ReadOnly = true;

            razon_social.Name = "Razon Social";
            razon_social.HeaderText = "Razon Social";
            razon_social.DataPropertyName = "Razon Social";
            razon_social.ReadOnly = true;

            email.HeaderText = "Email";
            email.Name = "Email";
            email.DataPropertyName = "Email";
            email.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { lista, razon_social, email });



            string query = "SELECT markup.lista as 'Lista',razon_social as 'Razon Social',mail_contacto as 'Email' FROM cliente INNER JOIN markup ON markup.id = cliente.lista";
            ControlCliente.llenarListaClienteExcel(dgv_tabla, query);
        }
        public void armarExcel()
        {
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {


                Excel.Interactive = false;

                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.WindowState = XlWindowState.xlMaximized;
                


                ws.Range[ws.Cells[1, 1], ws.Cells[3, 7]].Merge();


                ws.Cells[1, 1] = "LISTA DE CLIENTES";
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


                ws.Range[ws.Cells[5, 1], ws.Cells[5, 2]].Merge();
                ws.Cells[5, 1] = "Lista";
                ws.Cells[5, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 1].Font.Bold = true;

                Microsoft.Office.Interop.Excel.Range lista = ws.get_Range("a5", "b5");
                lista.BorderAround2();
                lista.Interior.Color = Color.White;

                ws.Range[ws.Cells[5, 3], ws.Cells[5, 4]].Merge();
                ws.Cells[5, 3] = "Razon Social";
                ws.Cells[5, 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 3].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 3].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range razon = ws.get_Range("c5", "d5");
                razon.BorderAround2();
                razon.Interior.Color = Color.White;

                ws.Range[ws.Cells[5, 5], ws.Cells[5, 7]].Merge();
                ws.Cells[5, 5] = "Email";
                ws.Cells[5, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Cells[5, 5].VerticalAlignment = XlVAlign.xlVAlignCenter;
                ws.Cells[5, 5].Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range email = ws.get_Range("e5", "g5");
                email.BorderAround2();
                email.Interior.Color = Color.White;



                int fila = 6;

                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (j == 0)
                        {
                            ws.Range[ws.Cells[fila, 1], ws.Cells[fila, 2]].Merge();
                            AllBorders(ws.Range[ws.Cells[fila, 1], ws.Cells[fila, 2]].Borders);
                            ws.Cells[fila, 1] = dgv_tabla.Rows[i].Cells[j].Value;

                        }
                        else if (j == 1)
                        {
                            ws.Range[ws.Cells[fila, 3], ws.Cells[fila, 4]].Merge();
                            ws.Cells[fila, 3] = dgv_tabla.Rows[i].Cells[j].Value;
                            AllBorders(ws.Range[ws.Cells[fila, 3], ws.Cells[fila, 4]].Borders);

                        }
                        else if (j == 2)
                        {

                            ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 7]].Merge();
                            AllBorders(ws.Range[ws.Cells[fila, 5], ws.Cells[fila, 7]].Borders);
                            ws.Cells[fila, 5] = dgv_tabla.Rows[i].Cells[j].Value;



                        }

                    }


                    fila++;
                }
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
