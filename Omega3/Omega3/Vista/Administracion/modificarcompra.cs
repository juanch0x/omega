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
        public modificarcompra(long id)
        {
            InitializeComponent();
            this.id = id;


        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

        }

        private void modificarcompra_Load(object sender, EventArgs e)
        {
            Modelo.ComprasaProveedores compra = new Modelo.ComprasaProveedores();
            compra = Omega3.Controlador.ControlCompras.modificarCompra(id);
            txt_proveedor.Text = compra.Proveedor;
            txt_motivo.Text = compra.Motivo;
            txt_fecha.Value = compra.Vencimiento;
            txt_monto.Text  = Convert.ToString(compra.Monto);
            txt_comprobante.Text = compra.Comprobante;
            txt_iva.Text = Convert.ToString(compra.Iva);
            txt_razon.Text = compra.Razon;
            txt_detalle.Text = compra.Detalle;
            txt_fechapago.Value = compra.Fechapago;

            
        }
    }
}
