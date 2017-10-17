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

        public BuscarProducto()
        {
            InitializeComponent();
        }
        public BuscarProducto(ref Producto producto, Decimal lista)
        {
            InitializeComponent();
            this.producto = producto;
            this.lista = lista / 100 + 1;
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
           
            ControlReparaciones.llenarTablaProducto(dgv_tabla,lista);
            
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                
                producto.Precio_venta = Convert.ToDecimal(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[3].Value);
                producto.Nombre_producto = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[2].Value);
                producto.Cod_producto = long.Parse(Convert.ToString((dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[1].Value)));
                producto.Cantidad = Convert.ToInt32(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[4].Value);
                this.Close();

            }
        }
    }
}
