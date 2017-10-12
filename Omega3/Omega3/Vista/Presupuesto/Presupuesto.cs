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
            dgv_tabla.Rows.Add(txt_ventas_cantidad.Text, txt_ventas_codigo.Text, combo_producto.Text, txt_ventas_precio.Text, txt_ventas_iva.Text, txt_ventas_subtotal.Text);
            txt_ventas_codigo.Focus();
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Cliente a = new Cliente();

            if (combo_cliente.Text == "")
            {
                a = ControlVentas.obtenerCliente(long.Parse(filtro_cuit.Text));

                razon.Text = a.Razon;
                domicilio.Text = a.Direccion;
                iva.Text = a.Impositiva;
                email.Text = a.Mail_contacto;
                cuit.Text = Convert.ToString(a.Documento);
            }
            else
            {
                a = ControlVentas.obtenerCliente(combo_cliente.Text);
                razon.Text = a.Razon;
                domicilio.Text = a.Direccion;
                iva.Text = a.Impositiva;
                email.Text = a.Mail_contacto;
                cuit.Text = Convert.ToString(a.Documento);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_principal.SelectedIndex = 1;
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                if (e.ColumnIndex == 7) //2nd column - DGV_ImageColumn
                {
                    dgv_tabla.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Venta venta = new Modelo.Venta();

            venta.documento = long.Parse(cuit.Text);
            venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue.ToString());

            if (combo_pago.Text == "Cheque")
            {
                venta.fecha_vencimiento_cheque = fecha_pago.Value;

            }

            venta.nrofactura = 0;
            //venta.tipo_factura = 0;
            venta.fecha_venta = DateTime.Now;

            Factura_Negro factura = new Factura_Negro();
            factura.Nombre = razon.Text;
            factura.Documento = cuit.Text;
            factura.Direccion = domicilio.Text;
            factura.Fecha = DateTime.Now;


            //ControlVentas.AgregarVenta(dgv_tabla, venta);
            ControlVentas.generarFacturaNegro(dgv_tabla, factura);
        }

        private void txt_ventas_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_ventas_codigo.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Producto a = new Producto();
                    a = ControlVentas.llenarInformacionProducto(txt_ventas_codigo.Text);

                    combo_producto.Text = a.Nombre_producto;
                    txt_ventas_precio.Text = a.Precio_venta.ToString();
                    calcularSubtotal();
                    button1.Focus();

                }

            }
            else
            {

                MessageBox.Show("El campo código no puede estar vacío");
                txt_ventas_codigo.Focus();
            }
        }

        private void panel_principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel_principal.SelectedIndex == 1)
            {
                txt_ventas_codigo.Focus();
            }
        }

        private void txt_ventas_cantidad_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
            txt_ventas_iva.Focus();
        }

        private void txt_ventas_iva_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
        }

        private void combo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto a = new Producto();
            txt_ventas_codigo.Text = combo_producto.SelectedValue.ToString();
            a = ControlVentas.llenarInformacionProducto(combo_producto.SelectedValue.ToString());
            combo_producto.Text = a.Nombre_producto;
            txt_ventas_precio.Text = a.Precio_venta.ToString();
            calcularSubtotal();
        }
    }
}
