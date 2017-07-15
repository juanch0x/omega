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
    public partial class Venta_1 : Form
    {
        public Venta_1()
        {
            InitializeComponent();
        }

        private void Venta_1_Load(object sender, EventArgs e)
        {
            ControlVentas.llenarCondicion(combo_condicion);
            ControlVentas.llenarMedios_de_Pago(combo_pago);
        }

        private void combo_condicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlVentas.llenarFacturas(combo_tipo_factura, Convert.ToInt32(combo_condicion.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlVenta control = new ControlVenta();
            control.Venta();
        }
    }
}
