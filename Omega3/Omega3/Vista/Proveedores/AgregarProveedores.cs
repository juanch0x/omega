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

namespace Omega3.Vista.Proveedores
{
    public partial class AgregarProveedores : Form
    {
        public AgregarProveedores()
        {
            InitializeComponent();
        }

        private void limpiar() {

            txt_codigo_postal.Text = "";
            txt_email.Text = "";
            txt_proveedor.Text = "";
            txt_provincia.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_email2.Text = "";
            txt_email3.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Proveedor proveedor = new Modelo.Proveedor();

            if (txt_codigo_postal.Text == "") { ControlProveedor.validarTextboxVacio("Codigo postal"); }
            else if (txt_direccion.Text == "") { ControlProveedor.validarTextboxVacio("Dirección"); }
            else if (txt_email.Text == "") { ControlProveedor.validarTextboxVacio("Email"); }
            else if (txt_proveedor.Text == "") { ControlProveedor.validarTextboxVacio("Proveedor"); }
            else if (txt_provincia.Text == "") { ControlProveedor.validarTextboxVacio("Provincia"); }
            else if (txt_telefono.Text == "") { ControlProveedor.validarTextboxVacio("Telefono"); }
            else
            {

                proveedor.Nombre_proveedor = txt_proveedor.Text;
                proveedor.Telefono = Convert.ToInt32(txt_telefono.Text);
                proveedor.Direccion = txt_direccion.Text;
                proveedor.Codigo_postal = Convert.ToInt32(txt_codigo_postal.Text);
                proveedor.Email = txt_email.Text;
                proveedor.Provincia = txt_provincia.Text;
                proveedor.Email2 = txt_email2.Text;
                proveedor.Email3 = txt_email3.Text;



                proveedor.puntaje.transporte_posicion = Convert.ToInt32(transporte_posicion.SelectedItem);
                proveedor.puntaje.transporte_antecedentes = Convert.ToInt32(transporte_antecedentes.SelectedItem);
                proveedor.puntaje.transporte_capacidad = Convert.ToInt32(transporte_capacidad.SelectedItem);
                proveedor.puntaje.transporte_financiera = Convert.ToInt32(transporte_financiera.SelectedItem);
                proveedor.puntaje.transporte_Prestigio = Convert.ToInt32(transporte_prestigio.SelectedItem);
                proveedor.puntaje.transporte_transporte = Convert.ToInt32(transporte_pais.SelectedItem);

                proveedor.puntaje.calidad_costo = Convert.ToInt32(calidad_costo.SelectedItem);
                proveedor.puntaje.calidad_cuidado = Convert.ToInt32(calidad_cuidado.SelectedItem);
                proveedor.puntaje.calidad_plazos = Convert.ToInt32(calidad_plazo.SelectedItem);

                proveedor.puntaje.otros_administrativa = Convert.ToInt32(otros_administrativa.SelectedItem);
                proveedor.puntaje.otros_pedidos = Convert.ToInt32(otros_capacidad.SelectedItem);
                proveedor.puntaje.otros_respuesta = Convert.ToInt32(otros_respuesta.SelectedItem);

                proveedor.puntaje.pago_descuento = Convert.ToInt32(pago_descuento.SelectedItem);
                proveedor.puntaje.pago_plazo = Convert.ToInt32(pagos_plazo.SelectedItem);

                // Controlador.ControlProveedor.AgregarProveedor(proveedor);
                Controlador.ControlProveedor.AgregarProveedor(proveedor);
                limpiarCombos(this);
                MessageBox.Show("El proveedor se agregó correctamente!");
                limpiar();


                
                


            }
        }

        private void txt_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumerosyLetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumericos(e);
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumerosyLetras(e);
        }

        private void txt_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresLetras(e);
        }

        private void txt_codigo_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumericos(e);
        }


        private void limpiarCombos(Control ctrl)
        {
            if (ctrl is ComboBox)
            {
                ctrl.Text = "";
            }
            foreach (Control childCtrl in ctrl.Controls) limpiarCombos(childCtrl);

            
        }
       
    }
}
