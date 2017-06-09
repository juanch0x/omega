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

namespace Omega3.Vista.Productos
{
    public partial class ModificarProducto : Form
    {
        Producto producto;
        public ModificarProducto()
        {
            InitializeComponent();
        }

        public ModificarProducto(Producto a) {
                        
            InitializeComponent();
            txt_codigo.Text = Convert.ToString(a.Cod_producto);
            txt_precio_costo.Text = Convert.ToString(a.Precio_costo);
            txt_precio_venta.Text = Convert.ToString(a.Precio_venta);
            txt_producto.Text = a.Nombre_producto;
            txt_stock_minimo.Text = a.Stock_minimo.ToString();
            txt_cantidad.Text = a.Cantidad.ToString();
            txt_producto.Focus();

            producto = new Producto();
            this.producto = a;
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_producto.Text.Trim() == "")
            {
                MessageBox.Show("El campo Producto es obligatorio");
            }
            else if (txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo Stock es obligatorio");
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

                producto.Nombre_producto = txt_producto.Text;
                producto.Precio_costo = Convert.ToDecimal(txt_precio_costo.Text);
                producto.Precio_venta = Convert.ToDecimal(txt_precio_venta.Text);
                producto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
                producto.Cantidad = Convert.ToInt32(txt_cantidad.Text);
                try
                {
                    Omega3.Controlador.ControlProducto.ModificarProducto(producto);
                }
                catch (Exception ex) { Console.WriteLine("Error modificando producto" + ex); }
                MessageBox.Show("El producto fue modificado correctamente.");
                this.Close();
            }
        }
    }
}
