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

namespace Omega3.Vista.Administracion
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }


        private void Compras_Load(object sender, EventArgs e)
        {

            txt_monto.MaxLength = 9;

        }



        private void btn_crear_Click(object sender, EventArgs e)
        {

            
            ComprasaProveedores compras = new ComprasaProveedores();
            compras.Pagada = false;
            if (radio_pagado.Checked)
            {
                compras.Pagada = true;
            }
     

            

            
            compras.Proveedor = txt_proveedor.Text;
            compras.Motivo = txt_motivo.Text;
            compras.Vencimiento = txt_fecha.Value;
            compras.Monto = Convert.ToDecimal(txt_monto.Text);
            compras.Detalle = txt_detalle.Text;

            compras.Comprobante = txt_comprobante.Text;
            compras.Iva = Convert.ToDecimal(txt_iva.Text);
            compras.Razon = txt_razon.Text;

            Omega3.Controlador.ControlCompras.Insertarnuevacompra(compras);
            
            

        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender,e);
        }

    
    }
}
