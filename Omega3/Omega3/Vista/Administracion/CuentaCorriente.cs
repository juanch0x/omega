using Omega3.Controlador;
using Omega3.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Administracion
{
    public partial class CuentaCorriente : Form
    {
        public CuentaCorriente()
        {
            InitializeComponent();
        }

        private void CuentaCorriente_Load(object sender, EventArgs e)
        {
            lbl_dni.Text = "";
            lbl_deuda.Text = "";
            lbl_comprado.Text = "";
            lbl_pagado.Text = "";

            ControlVenta.llenarClientes(combo_cliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (combo_cliente.SelectedIndex != -1)
            {
                cliente = ControlVentas.obtenerCliente(combo_cliente.Text);

                Deuda deuda = ControlAdministracion.obtenerDeudas(cliente.Documento);
                lbl_dni.Text = cliente.Razon;
                lbl_comprado.Text = deuda.total_comprado;
                lbl_pagado.Text = deuda.total_pagado;
                lbl_deuda.Text = deuda.deuda;

            }
            else
            {
                MessageBox.Show("No hay ningún cliente valido seleccionado.");
            }
            
        }

        private void btn_buscar_cuit_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            if (ControlCliente.validardocumento(long.Parse(buscar_cuit.Text)))
                {
                    cliente = ControlVentas.obtenerCliente(long.Parse(buscar_cuit.Text));

                    Deuda deuda = ControlAdministracion.obtenerDeudas(cliente.Documento);
                lbl_dni.Text = cliente.Razon;
                lbl_comprado.Text = deuda.total_comprado;
                lbl_pagado.Text = deuda.total_pagado;
                lbl_deuda.Text = deuda.deuda;

            }
            else
            {
        MessageBox.Show("El documento " + buscar_cuit.Text + " no corresponde a ningún cliente.");
        //iniciarBusquedaCuit();
        buscar_cuit.Focus();
    }

            
            

        }

        private void buscar_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumericos(e);
        }
    }
}
