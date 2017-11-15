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

namespace Omega3.Vista.Reparaciones
{
    public partial class BuscarCliente : Form
    {

        TextBox txt;

        public BuscarCliente()
        {
            InitializeComponent();
        }

        public BuscarCliente(ref TextBox txt)
        {

            InitializeComponent();
            this.txt = txt;

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;



        private void btn_elegir_Click(object sender, EventArgs e)
        {

            txt.Text = "asd";

        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            ControlReparaciones.llenarTablaClientes(dgv_tabla);
            //Muestro el boton al final
            dgv_tabla.Columns[0].DisplayIndex = 2;
            //Defino las cabeceras de la tabla
            dgv_tabla.Columns[1].HeaderText = "Documento";
            dgv_tabla.Columns[2].HeaderText = "Razón Social";
            ControlReparaciones.AutoFill(dgv_tabla);

        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                txt.Text = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[1].Value);

                this.Close();

            }
        }

        private void BuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("convert(Documento, 'System.String') like '%{0}%'", txt_documento.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
        }

        private void txt_razon_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Razon Social] like '%{0}%'", txt_razon.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
        }

        private void txt_documento_Enter(object sender, EventArgs e)
        {
            if (txt_razon.Text.Trim() != "" || !string.IsNullOrEmpty(txt_razon.Text))
                txt_razon.Text = "";
        }

        private void txt_razon_Enter(object sender, EventArgs e)
        {
            if (txt_documento.Text.Trim() != "" || !string.IsNullOrEmpty(txt_documento.Text))
                txt_documento.Text = "";
        }
    }
}
