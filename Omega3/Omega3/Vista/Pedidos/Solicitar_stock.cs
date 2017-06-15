using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Vista.Pedidos;
using Omega3.Modelo;
using Omega3.Controlador;

namespace Omega3.Vista.Pedidos
{
    public partial class Solicitar_stock : Form
    {

        public TextBox proveedor { get => txt_proveedor; set => txt_proveedor = value; }

        public Solicitar_stock()
        {
            InitializeComponent();
        }

        private void Solicitar_stock_Load(object sender, EventArgs e)
        {
            //Lleno los datos del datagridview
            Omega3.Controlador.ControlProducto.llenarTabla(dgv_tabla);

            //Renombro los headers de cada columna
            dgv_tabla.Columns[0].HeaderText = "Código";
            dgv_tabla.Columns[1].HeaderText = "Producto";
            dgv_tabla.Columns[2].HeaderText = "Stock";
            dgv_tabla.Columns[3].HeaderText = "Precio de Costo";
            dgv_tabla.Columns[4].HeaderText = "Precio de Venta";
            dgv_tabla.Columns[5].HeaderText = "Stock Mínimo";

            //Hago que solo se pueda seleccionar la fila completa
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Acomodo el tamaño de las cabaceras al tamaño del datagridview

            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);

        }

    private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("producto like '%{0}%'", txt_filtro_nombre.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();

            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);

        }

        private void txt_filtro_codigo_TextChanged(object sender, EventArgs e)
        {

            var bd = (BindingSource)dgv_tabla.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("convert(cod_producto, 'System.String') Like '{0}%' ", txt_filtro_codigo.Text.Trim().Replace("'", "''"));
            dgv_tabla.Refresh();

            Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);

        }

        private void txt_filtro_nombre_Enter(object sender, EventArgs e)
        {
            txt_filtro_codigo.Text = "";
        }

        private void txt_filtro_codigo_Enter(object sender, EventArgs e)
        {
            txt_filtro_nombre.Text = "";

        }

        private void dgv_tabla_SelectionChanged(object sender, EventArgs e)
        {
           if (dgv_tabla.SelectedRows.Count > 0)
           {
                txt_codigo.Text = Convert.ToString(dgv_tabla.CurrentRow.Cells[0].Value);
                txt_producto.Text = Convert.ToString(dgv_tabla.CurrentRow.Cells[1].Value);
                txt_stock.Text = Convert.ToString(dgv_tabla.CurrentRow.Cells[2].Value);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ElegirProveedor proveedor = new ElegirProveedor(this);
            proveedor.StartPosition = FormStartPosition.CenterScreen;
            proveedor.ShowDialog();
            
        }

        private void txt_cantidad_solicitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.ControlProveedor.validarCaracteresNumericos(e);
        }

        private void btn_solicitar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();

            if (txt_cantidad_solicitada.Text == "")
            {
                ControlProveedor.validarTextboxVacio("Cantidad Solicitdad");
            }
            else
            {

                pedido.Id_producto = long.Parse(txt_codigo.Text);
                pedido.Cantidad = Convert.ToInt32(txt_cantidad_solicitada.Text);
                pedido.Fecha_pedido = DateTime.Now;

                if (txt_proveedor.Text != "")
                {
                    pedido.Id_proveedor = long.Parse(txt_proveedor.Text);
                }
            }


            //ControlPedidos.AgregarPedido(a);

        }
    }
}
