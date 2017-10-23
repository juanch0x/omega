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
            txt_actual.Tag = "Dolar";
            txt_sugerido.Text = "0";
            txt_actual.Text = Convert.ToString(ControlProducto.obtenerValorDolar());


        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal carlitos = new decimal();

            carlitos = ControlProducto.obtenerValorDolar();
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            if (ControladorFuncVariadas.validarTextBoxVacios(txt_nuevo))
            {
                if (ControlProducto.modificarDolar(Convert.ToDecimal(txt_nuevo.Text)) == 1)
                {
                    MessageBox.Show("Se modificó correctamente!");
                    this.Close();
                }
                else { MessageBox.Show("Hubo un problema.."); }
            }
            

        }

        private void txt_nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }
    }
}
