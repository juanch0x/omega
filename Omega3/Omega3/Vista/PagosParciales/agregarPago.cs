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

namespace Omega3.Vista.PagosParciales
{
    public partial class agregarPago : Form
    {
        long id_venta;
        public agregarPago()
        {
            InitializeComponent();
        }

        public agregarPago(long id_venta)
        {
            InitializeComponent();
            this.id_venta = id_venta;
        }

        private void agregarPago_Load(object sender, EventArgs e)
        {
            panel_cheque.Visible = false;
            

            ControladorPagoParcial.llenarMedioDePago(combo_medio_de_pago);
            
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender,e);
        }

        private void combo_medio_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_medio_de_pago.Text == "Cheque")
            {
                
                panel_cheque.Visible = true;

            }
            else
            {
                panel_cheque.Visible = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PagoParcial a = new PagoParcial();

            a.id_venta = id_venta;
            a.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
            a.monto = Convert.ToDecimal(txt_monto.Text);
            a.razon_social = txt_razon.Text;
            a.banco = txt_banco.Text;
            a.comprobante = txt_comprobante.Text;
            a.vencimiento = txt_vencimiento.Value;


            if (ControladorPagoParcial.agregarPagoParcial(a)==1)
            {
                MessageBox.Show("El pago se agregó correctamente!");
            }
            else { MessageBox.Show("Hubo un problema");}

            this.Close();

        }

    }
}
