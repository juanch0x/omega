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

namespace Omega3.Vista.Pedidos
{
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            
                //Lleno los datos del datagridview
                ControlPedidos.llenarTabla(dataGridView1);

                //Renombro los headers de cada columna
                //dgv_tabla.Columns[0].HeaderText = "Código";
                //dgv_tabla.Columns[1].HeaderText = "Producto";
                //dgv_tabla.Columns[2].HeaderText = "Stock";
                //dgv_tabla.Columns[3].HeaderText = "Precio de Costo";
                //dgv_tabla.Columns[4].HeaderText = "Precio de Venta";
                //dgv_tabla.Columns[5].HeaderText = "Stock Mínimo";

                //Hago que solo se pueda seleccionar la fila completa
                dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //Acomodo el tamaño de las cabaceras al tamaño del datagridview

               // Omega3.Controlador.ControlProducto.AutoFill(dgv_tabla);

            
        }
    }
}
