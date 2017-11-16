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
using Omega3.Modelo;
namespace Omega3.Vista.Reparaciones
{
    public partial class BuscarProducto : Form
    {
        Producto producto = new Producto();
        decimal lista = new decimal();
        Button boton;

        public BuscarProducto()
        {
            InitializeComponent();
        }
        public BuscarProducto(ref Producto producto, Decimal lista, Button boton)
        {
            InitializeComponent();
            this.producto = producto;
            this.lista = lista / 100 + 1;
            this.boton = boton;


        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {

            ControlReparaciones.llenarTablaProducto(dgv_tabla, lista);
            dgv_tabla.Columns[0].DisplayIndex = 4;

            habilitarFiltroProducto("off");
            habilitarFiltroCodigo("off");


        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                producto.Precio_venta = Convert.ToDecimal(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[3].Value);
                producto.Nombre_producto = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[2].Value);
                producto.Cod_producto = long.Parse(Convert.ToString((dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[1].Value)));
                producto.Cantidad = Convert.ToInt32(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[4].Value);
                boton.Enabled = true;
                this.Close();

            }
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {

            if (txt_producto.Tag.ToString() != "off")
            {

                var bd = (BindingSource)dgv_tabla.DataSource;
                var dt = (DataTable)bd.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Producto] like '%{0}%'", txt_producto.Text.Trim().Replace("'", "''"));
                dgv_tabla.Refresh();
            }
        }

        private void txt_producto_Enter(object sender, EventArgs e)
        {
            habilitarFiltroCodigo("off");
            habilitarFiltroProducto("on");

        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {
            if (txt_cod.Tag.ToString() != "off")
            {
                var bd = (BindingSource)dgv_tabla.DataSource;
                var dt = (DataTable)bd.DataSource;
                dt.DefaultView.RowFilter = string.Format("convert(Cod, 'System.String') like '%{0}%'", txt_cod.Text.Trim().Replace("'", "''"));
                dgv_tabla.Refresh();
            }
        }

        private void txt_cod_Enter(object sender, EventArgs e)
        {

            habilitarFiltroProducto("off");
            habilitarFiltroCodigo("on");

        }

        private void habilitarFiltroProducto(string onoff)
        {
            if (onoff == "on")
            {
                txt_producto.Tag = "on";
                txt_producto.ForeColor = Color.Black;
                txt_producto.Text = "";
            }
            else
            {
                txt_producto.Tag = "off";
                txt_producto.Text = "Buscar por Nombre";
                txt_producto.ForeColor = Color.Gray;
            }
        }
        private void habilitarFiltroCodigo(string onoff)
        {
            if (onoff == "on")
            {
                txt_cod.Tag = "on";
                txt_cod.ForeColor = Color.Black;
                txt_cod.Text = "";
            }
            else
            {
                txt_cod.Tag = "off";
                txt_cod.Text = "Buscar por Nombre";
                txt_cod.ForeColor = Color.Gray;
            }

        }
    }
}
