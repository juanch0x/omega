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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_producto.Text.Trim() == "")
            {
                MessageBox.Show("El campo Producto es obligatorio");
            }
            else if (txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo Stock es obligatorio");
            }
            else if (txt_codigo.Text.Trim() == "")
            {
                MessageBox.Show("El Campo Codigo de Barras es obligatorio");
            }
            else if (txt_precio_costo.Text.Trim() == "")
            {
                MessageBox.Show("El campo Precio de Costo es obligatorio");
            }
            else if (txt_precio_venta.Text.Trim() == "")
            {
                MessageBox.Show("El campo Precio de Venta es obligatorio");
            }
            else if (txt_stock_minimo.Text.Trim() == "")
            {
                MessageBox.Show("El campo Stock Minimo es obligatorio");
            }
            else
            {


                Producto producto = new Producto();

                producto.Nombre_producto = txt_producto.Text;
                producto.Cod_producto = long.Parse(txt_codigo.Text);
                producto.Precio_costo = Convert.ToDecimal(txt_precio_costo.Text);
                producto.Precio_venta = Convert.ToDecimal(txt_precio_venta.Text);
                producto.Stock_minimo = Int32.Parse(txt_stock_minimo.Text);
                producto.Cantidad = Int32.Parse(txt_cantidad.Text);

                ControlProducto.AgregarProducto(producto);

                MessageBox.Show("El producto se agregó correctamente!");

                txt_producto.Text = "";
                txt_codigo.Text = "";
                txt_precio_costo.Text = "";
                txt_precio_venta.Text = "";
                txt_stock_minimo.Text = "";
                txt_cantidad.Text = "";
            }

        }
    }
}
