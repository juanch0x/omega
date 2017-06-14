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

namespace Omega3.Vista.Proveedores
{
    public partial class ModificarProveedor : Form
    {
        Proveedor proveedor;
        public ModificarProveedor(Proveedor a)
        {
            InitializeComponent();
            this.proveedor = a;
            txt_id_proveedor.Text = Convert.ToString(proveedor.Id_proveedor);
            txt_proveedor.Text = proveedor.Nombre_proveedor;
            txt_provincia.Text = proveedor.Provincia;
            txt_telefono.Text = Convert.ToString(proveedor.Telefono);
            txt_codigo_postal.Text = Convert.ToString(proveedor.Codigo_postal);
            txt_direccion.Text = proveedor.Direccion;
            txt_email.Text = proveedor.Email;

        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_codigo_postal.Text == "") { ControlProveedor.validarTextboxVacio("Codigo postal"); }
            else if (txt_direccion.Text == "") { ControlProveedor.validarTextboxVacio("Dirección"); }
            else if (txt_email.Text == "") { ControlProveedor.validarTextboxVacio("Email"); }
            else if (txt_proveedor.Text == "") { ControlProveedor.validarTextboxVacio("Proveedor"); }
            else if (txt_provincia.Text == "") { ControlProveedor.validarTextboxVacio("Provincia"); }
            else if (txt_telefono.Text == "") { ControlProveedor.validarTextboxVacio("Telefono"); }
            else
            {
                proveedor.Codigo_postal = Convert.ToInt32(txt_codigo_postal.Text);
                proveedor.Direccion = txt_direccion.Text;
                proveedor.Email = txt_email.Text;
                proveedor.Id_proveedor = long.Parse(txt_id_proveedor.Text);
                proveedor.Nombre_proveedor = txt_proveedor.Text;
                proveedor.Provincia = txt_provincia.Text;
                proveedor.Telefono = Convert.ToInt32(txt_telefono.Text);
                
                ControlProveedor.ModificarProveedor(proveedor);
            }
            MessageBox.Show("El proveedor fue modificado correctamente");
            this.Close();
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

        
    }
}
