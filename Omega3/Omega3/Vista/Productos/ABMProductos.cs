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
    public partial class ABMProductos : Form
    {
        public ABMProductos()
        {
            InitializeComponent();
        }
        //Se ejecuta cuando se abre el form (lo uso para llenar la tabla)
        private void ModificarProductos_Load(object sender, EventArgs e)
        {
            //Lleno los datos del datagridview
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);

            //Renombro los headers de cada columna
            dgv_tabla.Columns[0].HeaderText = "Código";
            dgv_tabla.Columns[1].HeaderText = "Producto";
            dgv_tabla.Columns[2].HeaderText = "Stock";
            dgv_tabla.Columns[3].HeaderText = "Precio de Costo";
            dgv_tabla.Columns[4].HeaderText = "Stock Mínimo";
            dgv_tabla.Columns[5].HeaderText = "Categoría";

            //Hago que solo se pueda seleccionar la fila completa
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //Acomodo el tamaño de las cabaceras al tamaño del datagridview
            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);



        }
        //Filtro para el nombre del Producto
        private void filtro_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("producto like '%{0}%'", txt_filtro_nombre.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);


        }
        //Filtro para el Codigo de Barras
        private void txt_filtro_codigo_TextChanged(object sender, EventArgs e)
        {


            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("convert(cod_producto, 'System.String') Like '{0}%' ", txt_filtro_codigo.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();
            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);

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
                txt_filtro_nombre.Text = "";
                MessageBox.Show("El producto se eliminó correctamente.");
            }   
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Vista.Productos.AgregarProducto agregarProducto = new Vista.Productos.AgregarProducto();
            agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            agregarProducto.ShowDialog();
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);

            txt_filtro_nombre.Text = "";
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Producto producto = new Modelo.Producto();
            producto.Cod_producto = long.Parse(Convert.ToString(dgv_tabla.CurrentRow.Cells[0].Value));
            producto.Nombre_producto = Convert.ToString(dgv_tabla.CurrentRow.Cells[1].Value);
            producto.Cantidad = Convert.ToInt32(Convert.ToString(dgv_tabla.CurrentRow.Cells[2].Value));
            producto.Precio_costo = Convert.ToDecimal(Convert.ToString(dgv_tabla.CurrentRow.Cells[3].Value));
            producto.Stock_minimo = Convert.ToInt32(Convert.ToString(dgv_tabla.CurrentRow.Cells[4].Value));
            producto.Dolar = 1;

            Omega3.Vista.Productos.ModificarProducto modificarproducto = new ModificarProducto(producto);
            modificarproducto.StartPosition = FormStartPosition.CenterScreen;
            modificarproducto.ShowDialog();
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);
            txt_filtro_nombre.Text = "";

        }

        //Valido que solo se ingresen numeros en el Filtro del Codigo
        private void txt_filtro_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
                
            }
        }
        //Valido que en el filtro de producto solo se puedan ingresar letras y numeros.
        
        private void txt_filtro_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            { 
                e.Handled = true;
                return;

            }
        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
                foreach (DataGridViewRow Myrow in dgv_tabla.Rows)
                {            //Here 2 cell is target value and 1 cell is Volume
                    if (Convert.ToInt32(Myrow.Cells[2].Value) < Convert.ToInt32(Myrow.Cells[4].Value))// Or your condition 
                    {
                    
                    Myrow.Cells[2].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5D846");
                    Myrow.Cells[2].Style.ForeColor = Color.Black;
                }
                    else
                    {
                    
                    Myrow.Cells[2].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#C5F6B4");

                }
                }

                               


        }

        private void txt_filtro_nombre_Enter(object sender, EventArgs e)
        {
            txt_filtro_codigo.Text = "";
        }

        private void txt_filtro_codigo_Enter(object sender, EventArgs e)
        {
            txt_filtro_nombre.Text = "";
        }

        private void ABMProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ABMProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
