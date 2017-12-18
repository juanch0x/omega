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
    public partial class agregarPagoParcialReparacion : Form
    {
      long id_reparacion;
      decimal total_venta;
      decimal total_pagado;
        public agregarPagoParcialReparacion(long id_venta, decimal total_venta, decimal total_pagado)
        {
            InitializeComponent();
            this.id_reparacion = id_venta;
            this.total_venta = total_venta;
            this.total_pagado = total_pagado;
        }

        private void agregarPagoParcialReparacion_Load(object sender, EventArgs e)
        {
            panel_cheque.Enabled = false;
            txt_monto.MaxLength = 9;

            ControladorPagoParcial.llenarMedioDePago(combo_medio_de_pago);
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void combo_medio_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_medio_de_pago.Text == "Cheque")
            {



                panel_cheque.Enabled = true;

            }
            else
            {
                panel_cheque.Enabled = false;



            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PagoParcial a = new PagoParcial();

            if (txt_monto.Text.Trim() == "" || !string.IsNullOrEmpty(txt_monto.Text))
            {


                a.id_reparacion = id_reparacion;
                a.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
                a.monto = Convert.ToDecimal(txt_monto.Text);
                a.razon_social = txt_razon.Text;
                a.banco = txt_banco.Text;
                a.comprobante = txt_comprobante.Text;
                a.vencimiento = txt_vencimiento.Value;
                a.recibo = txt_recibo.Text;


                if (total_venta >= (total_pagado + a.monto))
                {


                    if (ControladorPagoParcial.agregarPagoParcialReparacion(a) == 1)
                    {
                        MessageBox.Show("El pago se agregó correctamente!");
                        this.Close();
                    }
                    else { MessageBox.Show("Hubo un problema"); }
                }
                else
                {
                    MessageBox.Show("El monto agregado supera el monto de deuda de esta factura");
                }
            }
            else MessageBox.Show("El campo monto es obligatorio");


        }
    }
}
