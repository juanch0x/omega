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
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //DGV TABLA

            txt_ventas_cantidad.Text = "1";
            txt_ventas_iva.Text = "21";
            txt_ventas_lista.Text = "10";
        


        }

        private void limpiar()
        {

            txt_ventas_cantidad.Text = "1";
            txt_ventas_codigo.Text = "";
            txt_ventas_descripcion.Text = "";
            txt_ventas_iva.Text = "";
            txt_ventas_precio.Text = "";


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

        private void panel_principal_KeyDown(object sender, KeyEventArgs e)
        {
                btn_no_factura.Visible = true;

        }

        private void btn_no_factura_Click(object sender, EventArgs e)
        {

            ControlVentas.AgregarVenta(dgv_tabla);
            //ControlVentas.generarFacturaNegro(dgv_tabla);

        }

        private void txt_ventas_codigo_KeyDown(object sender, KeyEventArgs e)
        {

    
            if (e.KeyCode == Keys.Enter) {
                Producto a = new Producto();
                a = ControlVentas.llenarInformacionProducto(txt_ventas_codigo.Text);

                txt_ventas_descripcion.Text = a.Nombre_producto;
                txt_ventas_precio.Text = a.Precio_venta.ToString();
                calcularSubtotal();
                    
                //dgv_tabla.Rows.Add(txt_ventas_cantidad.Text, txt_ventas_codigo.Text, txt_ventas_descripcion.Text, txt_ventas_precio.Text, txt_ventas_lista.Text, txt_ventas_iva.Text, txt_ventas_subtotal.Text);
            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            dgv_tabla.Rows.Add(txt_ventas_cantidad.Text, txt_ventas_codigo.Text, txt_ventas_descripcion.Text, txt_ventas_precio.Text, txt_ventas_iva.Text, txt_ventas_subtotal.Text);

        }

        private void panel_principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel_principal.SelectedIndex == 1) {
                txt_ventas_codigo.Focus();
            }
        }

        private void txt_ventas_cantidad_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
            txt_ventas_iva.Focus();
        }

        private void calcularSubtotal() {

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

        private void txt_ventas_iva_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
        }
    }
    }

