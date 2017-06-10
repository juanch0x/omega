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
                ControlProducto.validarTextboxVacio("producto");
            }
            else if (txt_cantidad.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("stock");
            }
            else if (txt_codigo.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("código");
            }
            else if (txt_precio_costo.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("precio de costo");
            }
            else if (txt_precio_venta.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("precio de venta");
            }
            else if (txt_stock_minimo.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("stock mínimo");
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
