using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            proveedor.Nombre_proveedor = txt_proveedor.Text;
            proveedor.Telefono = Convert.ToInt32(txt_telefono.Text);
            proveedor.Direccion = txt_direccion.Text;
            proveedor.Codigo_postal = Convert.ToInt32(txt_codigo_postal.Text);
            proveedor.Email = txt_email.Text;
            proveedor.Provincia = txt_provincia.Text;
            
            Controlador.ControlProveedor.AgregarProveedor(proveedor);

            MessageBox.Show("El proveedor se agregó correctamente!");
            limpiar();

        }
    }
}
