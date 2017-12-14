using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Omega3.Controlador;

namespace Omega3.Vista.Administracion
{
    public partial class CierreDeCaja : Form
    {
        public CierreDeCaja()
        {
            InitializeComponent();

            string query = "SELECT 'Total Efectivo' as 'Titulo', sum(pagosparciales.monto) as Monto FROM pagosparciales WHERE medio_de_pago = 1 AND date(pagosparciales.fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_efectivo, query);

            query = "SELECT 'Total Crédito/Débito' as 'Titulo', sum(pagosparciales.monto) as Monto FROM pagosparciales WHERE (medio_de_pago = 3 OR medio_de_pago = 4) AND date(pagosparciales.fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_tarjeta, query);

            query = "SELECT v.remito as Titulo,monto as Monto FROM pagosparciales p INNER JOIN venta v on p.id_venta = v.id WHERE (p.medio_de_pago = 3 OR p.medio_de_pago = 4) AND date(p.fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_detalle_tarjetas, query);

            query = "SELECT v.remito as Titulo,monto as Monto FROM pagosparciales p INNER JOIN venta v on p.id_venta = v.id WHERE (p.medio_de_pago = 3 OR p.medio_de_pago = 4) AND date(p.fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_detalle_tarjetas, query);

            query = "SELECT r.remito as Titulo,monto as Monto FROM pagosparciales p INNER JOIN reparaciones r on p.id_reparacion = r.id WHERE (p.medio_de_pago = 3 OR p.medio_de_pago = 4) AND date(p.fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_detalle_tarjetas_reparaciones, query);

            query = "SELECT round(sum(pagosparciales.monto),2) as Monto, 'Total Cheques' as 'Titulo' FROM pagosparciales WHERE medio_de_pago = 5 AND date(fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_cheques, query);

            query = "SELECT CONCAT(razon_social, ' ', banco, ' ',comprobante) as Titulo,monto as Monto FROM pagosparciales WHERE medio_de_pago = 5 AND date(fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_detalle_cheque, query);

            query = "SELECT round(sum(monto),2) as Monto, 'Total' as Titulo FROM pagosparciales WHERE date(fecha) = CURRENT_DATE";
            ControlAdministracion.construirTablaPagos(dgv_tabla_total, query);

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

        }


        public void crearExcel()
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            //************************************************************//
            //**************CONSTRUIMOS LA CABECERA DEL EXCEL*************//
            //************************************************************//

            ws.Range[ws.Cells[1, 1], ws.Cells[3, 7]].Merge();


            ws.Cells[1, 1] = "RENDICIÓN CAJA OMEGA DISTRIBUIDORA";
            ws.Cells[1, 1].Font.Bold = true;
            ws.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
            ws.Cells[1, 1].Font.Size = 20;

            ws.Range[ws.Cells[4, 1], ws.Cells[4, 7]].Merge();
            ws.Cells[4, 1] = "Fecha Rendición: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
            ws.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[4, 1].VerticalAlignment = XlVAlign.xlVAlignCenter;
            ws.Cells[4, 1].Font.Bold = true;



            Microsoft.Office.Interop.Excel.Range cabecera = ws.get_Range("a1", "g4");
            cabecera.BorderAround2();
            cabecera.Interior.Color = Color.White;

            //************************************************************//
            //*****************FIN LA CABECERA DEL EXCEL******************//
            //************************************************************//


            //************************************************************//
            //*****************************EFECTIVO**********************//
            //************************************************************//

            int fila_efectivo = 7;
            ws.Range[ws.Cells[fila_efectivo, 1], ws.Cells[fila_efectivo, 6]].Merge();
            ws.Range["a7", "f7"].BorderAround2();
            ws.Range["a7", "f7"].Font.Bold = true;
            ws.Range["f7", "g7"].BorderAround2();
            ws.Range["f7", "g7"].Font.Bold = true;


            ws.Cells[fila_efectivo, 1] = dgv_tabla_efectivo.Rows[0].Cells[0].Value.ToString();
            ws.Cells[fila_efectivo, 7] = "$" + dgv_tabla_efectivo.Rows[0].Cells[1].Value.ToString();

            int fila_tarjeta = 8;
            ws.Range[ws.Cells[fila_tarjeta, 1], ws.Cells[fila_tarjeta, 6]].Merge();
            ws.Range["a8", "f8"].BorderAround2();
            ws.Range["a8", "f8"].Font.Bold = true;
            ws.Range["f8", "g8"].BorderAround2();
            ws.Range["f8", "g8"].Font.Bold = true;

            ws.Cells[fila_tarjeta, 1] = dgv_tabla_tarjeta.Rows[0].Cells[0].Value.ToString();
            ws.Cells[fila_tarjeta, 7] = "$" + dgv_tabla_tarjeta.Rows[0].Cells[1].Value.ToString();

            int fila_detalle_tarjeta = 9;

            fila_detalle_tarjeta--;

