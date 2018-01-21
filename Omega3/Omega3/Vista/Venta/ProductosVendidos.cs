using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Venta
{
    public partial class ProductosVendidos : Form
    {
        public ProductosVendidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vista.Venta.tablaProductosVendidos tablavendidos;

            tablavendidos = new tablaProductosVendidos(date_inicio.Value, date_fin.Value);

            //tablavendidos.Show();

            this.Close();

                       


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
