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
          
            txt_producto.Text = a.Nombre_producto;
            txt_stock_minimo.Text = a.Stock_minimo.ToString();
            txt_cantidad.Text = a.Cantidad.ToString();
            //combo_moneda.SelectedValue = 0;
            //combo_categoria.SelectedValue = 2;
            combo_categoria.SelectedIndex = -1;

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
            else if (combo_moneda.SelectedIndex == -1)
            {
                ControlProducto.validarTextboxVacio("moneda");
            }
            else if (txt_stock_minimo.Text.Trim() == "")
            {
                ControlProducto.validarTextboxVacio("stock mínimo");
            }
            else
            {

                producto.Nombre_producto = txt_producto.Text;
                producto.Precio_costo = Convert.ToDecimal(txt_precio_costo.Text);
                producto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
                producto.Cantidad = Convert.ToInt32(txt_cantidad.Text);
                producto.Categoria = Convert.ToInt32(combo_categoria.SelectedValue);
                producto.Dolar = Convert.ToInt32(combo_moneda.SelectedIndex);
                
                try
                {
                    Omega3.Controlador.ControlProducto.ModificarProducto(producto);
                }
                catch (Exception ex) { Console.WriteLine("Error modificando producto" + ex); }
                MessageBox.Show("El producto fue modificado correctamente.");
                this.Close();
            }
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

            ControlProducto.llenarCategorias(combo_categoria);

        }

        private void txt_precio_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }
    }
}
