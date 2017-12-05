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

            calcularTamanioPanel();

        }

        private void Reparaciones_Realizadas_Load(object sender, EventArgs e)
        {
            ControlReparaciones.construirTablaReparacionesRealizadas(dgv_tabla);
        }

        private void Reparaciones_Realizadas_Resize(object sender, EventArgs e)
        {
            calcularTamanioPanel();
        }

        private void calcularTamanioPanel()
        {
            panel1.Size = new Size(this.Width, this.Size.Height - panel_filtros.Size.Height);

            //MessageBox.Show(panel1.Size.Width.ToString() + "-" + this.Size.Width);

            dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla.Dock = DockStyle.Fill;
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
    }
}