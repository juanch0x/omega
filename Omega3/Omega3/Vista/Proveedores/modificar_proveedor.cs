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

namespace Omega3.Vista.Proveedores
{
    public partial class modificar_proveedor : Form
    {
        public modificar_proveedor()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.Nombre_proveedor = txt_proveedor.Text;
            proveedor.Telefono = long.Parse(txt_telefono.Text);
            proveedor.Direccion = txt_direccion.Text;
            proveedor.Provincia = txt_provincia.Text;
            proveedor.Codigo_postal = int.Parse(txt_codigo_postal.Text);
            proveedor.Email = txt_email.Text;
            proveedor.Email2 = txt_email2.Text;
            proveedor.Email3 = txt_email3.Text;

            proveedor.puntaje.transporte_posicion = transporte_posicion.SelectedIndex;
            proveedor.puntaje.transporte_Prestigio = transporte_prestigio.SelectedIndex;
            proveedor.puntaje.transporte_antecedentes = transporte_antecedentes.SelectedIndex;
            proveedor.puntaje.transporte_financiera = transporte_financiera.SelectedIndex;
            proveedor.puntaje.transporte_transporte = transporte_pais.SelectedIndex;
            proveedor.puntaje.transporte_capacidad = transporte_capacidad.SelectedIndex;

            proveedor.puntaje.calidad_plazos = calidad_plazo.SelectedIndex;
            proveedor.puntaje.calidad_costo = calidad_costo.SelectedIndex;
            proveedor.puntaje.calidad_cuidado = calidad_cuidado.SelectedIndex;

            proveedor.puntaje.pago_plazo = pagos_plazo.SelectedIndex;
            proveedor.puntaje.pago_descuento = pago_descuento.SelectedIndex;

            proveedor.puntaje.otros_respuesta = otros_respuesta.SelectedIndex;
            proveedor.puntaje.otros_administrativa = otros_administrativa.SelectedIndex;
            proveedor.puntaje.otros_pedidos = otros_capacidad.SelectedIndex;



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
