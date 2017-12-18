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

namespace Omega3.Vista.Productos
{
    public partial class ListaPrecios : Form
    {
        int listaprecio;
        public ListaPrecios(int listaprecio)
        {
            InitializeComponent();
            this.listaprecio = listaprecio;
            construirTabla();
        }


        public void construirTabla()
        {

            var cod_producto = new DataGridViewTextBoxColumn();
            var producto = new DataGridViewTextBoxColumn();
            var categoria = new DataGridViewTextBoxColumn();
            var precio = new DataGridViewTextBoxColumn();

            cod_producto.HeaderText = "Cod Producto";
            cod_producto.Name = "Cod Producto";
            cod_producto.DataPropertyName = "Cod Producto";
            cod_producto.ReadOnly = true;

            producto.Name = "Producto";
            producto.HeaderText = "Producto";
            producto.DataPropertyName = "Producto";
            producto.ReadOnly = true;

            categoria.HeaderText = "Categoria";
            //categoria.Name = "Categoria;
            categoria.Name = "Categoria";
            categoria.DataPropertyName = "Categoria";
            categoria.ReadOnly = true;

            precio.HeaderText = "Precio";
            precio.Name = "Precio";
            precio.DataPropertyName = "Precio";
            precio.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cod_producto, producto, categoria,precio  });



            string query = "SELECT cod_producto AS 'Cod Producto', producto as Producto, precio_compra * (SELECT	valor from markup where id= " + listaprecio + ") as Precio, categoria as 'Categoria' FROM productos LEFT JOIN categoria_producto on productos.id_categoria = categoria_producto.id ";
            ControlCliente.llenarListaClienteExcel(dgv_tabla, query);
        }


    }
}
