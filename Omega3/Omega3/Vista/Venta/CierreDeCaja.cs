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
    public partial class CierreDeCaja : Form
    {
        public CierreDeCaja()
        {
            InitializeComponent();
        }

        private void CierreDeCaja_Load(object sender, EventArgs e)
        {

            decimal total;

            txt_vendido.Text=Convert.ToString(Controlador.ControlVentas.Total_Vendido_Hoy());
            txt_reparado.Text = Convert.ToString(Controlador.ControlVentas.Total_Reparado_Hoy());
            txt_retirado.Text = Convert.ToString(Controlador.ControlVentas.Total_Erogaciones_hoy());

            total = ControlVentas.Total_Vendido_Hoy() + ControlVentas.Total_Reparado_Hoy() - ControlVentas.Total_Erogaciones_hoy();

            txt_total.Text = Convert.ToString(total);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