            for (int i = 0; i < dgv_tabla_detalle_tarjetas.Rows.Count; i++)
            {
                fila_detalle_tarjeta++;
                ws.Range[ws.Cells[fila_detalle_tarjeta, 1], ws.Cells[fila_detalle_tarjeta, 5]].Merge();
                ws.Range["a" + fila_detalle_tarjeta, "e" + fila_detalle_tarjeta].BorderAround2();
                ws.Range["a" + fila_detalle_tarjeta, "e" + fila_detalle_tarjeta].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Range["e" + fila_detalle_tarjeta, "f" + fila_detalle_tarjeta].BorderAround2();

                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        ws.Cells[fila_detalle_tarjeta, 1] = dgv_tabla_detalle_tarjetas.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        ws.Cells[fila_detalle_tarjeta, 6] = dgv_tabla_detalle_tarjetas.Rows[i].Cells[j].Value;
                    }

                }
            }

            int fila_detalle_tarjeta_reparaciones = fila_detalle_tarjeta + 1;
            fila_detalle_tarjeta_reparaciones--;

            for (int i = 0; i < dgv_tabla_detalle_tarjetas.Rows.Count; i++)
            {
                fila_detalle_tarjeta_reparaciones++;
                ws.Range[ws.Cells[fila_detalle_tarjeta_reparaciones, 1], ws.Cells[fila_detalle_tarjeta_reparaciones, 5]].Merge();
                ws.Range["a" + fila_detalle_tarjeta_reparaciones, "e" + fila_detalle_tarjeta_reparaciones].BorderAround2();
                ws.Range["a" + fila_detalle_tarjeta_reparaciones, "e" + fila_detalle_tarjeta_reparaciones].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Range["e" + fila_detalle_tarjeta_reparaciones, "f" + fila_detalle_tarjeta_reparaciones].BorderAround2();

                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        ws.Cells[fila_detalle_tarjeta_reparaciones, 1] = dgv_tabla_detalle_tarjetas_reparaciones.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        ws.Cells[fila_detalle_tarjeta_reparaciones, 6] = dgv_tabla_detalle_tarjetas_reparaciones.Rows[i].Cells[j].Value;
                    }

                }
            }


            //CABECEra CHEquE
            int fila_cheque = fila_detalle_tarjeta_reparaciones + 1;
            ws.Range[ws.Cells[fila_cheque, 1], ws.Cells[fila_cheque, 6]].Merge();
            ws.Range["a" + fila_cheque, "f" + fila_cheque].BorderAround2();
            ws.Range["f" + fila_cheque, "g" + fila_cheque].BorderAround2();
            ws.Range["a" + fila_cheque, "f" + fila_cheque].Font.Bold = true;
            ws.Range["f" + fila_cheque, "g" + fila_cheque].Font.Bold = true;

            ws.Cells[fila_cheque, 1] = dgv_tabla_cheques.Rows[0].Cells[0].Value.ToString();
            ws.Cells[fila_cheque, 7] = "$" + dgv_tabla_cheques.Rows[0].Cells[1].Value.ToString();

            //DETALLE CHEQUE
            int fila_detalle_cheque = fila_cheque + 1;
            fila_detalle_cheque--;

            for (int i = 0; i < dgv_tabla_detalle_cheque.Rows.Count; i++)
            {
                fila_detalle_cheque++;
                ws.Range[ws.Cells[fila_detalle_cheque, 1], ws.Cells[fila_detalle_cheque, 5]].Merge();
                ws.Range["a" + fila_detalle_cheque, "e" + fila_detalle_cheque].BorderAround2();
                ws.Range["a" + fila_detalle_cheque, "e" + fila_detalle_cheque].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Range["e" + fila_detalle_cheque, "f" + fila_detalle_cheque].BorderAround2();

                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        ws.Cells[fila_detalle_cheque, 1] = dgv_tabla_detalle_cheque.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        ws.Cells[fila_detalle_cheque, 6] = dgv_tabla_detalle_cheque.Rows[i].Cells[j].Value;
                    }

                }
            }

            int fila_total = fila_detalle_cheque + 1;
            ws.Range[ws.Cells[fila_total, 1], ws.Cells[fila_total, 6]].Merge();
            ws.Range["a" + fila_total, "f" + fila_total].BorderAround2();
            ws.Range["f" + fila_total, "g" + fila_total].BorderAround2();
            ws.Range["a" + fila_total, "f" + fila_total].Font.Bold = true;
            ws.Range["f" + fila_total, "g" + fila_total].Font.Bold = true;

            ws.Cells[fila_total, 1] = dgv_tabla_total.Rows[0].Cells[0].Value.ToString();
            ws.Cells[fila_total, 7] = "$" + dgv_tabla_total.Rows[0].Cells[1].Value.ToString();



        
    }

        private void CierreDeCaja_Load(object sender, EventArgs e)
        {
            

            calcularTamanio();
        }

        private void calcularTamanio()
        {
            dgv_tabla_efectivo.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla_efectivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla_efectivo.Dock = DockStyle.Fill;

            dgv_tabla_tarjeta.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla_tarjeta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla_tarjeta.Dock = DockStyle.Fill;

            dgv_tabla_detalle_tarjetas.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla_detalle_tarjetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla_detalle_tarjetas.Dock = DockStyle.Fill;

            dgv_tabla_detalle_tarjetas_reparaciones.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla_detalle_tarjetas_reparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla_detalle_tarjetas_reparaciones.Dock = DockStyle.Fill;

        }

    }
}
