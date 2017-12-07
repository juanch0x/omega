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

namespace Omega3.Vista.Reparaciones
{
    public partial class ManoDeObra : Form
    {
        DataGridView tabla_reparaciones;

        public ManoDeObra( DataGridView tabla_reparaciones )
        {
            InitializeComponent();
            limpiarCampos();
            this.tabla_reparaciones = tabla_reparaciones;
            txt_descuento.Text = "0";
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void limpiarCampos()
        {
            txt_precio.Text = "";
            txt_descuento.Text = "";
            combo_iva.SelectedIndex = combo_iva.FindStringExact("21");

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //decimal subtotal = new decimal(0);
            decimal precio = new decimal(0);
            if (validarCampos())
            {
                precio = Convert.ToDecimal(txt_precio.Text);
                precio = precio - (precio * Convert.ToDecimal(txt_descuento.Text) / 100);
                precio = precio * (Convert.ToDecimal(combo_iva.Text) / 100 + 1);

                tabla_reparaciones.Rows.Add(1, "R", "Mano de Obra", txt_precio.Text, combo_iva.Text, txt_descuento.Text, precio, null,true);

                this.Close();
            }
        }

        private Boolean validarCampos()
        {
            if(txt_precio.Text.Trim() == "")
            {
                MessageBox.Show("El precio es obligatorio");
                return false;
            }
            else if(txt_descuento.Text.Trim() == "")
            {
                MessageBox.Show("El descuento es obligatorio");
                return false;
            }
            return true;
        }


    }
}
