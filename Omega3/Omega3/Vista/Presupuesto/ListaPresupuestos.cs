using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Presupuesto
{
    public partial class ListaPresupuestos : Form
    {
        public ListaPresupuestos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_llenar_Click(object sender, EventArgs e)
        {


        }

        private void ListaPresupuestos_Load(object sender, EventArgs e)
        {
            Omega3.Controlador.ControlPresupuesto.llenarTabla(dgv_presupuestos);


            dgv_presupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_presupuestos.Columns[0].DisplayIndex = 5;
            

            Omega3.Controlador.ControlPresupuesto.AutoFill(dgv_presupuestos);

        }
    }
}
