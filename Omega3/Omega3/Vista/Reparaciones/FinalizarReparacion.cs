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

namespace Omega3.Vista.Reparaciones
{
    public partial class FinalizarReparacion : Form
    {
        Cliente cliente;
        decimal total = new decimal();
        DataGridView dgv_tabla;
        public FinalizarReparacion(Cliente cliente, decimal total,DataGridView dgv_tabla)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.total = total;
            this.dgv_tabla = dgv_tabla;
        }

        private void FinalizarReparacion_Load(object sender, EventArgs e)
        {
            lbl_cliente.Text = cliente.Razon;
            lbl_dni.Text = Convert.ToString(cliente.Documento);
            lbl_email.Text = cliente.Mail_contacto;
            lbl_telefono.Text = Convert.ToString(cliente.Telefono);
            lbl_total.Text = Convert.ToString(total);
            ControlVentas.llenarComboComprobante(combo_comprobante, cliente.Impositiva_Id);
            ControlVentas.llenarMedios_de_Pago(combo_medio_de_pago);
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {

            Modelo.Venta venta = new Modelo.Venta();
            venta.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
            venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
            ControlVenta facturar = new ControlVenta();
            facturar.FacturarReparacion(venta, cliente, dgv_tabla);

        }
    }
}
