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

namespace Omega3.Vista.Venta
{
    public partial class ListarPresupuestos : Form
    {
        public ListarPresupuestos()
        {
            InitializeComponent();
            ControlVentas.construirTablaPresupuestos(dgv_tabla);

           // calcularTamanio();
            txt_desde.Value = DateTime.Now.Date;
            txt_hasta.Value = DateTime.Now.Date;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void calcularTamanio()
        {
            panel_tabla.Size = new Size(this.Width, this.Size.Height - panel_filtros.Size.Height);


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
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vista.Informes.Presupuesto presupuesto;
            long id;
            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                if (e.ColumnIndex == dgv_tabla.Columns["URL"].Index) //2nd column - DGV_ImageColumn
                {
                    Cursor.Current = Cursors.WaitCursor;

                    try
                    {
                        id = long.Parse(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                        presupuesto = new Informes.Presupuesto(id);
                        presupuesto.ShowDialog();

                    }
                    catch (Exception ex) { MessageBox.Show("Excepción no controlada por la aplicación" + ex.ToString()); }
                    finally { Cursor.Current = Cursors.Default; }


                }
            }
        }

        private void ListarPresupuestos_Resize(object sender, EventArgs e)
        {
          //  calcularTamanio();
        }



        private void linkLabel_limpiar_filtro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarFiltros();
        }




        private void limpiarFiltros()
        {
            
            txt_filtro_npresupuesto.Text = "";
            txt_filtro_razon.Text = "";
            txt_desde.Value = DateTime.Now.Date;
            txt_hasta.Value = DateTime.Now.Date;
        }


        private void crearFiltro()
        {

            string filtro_fecha = string.Empty;
            string filtro_razon = string.Empty;
            string filtro_npresupuesto = string.Empty;

            bool and = false;


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
            if (txt_filtro_npresupuesto.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_npresupuesto.Text))
            {
                if (and)
                {
                    filtro_npresupuesto = string.Format(" AND convert([Id], 'System.String') like '%{0}%'", txt_filtro_npresupuesto.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    filtro_npresupuesto = string.Format(" convert([Id], 'System.String') like '%{0}%'", txt_filtro_npresupuesto.Text.Trim().Replace("'", "''"));
                }
                and = true;

            }
            if (txt_desde.Value != DateTime.Now.Date || txt_hasta.Value != DateTime.Now.Date)
            {
                if (and)
                {
                    filtro_fecha = string.Format(" AND "+ControladorFuncVariadas.filtro_desde_hasta(txt_desde,txt_hasta));
                }
                else
                {
                    filtro_fecha = string.Format(" "+ControladorFuncVariadas.filtro_desde_hasta(txt_desde,txt_hasta));
                }
                and = true;

            }


            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;

            string query = filtro_razon + filtro_npresupuesto + filtro_fecha;

            dt.DefaultView.RowFilter = query;
            dgv_tabla.Refresh();

        }

        private void txt_filtro_npresupuesto_TextChanged(object sender, EventArgs e)
        {
            crearFiltro();
        }

        private void txt_filtro_razon_TextChanged(object sender, EventArgs e)
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

        

    }
}
