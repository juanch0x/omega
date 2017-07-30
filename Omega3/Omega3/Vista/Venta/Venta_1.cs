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

namespace Omega3.Vista.Venta
{
    public partial class Venta_1 : Form
    {
        public Venta_1()
        {
            InitializeComponent();
        }

        private void Venta_1_Load(object sender, EventArgs e)
        {
            
            ControlVentas.llenarMedios_de_Pago(combo_pago);

            ControlVenta.llenarClientes(combo_cliente);

            filtro_cuit.Text = "Buscar por CUIT o DNI";
            filtro_cuit.ForeColor = Color.Gray;

            //DGV TABLA


        }


        private void button1_Click(object sender, EventArgs e)
        {
            ControlVenta control = new ControlVenta();
            control.Venta();
        }


        private void filtro_cuit_Leave(object sender, EventArgs e)
        {
            if (filtro_cuit.Text == "")
            {
                filtro_cuit.Text = "Buscar por CUIT o DNI";
                filtro_cuit.ForeColor = Color.Gray;
            }
        }

        private void filtro_cuit_Enter(object sender, EventArgs e)
        {
            if (filtro_cuit.Text == "Buscar por CUIT o DNI")
            {
                filtro_cuit.Text = "";
                filtro_cuit.ForeColor = Color.Black;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Cliente a = new Cliente();
            a = ControlVentas.obtenerCliente(long.Parse(filtro_cuit.Text));

            razon.Text = a.Razon;
            domicilio.Text = a.Direccion;
            iva.Text = a.Impositiva;
            email.Text = a.Mail_contacto;
            cuit.Text = Convert.ToString(a.Documento);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_principal.SelectedIndex = 1;
        }

        private void tab_venta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            dgv_tabla.Rows.Add(txt_ventas_cantidad.Text,txt_ventas_codigo.Text,txt_ventas_descripcion.Text,txt_ventas_precio.Text,txt_ventas_lista.Text,txt_ventas_iva.Text,txt_ventas_subtotal.Text);
                        
        }
    }
}
