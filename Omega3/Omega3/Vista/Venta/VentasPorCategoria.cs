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

namespace Omega3.Vista.Venta
{
    public partial class VentasPorCategoria : Form
    {
        public VentasPorCategoria()
        {
            InitializeComponent();
            construirTabla();
        }
        public void construirTabla()
        {
            var categoria = new DataGridViewTextBoxColumn();
            var preciocompra = new DataGridViewTextBoxColumn();
            var precioventa = new DataGridViewTextBoxColumn();



            categoria.HeaderText = "Categoria";
            categoria.Name = "Categoria";
            categoria.DataPropertyName = "Categoria";
            categoria.ReadOnly = true;

            preciocompra.Name = "Precio Compra";
            preciocompra.HeaderText = "Precio Compra";
            preciocompra.DataPropertyName = "Precio Compra";
            preciocompra.ReadOnly = true;

            precioventa.HeaderText = "Precio Venta";
            precioventa.Name = "Precio Venta";
            precioventa.DataPropertyName = "Precio Venta";
            precioventa.ReadOnly = true;


            String query = "SELECT categoria_producto.categoria as 'Categoria',sum(round(subtotal, 2)) as 'Precio Venta',sum(round(if (productos.dolar = 0,productos.precio_compra* detalle_venta.cantidad,productos.precio_compra * (select valor from valor_dolar where id = 1) *detalle_venta.cantidad),2)) as 'Precio Compra'FROM detalle_venta INNER JOIN productos on detalle_venta.codigo = productos.cod_producto INNER JOIN categoria_producto on productos.id_categoria = categoria_producto.id GROUP BY productos.id_categoria";

            ControlVentas.llenarVentasPorCategoria(dgv_tabla, query);
        }


        private void VentasPorCategoria_Load(object sender, EventArgs e)
        {

           
        }
    }
}
