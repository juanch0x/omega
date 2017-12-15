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
    public partial class modificarcompra : Form
    {
        long id;
        public modificarcompra(long id)
        {
            InitializeComponent();
            this.id = id;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Modelo.ComprasaProveedores compras = new Modelo.ComprasaProveedores();

            compras.Id = id;
            compras.Proveedor = txt_proveedor.Text;
            compras.Motivo = txt_motivo.Text;
            compras.Vencimiento = txt_fecha.Value;
            compras.Monto = Convert.ToDecimal(txt_monto.Text);
            compras.Comprobante = txt_comprobante.Text;
            compras.Iva = Convert.ToDecimal(txt_iva.Text);
            compras.Razon = txt_razon.Text;
            compras.Detalle = txt_detalle.Text;
            if (radio_pagado.Checked==true)
            {
                compras.Pagada = true;
                compras.Fechapago = DateTime.Now;
            }
            else if(radio_no_pagado.Checked == true){

                compras.Pagada = false;

            }

            if(Controlador.ControlCompras.modificarCompra(compras) == 1)
            {

                MessageBox.Show("La compra se modifico correctamente");
                this.Close();

            }
            else
            {
                MessageBox.Show("Ocurrio un problema al insertar la modificacion");
            }

        }

        private void modificarcompra_Load(object sender, EventArgs e)
        {
            Modelo.ComprasaProveedores compra = new Modelo.ComprasaProveedores();
            compra = Omega3.Controlador.ControlCompras.modificarCompra(id);
            txt_proveedor.Text = compra.Proveedor;
            txt_motivo.Text = compra.Motivo;
            txt_fecha.Value = compra.Vencimiento;
            txt_monto.Text  = Convert.ToString(compra.Monto);
            txt_comprobante.Text = compra.Comprobante;
            txt_iva.Text = Convert.ToString(compra.Iva);
            txt_razon.Text = compra.Razon;
            txt_detalle.Text = compra.Detalle;

            if (compra.Pagada)
            {
                radio_pagado.Checked = true;

            }
            else
            {
                radio_no_pagado.Checked = true;
            }







        }
    }
}
