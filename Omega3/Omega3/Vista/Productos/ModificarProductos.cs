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

            

        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("producto like '%{0}%'", filtro.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();



        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Producto producto = new Modelo.Producto();
            producto.Cod_producto = long.Parse(Convert.ToString(dgv_tabla.CurrentRow.Cells[0].Value));
            DialogResult boton = MessageBox.Show("¿Realmente desea eliminar el producto?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                Omega3.Controlador.ControlProducto.EliminarProducto(producto);
                Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);
                MessageBox.Show("El producto se eliminó correctamente.");
            }   
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Vista.Productos.AgregarProducto agregarProducto = new Vista.Productos.AgregarProducto();
            agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            agregarProducto.ShowDialog();
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);
        }
    }
}
