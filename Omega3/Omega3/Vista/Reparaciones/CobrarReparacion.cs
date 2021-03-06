﻿using System;
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
    public partial class CobrarReparacion : Form
    {

        Modelo.Reparacion reparacion = new Modelo.Reparacion();
        decimal total_venta = new decimal(0);
        decimal total_pagado = new decimal(0);
        bool modificar = false;

        public CobrarReparacion(Modelo.Reparacion reparacion,decimal total)
        {
            InitializeComponent();
            this.reparacion = reparacion;
            this.total_venta = total;
        }

        private void CobrarReparacion_Load(object sender, EventArgs e)
        {
            {
                if (reparacion.cobrada)
                {
                    combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("Si");
                }
                else { combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("No"); }

                txt_factura.Text = Convert.ToString(reparacion.nro_factura);
                txt_remito.Text = Convert.ToString(reparacion.remito);

                //ControladorPagoParcial.llenar_pagosparciales(dgv_tabla, reparacion.id,reparacion.id);
                ControladorPagoParcial.llenarTablaPagosParciales(dgv_tabla, reparacion.id, reparacion.id);
                calcularTotalPagado();
                calcularTamanio();
                calcularEstado();

                this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            Modelo.Reparacion a = new Modelo.Reparacion();
            a.id = reparacion.id;

            a.nro_factura = txt_factura.Text;
            a.remito = long.Parse(txt_remito.Text);
            if (combo_cobrada.SelectedIndex == 0)
            {
                a.cobrada = true;
            }
            else { a.cobrada = false; }


            if (ControladorFuncVariadas.validarTextBoxVacios(txt_remito, txt_factura))
            {
                if (ControlReparaciones.ModificarReparacionCobro(a) == 1)
                {
                    MessageBox.Show("Se actualizaron los datos correctamente");
                    modificar = true;
                    this.Close();
                }
                else { Console.WriteLine("Error en el update"); }
            }
        }
        private void calcularTamanio() {
                dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_tabla.Dock = DockStyle.Fill;
         }

        private void calcularTotalPagado()
        {
            decimal sum = 0;
            for (int i = 0; i < dgv_tabla.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgv_tabla.Rows[i].Cells["Monto"].Value);
            }

            total_pagado = sum;

            lbl_total_pagado.Text = "Total pagado " + sum.ToString();

            lbl_total_venta.Text = "Total de la venta " + Convert.ToString(total_venta);

            decimal deuda = new decimal(0);

            deuda = total_venta - total_pagado;

            lbl_deuda.Text = "Debe " + deuda;

            decimal porcentaje = deuda * 100 / total_venta;

            colorDeuda(porcentaje);



        }

        private void colorDeuda(decimal porcentaje)
        {
            if (porcentaje == 0)
            {
                lbl_deuda.ForeColor = Color.Green;
                btn_agregar_pago.Enabled = false;
            }
            else if (porcentaje > 0 && porcentaje < 50)
            {
                lbl_deuda.ForeColor = Color.Orange;
                btn_agregar_pago.Enabled = true;
            }
            else
            {
                lbl_deuda.ForeColor = Color.Red;
                btn_agregar_pago.Enabled = true;
            }
        }

        private void calcularEstado()
        {
            if (total_pagado == total_venta)
            {
                combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("Si");
            }
            else { combo_cobrada.SelectedIndex = combo_cobrada.FindStringExact("No"); }
        }

        private void btn_agregar_pago_Click(object sender, EventArgs e)
        {
            PagosParciales.agregarPagoParcialReparacion a = new PagosParciales.agregarPagoParcialReparacion(reparacion.id,total_venta,total_pagado, reparacion.documento);
            a.ShowDialog();
            ControladorPagoParcial.llenar_pagosparciales(dgv_tabla, reparacion.id, reparacion.id);
            calcularTotalPagado();
            calcularEstado();

        }

        private void CobrarReparacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modificar();
        }
    }
}
