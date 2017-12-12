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
using System.Net;
using System.IO;

namespace Omega3.Vista.Reparaciones
{
    public partial class Reparaciones_Realizadas : Form
    {
        public Reparaciones_Realizadas()
        {
            InitializeComponent();


            ControlReparaciones.construirTablaReparacionesRealizadas(dgv_tabla);
            calcularTamanioPanel();

            this.MinimumSize = new Size(1244, this.Size.Height);
           
            
        }

        private void Reparaciones_Realizadas_Load(object sender, EventArgs e)
        {
            
            
            limpiarFiltros();
        }

        private void Reparaciones_Realizadas_Resize(object sender, EventArgs e)
        {
           calcularTamanioPanel();
        }

        private void calcularTamanioPanel()
        {

            this.linkLabel_limpiar_filtro.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.panel1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);

            this.dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabla.Dock = DockStyle.Fill;

        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dgv_tabla.DefaultCellStyle.Font = new Font("Arial", 9);
            if (dgv_tabla.Columns[e.ColumnIndex].Name == "URL")
            {

                e.Value = Properties.Resources.dgv_tabla_descargar;
            }
            if(dgv_tabla.Columns[e.ColumnIndex].Name == "Informacion")
            {
                e.Value = Properties.Resources.btn_info_1616;
            }
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = string.Empty;
            string nrofactura = string.Empty;
            Vista.Reparaciones.Reparacion reparacion;
            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                if (e.ColumnIndex == dgv_tabla.Columns["URL"].Index) //2nd column - DGV_ImageColumn
                {

                    if (dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString().Trim() != "" || !string.IsNullOrEmpty(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Link"].Value.ToString()))
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
                        catch (Exception ex) { MessageBox.Show("Excepción detectada -> " + ex.ToString() + " comuniquese con su proveedor de software"); }
                        finally { Cursor.Current = Cursors.Default; }
                    }


                }

                if(e.ColumnIndex == dgv_tabla.Columns["Informacion"].Index)
                {
                    reparacion = new Reparacion(long.Parse(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Id"].Value.ToString()));
                    reparacion.ShowDialog();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reparacion a = new Reparacion(20);
            a.Show();
        }

        private void crearFiltro()
        {

            string filtro_estado = string.Empty;
            string filtro_razon = string.Empty;
            string filtro_nfactura = string.Empty;
            string filtro_fecha = string.Empty;
            string filtro_maquina = string.Empty;
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

            if (txt_filtro_razon.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_razon.Text))
            {

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
            if (txt_filtro_factura.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_factura.Text))
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
            if (txt_desde.Value != DateTime.Now.Date || txt_hasta.Value != DateTime.Now.Date)
            {
                if (and)
                {
                    filtro_fecha = string.Format(" AND " + ControladorFuncVariadas.filtro_desde_hasta(txt_desde, txt_hasta));
                }
                else
                {
                    filtro_fecha = string.Format(" " + ControladorFuncVariadas.filtro_desde_hasta(txt_desde, txt_hasta));
                }
                and = true;

            }
            if (txt_maquina.Text.Trim() != "" || !string.IsNullOrEmpty(txt_maquina.Text))
            {
                if (and)
                {
                    filtro_maquina = string.Format(" AND convert([Maquina], 'System.String') like '%{0}%'", txt_maquina.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_maquina = string.Format(" convert([Maquina], 'System.String') like '%{0}%'", txt_maquina.Text.Trim().Replace("'", "''"));
                }
                and = true;

            }


            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;

            string query = filtro_estado + filtro_razon + filtro_nfactura + filtro_fecha + filtro_maquina;

            dt.DefaultView.RowFilter = query;
            dgv_tabla.Refresh();

        }

        private void txt_filtro_razon_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_filtro_factura_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_maquina_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_desde_ValueChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_hasta_ValueChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void filtro_estado_venta_SelectedIndexChanged(object sender, EventArgs e)
        {
            crearFiltro();
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
            txt_desde.Value = DateTime.Now.Date;
            txt_hasta.Value = DateTime.Now.Date;
            txt_maquina.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }
    }
}