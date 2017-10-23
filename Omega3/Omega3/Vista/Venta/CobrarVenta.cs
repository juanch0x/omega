using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
using Omega3.Controlador;

namespace Omega3.Vista.Venta
{
    public partial class CobrarVenta : Form
    {
        Modelo.Venta venta = new Modelo.Venta();
        public CobrarVenta(Modelo.Venta venta)
        {
            InitializeComponent();
            this.venta = venta;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void CobrarVenta_Load(object sender, EventArgs e)
        {
            if (venta.cobrada)
            {
                combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("Si");
            }
            else { combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("No"); }

            txt_factura.Text = Convert.ToString(venta.nrofactura);
            txt_remito.Text = Convert.ToString(venta.remito);

        }
    }
}
