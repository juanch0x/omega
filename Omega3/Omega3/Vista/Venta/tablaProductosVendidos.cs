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
    public partial class tablaProductosVendidos : Form
    {
        DateTime inicio, fin;
        public tablaProductosVendidos(DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.fin = fin;
        }

        public void construirTabla()
        {
            var producto = new DataGridViewTextBoxColumn();
            var codigo = new DataGridViewTextBoxColumn();
            var cantidad = new DataGridViewTextBoxColumn();
            var preciocompra = new DataGridViewTextBoxColumn();
            var precioventa = new DataGridViewTextBoxColumn();
            var total = new DataGridViewTextBoxColumn();



            producto.HeaderText = "Producto";
            producto.Name = "Producto";
            producto.DataPropertyName = "Producto";
            producto.ReadOnly = true;

            codigo.Name = "Codigo";
            codigo.HeaderText = "Codigo";
            codigo.DataPropertyName = "Codigo";
            codigo.ReadOnly = true;

            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "Cantidad";
            cantidad.DataPropertyName = "Cantidad";
            cantidad.ReadOnly = true;

            preciocompra.HeaderText = "Precio Compra";
            preciocompra.Name = "Precio Compra";
            preciocompra.DataPropertyName = "Precio Compra";
            preciocompra.ReadOnly = true;

            precioventa.HeaderText = "Precio Venta";
            precioventa.Name = "Precio Venta";
            precioventa.DataPropertyName = "Precio Venta";
            precioventa.ReadOnly = true;

            total.HeaderText = "Total";
            total.Name = "Total";
            total.DataPropertyName = "Total";
            total.ReadOnly = true;


            String query = "SELECT productos.producto as 'Producto',productos.cod_producto as 'Codigo',detalle_venta.cantidad as 'Cantidad',productos.precio_compra as 'Precio Compra',detalle_venta.subtotal / detalle_venta.cantidad as 'Precio Venta',detalle_venta.subtotal as 'Total',date(venta.fecha_venta) FROM detalle_venta INNER JOIN productos on detalle_venta.codigo = productos.cod_producto INNER JOIN venta on detalle_venta.id_venta = venta.id WHERE  date(venta.fecha_venta) BETWEEN" + inicio.Date + "and" + fin.Date +"";

            ControlVentas.llenarVentasPorCategoria(dgv_tabla, query);
        }
    }
}
