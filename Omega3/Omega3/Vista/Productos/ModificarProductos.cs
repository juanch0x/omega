using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Productos
{
    public partial class ModificarProductos : Form
    {
        public ModificarProductos()
        {
            InitializeComponent();
        }

        private void ModificarProductos_Load(object sender, EventArgs e)
        {
            
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tabla.Columns["columna_borrar"].DisplayIndex = 6;
            

        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("producto like '%{0}%'", filtro.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();



        }
    }
}
