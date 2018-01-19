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
namespace Omega3.Vista.Clientes
{
    public partial class Listar_Clientes : Form
    {
        public Listar_Clientes()
        {
            InitializeComponent();
            ControlCliente.ListarClientes(dgv_tabla);
            
            dgv_tabla.Columns["Editar"].DisplayIndex = 6;
            dgv_tabla.ReadOnly = true;
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                Cliente cliente = new Cliente();
                cliente.Documento = long.Parse(Convert.ToString(((dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Documento"].Value))));

                Modificar_Cliente b = new Modificar_Cliente(cliente);
                b.ShowDialog();
                ControlCliente.ListarClientes(dgv_tabla);


            }
        }

        private void filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Razon Social] like '%{0}%'", txt_filtro_nombre.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
                        
        }

        private void filtro_dni_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("convert(Documento, 'System.String') like '%{0}%'", txt_filtro_dni.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
        }

        //Cuando entro en foco al txt de filtro por nombre, limpio el de DNI para que no se buguee.
        private void txt_filtro_nombre_Enter(object sender, EventArgs e)
        {
            if(txt_filtro_dni.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_dni.Text))
            txt_filtro_dni.Text = "";
        }

        private void txt_filtro_dni_Enter(object sender, EventArgs e)
        {
            if(txt_filtro_nombre.Text.Trim() != "" || !string.IsNullOrEmpty(txt_filtro_nombre.Text))
            txt_filtro_nombre.Text = "";
        }
    }
}
