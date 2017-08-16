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
namespace Omega3.Vista.Presupuesto

{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();

            fecha_pago.Visible = false;
            txt_ventas_cantidad.Text = "1";
            txt_ventas_iva.Text = "21";
            txt_ventas_lista.Text = "10";

        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ControlPresupuesto.FillDgv();

            dataGridView1.AutoGenerateColumns = false;
      
            dataGridView1.Columns[0].DataPropertyName = "Numero";
            dataGridView1.Columns[1].DataPropertyName = "Cod";
            dataGridView1.Columns[2].DataPropertyName = "Descripcion";
            dataGridView1.Columns[3].DataPropertyName = "Cantidad";
            dataGridView1.Columns[4].DataPropertyName = "Precio";
            dataGridView1.Columns[5].DataPropertyName = "Importe";

            ControlVentas.llenarMedios_de_Pago(combo_pago);

            ControlVenta.llenarClientes(combo_cliente);

            ControlVentas.llenarProductosCombo(combo_producto);


            filtro_cuit.Text = "Buscar por CUIT o DNI";
            filtro_cuit.ForeColor = Color.Gray;
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void limpiar()
        {

            txt_ventas_cantidad.Text = "1";
            txt_ventas_codigo.Text = "";

            txt_ventas_iva.Text = "";
            txt_ventas_precio.Text = "";


        }
        private void calcularSubtotal()
        {

            decimal iva;
            decimal lista;
            int cantidad;
            decimal precio_venta;
            decimal subtotal;

            iva = (Convert.ToDecimal(txt_ventas_iva.Text)) / 100 + 1;
            lista = (Convert.ToDecimal(txt_ventas_lista.Text)) / 100 + 1;
            cantidad = Convert.ToInt32(txt_ventas_cantidad.Text);
            precio_venta = Convert.ToDecimal(txt_ventas_precio.Text);
            subtotal = Math.Round((precio_venta * iva * cantidad * lista), 3);
            txt_ventas_subtotal.Text = subtotal.ToString();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            ControlPresupuesto.InvoiceGenerate(dataGridView1);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
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
    }
}
