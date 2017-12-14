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

namespace Omega3.Vista.Administracion
{
    public partial class listarcompras : Form
    {
        public listarcompras()
        {
            InitializeComponent();

        }

        private void calcularTamanio()
        {


            panel_tabla.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);

            dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla.Dock = DockStyle.Fill;

        }


        private void listarcompras_Load(object sender, EventArgs e)
        {
            Omega3.Controlador.ControlCompras.construirTablacomprasrealizadas(dgv_tabla);
            calcularTamanio();
        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_tabla.Columns[e.ColumnIndex].Name == "Modificar")
            {

                e.Value = Properties.Resources.btn_info_1616;
            }
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                if (e.ColumnIndex == dgv_tabla.Columns["Modificar"].Index) //2nd column - DGV_ImageColumn
                {
                    modificarcompra a = new modificarcompra(long.Parse(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Id"].Value.ToString()));
                    a.ShowDialog();
                    Controlador.ControlCompras.llenar_compras_realizadas(dgv_tabla);

                }
            }
        }

        private void crearFiltro()
        {

            string filtro_estado = string.Empty;
            string filtro_razon = string.Empty;
            string filtro_nfactura = string.Empty;
            string filtro_fecha = string.Empty;
            bool and = false;

            if (filtro_estado_venta.SelectedIndex != -1)
            {
                and = true;
                if (filtro_estado_venta.SelectedIndex == 2)
                {
                    filtro_estado = string.Format("[Pagada] = 0");
                }
                else if (filtro_estado_venta.SelectedIndex == 0)
                {
                    and = false;
                    filtro_estado = string.Empty;
                }
                else if (filtro_estado_venta.SelectedIndex == 1)
                {
                    filtro_estado = string.Format("[Pagada] = 1");
                }
            }

            if (txt_filtro_razon.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_razon.Text))
            {

                if (and)
                {
                    filtro_razon = string.Format(" AND convert([Proveedor], 'System.String') like '%{0}%'", txt_filtro_razon.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_razon = string.Format(" convert([Proveedor], 'System.String') like '%{0}%'", txt_filtro_razon.Text.Trim().Replace("'", "''"));
                }
                and = true;
            }
            if (txt_filtro_factura.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_factura.Text))
            {
                if (and)
                {
                    filtro_nfactura = string.Format(" AND convert([Comprobante], 'System.String') like '%{0}%'", txt_filtro_factura.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_nfactura = string.Format(" convert([Comprobante], 'System.String') like '%{0}%'", txt_filtro_factura.Text.Trim().Replace("'", "''"));
                }
                and = true;

            }
            if (txt_desde.Value != DateTime.Now.Date || txt_hasta.Value != DateTime.Now.Date)
            {
                if (and)
                {
                    filtro_fecha = string.Format(" AND " + filtro_desde_hasta(txt_desde, txt_hasta));
                }
                else
                {
                    filtro_fecha = string.Format(" " + filtro_desde_hasta(txt_desde, txt_hasta));
                }
                and = true;

            }


            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;

            string query = filtro_estado + filtro_razon + filtro_nfactura + filtro_fecha;

            dt.DefaultView.RowFilter = query;
            dgv_tabla.Refresh();

        }

        public static string filtro_desde_hasta(DateTimePicker txt_desde, DateTimePicker txt_hasta)
        {

            string desde = String.Format("#" + "{0:MM/dd/yyyy}" + "#", txt_desde.Value.Date);
            string hasta = String.Format("#" + "{0:MM/dd/yyyy}" + "#", txt_hasta.Value.Date);

            string filter = "Vencimiento >= " + desde + " and Vencimiento <= " + hasta;

            return filter;
        }

        private void txt_filtro_razon_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_filtro_factura_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void filtro_estado_venta_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void txt_filtro_razon_TextChanged_1(object sender, EventArgs e)
        {
            crearFiltro();
        }
    }
}