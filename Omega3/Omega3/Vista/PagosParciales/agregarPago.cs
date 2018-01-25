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
        decimal total_venta;
        decimal total_pagado;
        public agregarPago()
        {
            InitializeComponent();
        }

        public agregarPago(long id_venta,decimal total_venta,decimal total_pagado)
        {
            InitializeComponent();
            this.id_venta = id_venta;
            this.total_venta = total_venta;
            this.total_pagado = total_pagado;
        }

        private void agregarPago_Load(object sender, EventArgs e)
        {
            panel_cheque.Enabled = false;
            panel_transferencia.Enabled = false;
            txt_monto.MaxLength = 9;

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


                panel_transferencia.Enabled = true;
                panel_cheque.Enabled = true;
                
            }
            else if(combo_medio_de_pago.Text == "Efectivo")
            {
                panel_cheque.Enabled = false;
                panel_transferencia.Enabled = false;
             
                foreach(Control txt in panel_cheque.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if(txt is TextBox)
                    {
                        txt.Text = "";
                    }
                }

                foreach (Control txt in panel_transferencia.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (txt is TextBox)
                    {
                        txt.Text = "";
                    }
                }



            }
            else
            {
                panel_cheque.Enabled = false;
                panel_transferencia.Enabled = true;

                foreach (Control txt in panel_cheque.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    if (txt is TextBox)
                    {
                        txt.Text = "";
                    }
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PagoParcial a = new PagoParcial();
            
            if (txt_monto.Text.Trim() == "" || !string.IsNullOrEmpty(txt_monto.Text)){


                a.id_venta = id_venta;
                a.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
                a.monto = Convert.ToDecimal(txt_monto.Text);
                
                    a.razon_social = txt_razon.Text;
                
                
                a.banco = txt_banco.Text;
                a.comprobante = txt_comprobante.Text;
                a.vencimiento = txt_vencimiento.Value;
                if(txt_recibo.Text.Trim()!="" || !string.IsNullOrEmpty(txt_recibo.Text))
                a.recibo = txt_recibo.Text;
                if(txt_retencion_iva.Text.Trim()!="" || !string.IsNullOrEmpty(txt_retencion_iva.Text))
                a.retencion_iva = Convert.ToDecimal(txt_retencion_iva.Text);
                if(txt_retencion_ig.Text.Trim() !="" || !string.IsNullOrEmpty(txt_retencion_ig.Text))
                a.retencion_ig = Convert.ToDecimal(txt_retencion_ig.Text);
                if(txt_retencion_iibb.Text.Trim() != "" || !string.IsNullOrEmpty(txt_retencion_iibb.Text))
                a.retencion_iibb = Convert.ToDecimal(txt_retencion_iibb.Text);
                if(txt_retencion_suss.Text.Trim() != "" || !string.IsNullOrEmpty(txt_retencion_suss.Text))
                a.retencion_suss = Convert.ToDecimal(txt_retencion_suss.Text);


                if (total_venta >= (total_pagado + a.monto)) {


                    if (ControladorPagoParcial.agregarPagoParcial(a) == 1)
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

        private void txt_retencion_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_retencion_ig_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_retencion_iibb_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_retencion_suss_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }
    }
}
