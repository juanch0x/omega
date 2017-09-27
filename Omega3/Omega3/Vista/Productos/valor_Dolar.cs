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

namespace Omega3.Vista.Productos
{
    public partial class valor_Dolar : Form
    {
        public valor_Dolar()
        {
            InitializeComponent();
        }

        public valor_Dolar(Decimal sugerido, Decimal guardado)
        {

            InitializeComponent();
            txt_sugerido.Text = sugerido.ToString();
            txt_actual.Text = guardado.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal carlitos = new decimal();

            carlitos = ControlProducto.obtenerValorDolar();
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {

            ControlProducto.modificarDolar(Convert.ToDecimal(txt_nuevo.Text));


        }
    }
}
