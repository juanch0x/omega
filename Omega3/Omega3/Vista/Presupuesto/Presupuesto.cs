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
namespace Omega3.Vista.Presupuesto

{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ControlPresupuesto.FillDgv();

            dataGridView1.AutoGenerateColumns = false;
      


            dataGridView1.Columns[0].DataPropertyName = "Numero";
            dataGridView1.Columns[1].DataPropertyName = "Cod";
            dataGridView1.Columns[2].DataPropertyName = "Descripcion";
            dataGridView1.Columns[3].DataPropertyName = "Cantidad";
            dataGridView1.Columns[4].DataPropertyName = "Precio";
            dataGridView1.Columns[5].DataPropertyName = "Importe";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ControlPresupuesto.InvoiceGenerate(dataGridView1);

        }
    }
}
