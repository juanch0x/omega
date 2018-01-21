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
            DateTime fechaini = date_inicio.Value;
            //MessageBox.Show(Convert.tostring(select convert(date,date_inicio)));
            MessageBox.Show(Convert.ToString(fechaini.ToUniversalTime()));
            Vista.Venta.tablaProductosVendidos tablavendidos;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("tablaProductosVendidos"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                tablavendidos = new Vista.Venta.tablaProductosVendidos(date_inicio.Value, date_fin.Value);
                tablavendidos.StartPosition = FormStartPosition.CenterScreen;
                tablavendidos.Show();
                this.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
