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

namespace Omega3.Vista.Productos
{
    public partial class EliminarProductos : Form
    {

        

        public EliminarProductos()
        {
            InitializeComponent();
        }

        private void EliminarProductos_Load(object sender, EventArgs e)
        {
            Omega3.Controlador.ControlProducto.autoCompletarProducto(combo_producto);
            combo_producto.Select();


        }

        private void combo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_codigo.Text = Omega3.Controlador.ControlProducto.obtenerCodigoPorNombre(combo_producto.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Producto a = new Modelo.Producto();
            a.Cod_producto = long.Parse(txt_codigo.Text);

            DialogResult boton = MessageBox.Show("Realmente desea eliminar el producto "+combo_producto.Text+"?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                ControlProducto.EliminarProducto(a);
                combo_producto.Items.Remove(combo_producto.SelectedItem);
                txt_codigo.Text = "";

                MessageBox.Show("El producto se eliminó correctamente.");
            }
        }
    }
}
