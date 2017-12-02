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
using Omega3.Modelo;
using System.Net;
using System.IO;

namespace Omega3.Vista.Venta
{
    public partial class Ventas_Realizadas : Form
    {
        public Ventas_Realizadas()
        {
            InitializeComponent();

            // I created these columns at function scope but if you want to access 

            /*    var borrar = new DataGridViewImageColumn();

                borrar.HeaderText = "Quitar";
                borrar.Name = "Borrar";
                borrar.ReadOnly = true;

                dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { borrar});

                Omega3.Controlador.ControlVentas.llenar_ventas_realizadas(dgv_tabla);
                */
            ControlVentas.construirTablaVentasRealizadas(dgv_tabla);
            //razon, nrofactura, tipo, remito, total, fecha, fecha_vto, fecha_cobro, vendedor, cobrada, url
           // dgv_tabla.Rows.Add("Prueba", "222", "222", "222", "2222", "222", "222", "2222", "222", "1");
           
        }

        private void Ventas_Realizadas_Load(object sender, EventArgs e)
        {
            filtro_estado_venta.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Venta a = new Modelo.Venta();

            if (dgv_tabla.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_tabla.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_tabla.Rows[selectedrowindex];

                a.id = long.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                a.nrofactura = long.Parse(Convert.ToString(selectedRow.Cells[2].Value));
                a.remito = long.Parse(Convert.ToString(selectedRow.Cells["Remito"].Value));

                if (Convert.ToInt32(selectedRow.Cells["Cobrada"].Value) == 1)
                    a.cobrada = true;
                else
                    a.cobrada = false;

                CobrarVenta c = new CobrarVenta(a);
                c.ShowDialog();

                Omega3.Controlador.ControlVentas.llenar_ventas_realizadas(dgv_tabla);
                limpiarFiltros();

            }


            }

        private void filtro_estado_venta_SelectedIndexChanged(object sender, EventArgs e)
        {

            crearFiltro();

        }

        private void txt_filtro_factura_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_filtro_razon_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }


        private void crearFiltro()
        {
            
            string filtro_estado = string.Empty;
            string filtro_razon = string.Empty;
            string filtro_nfactura = string.Empty;
            bool and = false;

            if (filtro_estado_venta.SelectedIndex != -1)
            {
                and = true;
                if (filtro_estado_venta.SelectedIndex == 2)
                {
                    filtro_estado = string.Format("[Cobrada] = 0");
                }
                else if (filtro_estado_venta.SelectedIndex == 0)
                {
                    and = false;
                    filtro_estado = string.Empty;
                }
                else if (filtro_estado_venta.SelectedIndex == 1)
                {
                    filtro_estado = string.Format("[Cobrada] = 1");
                }
            }

            if(txt_filtro_razon.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_razon.Text)){
                
                if (and)
                {
                    filtro_razon = string.Format(" AND convert([Razon Social], 'System.String') like '%{0}%'", txt_filtro_razon.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_razon = string.Format(" convert([Razon Social], 'System.String') like '%{0}%'", txt_filtro_razon.Text.Trim().Replace("'", "''"));
                }
                and = true;
            }
            if(txt_filtro_factura.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_factura.Text))
            {
                if (and)
                {
                    filtro_nfactura = string.Format(" AND convert([Nro Factura], 'System.String') like '%{0}%'", txt_filtro_factura.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_nfactura = string.Format(" convert([Nro Factura], 'System.String') like '%{0}%'", txt_filtro_factura.Text.Trim().Replace("'", "''"));
                }
                and = true;

            }

            
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;

            string query = filtro_estado + filtro_razon + filtro_nfactura;
            
            dt.DefaultView.RowFilter = query;
            dgv_tabla.Refresh();
            
        }


        private void linkLabel_limpiar_filtro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarFiltros();
        }

        private void limpiarFiltros()
        {
            filtro_estado_venta.SelectedIndex = 0;
            txt_filtro_factura.Text = "";
            txt_filtro_razon.Text = "";
        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dgv_tabla.DefaultCellStyle.Font = new Font("Arial", 9);
            if (dgv_tabla.Columns[e.ColumnIndex].Name == "URL")
            {

                e.Value = Properties.Resources.dgv_tabla_descargar;
            }
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string url = string.Empty;
            string nrofactura = string.Empty;

            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                if (e.ColumnIndex == dgv_tabla.Columns["URL"].Index) //2nd column - DGV_ImageColumn
                {

                    if(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString().Trim() != "" || !string.IsNullOrEmpty(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString()))
                    {
                        try
                        {
                            // System.Diagnostics.Process.Start(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString());
                            url = dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString();
                            nrofactura = dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Nro Factura"].Value.ToString();
                            using (WebClient webClient = new WebClient())
                            {
                                try
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    webClient.DownloadFile(url, Path.GetTempPath() + "Factura_" + nrofactura + ".pdf");
                                    System.Diagnostics.Process.Start(Path.GetTempPath() + "Factura_" + nrofactura + ".pdf");
                                }
                                catch (FileLoadException ex) { Console.Write(ex); }
                            }



                        }
                        catch (Exception ex) { MessageBox.Show("Excepción detectada -> "+ex.ToString()+" comuniquese con su proveedor de software");}
                        finally { Cursor.Current = Cursors.Default; }
                    }



                }
            }
        }
    }
}
