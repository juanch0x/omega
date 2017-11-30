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
namespace Omega3.Vista.Venta
{
    public partial class Ventas_Realizadas : Form
    {
        public Ventas_Realizadas()
        {
            InitializeComponent();
            Omega3.Controlador.ControlVentas.llenar_ventas_realizadas(dgv_tabla);
            
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
            //MessageBox.Show(query);

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

    }
}
