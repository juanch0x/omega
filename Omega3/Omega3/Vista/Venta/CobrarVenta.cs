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
using Omega3.Vista;

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
            Modelo.Venta a = new Modelo.Venta();
            a.id = venta.id;
            
            a.nrofactura = long.Parse(txt_factura.Text);
            a.remito = long.Parse(txt_remito.Text);
            if (combo_cobrada.SelectedIndex == 0)
            {
                a.cobrada = true;
            }
            else { a.cobrada = false; }


            if (ControladorFuncVariadas.validarTextBoxVacios(txt_remito, txt_factura))
            {
                if (ControlVentas.ModificarVenta(a) == 1)
                {
                    MessageBox.Show("Se actualizaron los datos correctamente");
                    this.Close();
                }
                else { Console.WriteLine("Error en el update"); }
            }
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

            ControladorPagoParcial.llenar_pagosparciales(dgv_tabla, venta.id);
            calcularTotalPagado();
            calcularTamanio();
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void txt_remito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender,e);
        }

        private void txt_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_agregar_pago_Click(object sender, EventArgs e)
        {
            Vista.PagosParciales.agregarPago a = new PagosParciales.agregarPago(venta.id);
            a.Show();
            

        }
        private void calcularTamanio()
        {
            dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla.Dock = DockStyle.Fill;
        }

        private void calcularTotalPagado()
        {
            int sum = 0;
            for (int i = 0; i < dgv_tabla.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_tabla.Rows[i].Cells["Monto"].Value);
            }
            lbl_total_pagado.Text = sum.ToString();
        }

    }
}
