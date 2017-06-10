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
using System.Globalization;

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
            txt_producto.Focus();

        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;

            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txt_precio_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
             CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
              if (char.IsNumber(e.KeyChar) ||
              e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back)
              )
                  e.Handled = false;
              else
                  e.Handled = true;

            if (e.KeyChar == '.'
             && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||
            e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back)
            )
                e.Handled = false;
            else
                e.Handled = true;

            if (e.KeyChar == '.'
             && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txt_cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                btn_agregar_Click(this, new EventArgs());
            }
        }

        private void txt_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_codigo.Focus();
            }
        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_precio_costo.Focus();
            }
        }

        private void txt_precio_costo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_precio_venta.Focus();
            }
        }

        private void txt_precio_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_stock_minimo.Focus();
            }
        }

        private void txt_stock_minimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_cantidad.Focus();
            }
        }
    }
}
