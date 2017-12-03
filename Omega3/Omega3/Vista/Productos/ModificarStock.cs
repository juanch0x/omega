using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
using Omega3.Controlador;

namespace Omega3.Vista.Productos
{
    public partial class ModificarStock : Form
    {
        Producto producto;
        public ModificarStock()
        {
            InitializeComponent();
        }

        public ModificarStock(Producto a)
        {

            InitializeComponent();
            txt_codigo.Text = Convert.ToString(a.Cod_producto);
            txt_producto.Text = a.Nombre_producto;
            txt_stockminimo.Text = a.Stock_minimo.ToString();
            txt_stockactual.Text = a.Cantidad.ToString();
            txt_producto.Focus();
            producto = new Producto();
            this.producto = a;

        }

        private void txt_stockagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int32 stock;
            stock = Convert.ToInt32(txt_stockactual.Text) + Convert.ToInt32(txt_stockagregar.Text);

            Controlador.ControlProducto.modificarStock(stock, long.Parse(txt_codigo.Text));

            MessageBox.Show("El stock se agrego correctamente");
            this.Close();
        }
    }
}
