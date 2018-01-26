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
        Modelo.ComprasaProveedores compra = new Modelo.ComprasaProveedores();

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


            if (Omega3.Controlador.ControladorFuncVariadas.validarTextBoxVacios(txt_proveedor, txt_motivo, txt_monto, txt_detalle, txt_comprobante, txt_iva, txt_razon, iva10, nogravado, percepcioniva, percepcioniibb))
            {

                compras.Id = id;
                compras.Proveedor = txt_proveedor.Text;
                compras.Motivo = txt_motivo.Text;
                compras.Vencimiento = txt_fecha.Value;
                compras.Monto = Convert.ToDecimal(txt_monto.Text);
                compras.Comprobante = txt_comprobante.Text;
                compras.Iva = Convert.ToDecimal(txt_iva.Text);
                compras.Razon = txt_razon.Text;
                compras.Detalle = txt_detalle.Text;
                compras.Fechapago = compra.Fechapago;
                compras.Iva10 = Convert.ToDecimal(iva10.Text);
                compras.Nogravado = Convert.ToDecimal(nogravado.Text);
                compras.Percepcioniva = Convert.ToDecimal(percepcioniva.Text);
                compras.Percepcioniibb = Convert.ToDecimal(percepcioniibb.Text);
                if (radio_pagado.Checked == true)
                {
                    compras.Pagada = true;
                    //compras.Fechapago = DateTime.Now;
                }
                else if (radio_no_pagado.Checked == true)
                {

                    compras.Pagada = false;

                }


                if (Controlador.ControlCompras.modificarCompra(compras) == 1)
                {

                    MessageBox.Show("La compra se modifico correctamente");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al insertar la modificacion");
                }
            }
        }

        private void modificarcompra_Load(object sender, EventArgs e)
        {
            compra = Omega3.Controlador.ControlCompras.modificarCompra(id);
            txt_proveedor.Text = compra.Proveedor;
            txt_motivo.Text = compra.Motivo;
            txt_fecha.Value = compra.Vencimiento;
            txt_monto.Text  = Convert.ToString(compra.Monto);
            txt_comprobante.Text = compra.Comprobante;
            txt_iva.Text = Convert.ToString(compra.Iva);
            txt_razon.Text = compra.Razon;
            txt_detalle.Text = compra.Detalle;
            iva10.Text = Convert.ToString(compra.Iva10);
            percepcioniva.Text = Convert.ToString(compra.Percepcioniva);
            percepcioniibb.Text = Convert.ToString(compra.Percepcioniibb);
            nogravado.Text = Convert.ToString(compra.Nogravado);

            if (compra.Pagada)
            {
                radio_pagado.Checked = true;

            }
            else
            {
                radio_no_pagado.Checked = true;
            }







        }

        private void txt_monto_TextChanged(object sender, EventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void iva10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void nogravado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void percepcioniva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void percepcioniibb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }
    }
}
