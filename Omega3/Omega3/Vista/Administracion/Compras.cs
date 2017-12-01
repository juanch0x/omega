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

namespace Omega3.Vista.Administracion
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

            bool aux;

            if(txt_pagada.Text == "pagada"){
                aux = 1;
            }
            else
            {
                aux = 0;
            }

            ComprasaProveedores compras = new ComprasaProveedores();

            compras.Proveedor = txt_proveedor.Text;
            compras.Motivo = txt_motivo.Text;
            compras.Vencimiento = txt_fecha.Value;
            compras.Monto = Convert.ToDecimal(txt_monto.Text);
            compras.Pagada = aux;
            compras.Detalle = txt_detalle.Text;

        }
    }
}
