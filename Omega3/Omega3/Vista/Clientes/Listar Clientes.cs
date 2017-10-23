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
namespace Omega3.Vista.Clientes
{
    public partial class Listar_Clientes : Form
    {
        public Listar_Clientes()
        {
            InitializeComponent();
            ControlCliente.ListarClientes(dgv_tabla);
            //6
            dgv_tabla.Columns["Editar"].DisplayIndex = 6;
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                Cliente cliente = new Cliente();
                cliente.Documento = long.Parse(Convert.ToString(((dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells["Documento"].Value))));

                Modificar_Cliente b = new Modificar_Cliente(cliente);
                b.ShowDialog();

                

            }
        }
    }
}
