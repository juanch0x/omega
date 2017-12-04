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
using System.Threading;

namespace Omega3.Vista.Reparaciones
{
    public partial class FinalizarReparacion : Form
    {
        
        string id_comprobante;
        string url;
        Cliente cliente;
        decimal total = new decimal();
        DataGridView dgv_tabla;
        long id_reparacion;
        Form a;
        public FinalizarReparacion(Cliente cliente, decimal total, DataGridView dgv_tabla, long id_reparacion, Form a)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.total = total;
            this.dgv_tabla = dgv_tabla;
            this.id_reparacion = id_reparacion;
            this.a = a;
            txt_vencimiento.Visible = false;
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
            ControlReparaciones a = new ControlReparaciones();
            Modelo.Venta venta = new Modelo.Venta();
            venta.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
            venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);

            ControlVenta facturar = new ControlVenta();

            Modelo.Reparacion reparacion = new Modelo.Reparacion();

            reparacion.tipo_factura = combo_comprobante.SelectedValue.ToString();
            reparacion.vencimiento = llenarVencimiento();
            reparacion.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
            //usuario
            reparacion.cobrada = llenarCobrada();
            

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ControlReparaciones.FinalizarReparacion(id_reparacion,reparacion) == 1)
            {

                    //MessageBox.Show("Se realizó la venta correctamente!");
                    id_comprobante = facturar.FacturarReparacion(venta, cliente, dgv_tabla);
                    var task = Task.Factory.StartNew(() => a.ActualizarFacturaYUrl(id_comprobante, id_reparacion));
                }
     
            
                

                
                


            }
            catch(Exception ex) { Console.WriteLine(ex); }
            finally {
                Cursor.Current = Cursors.Default;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void combo_medio_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_medio_de_pago.Text == "Cheque" || combo_medio_de_pago.Text == "Cuenta Corriente") {
                txt_vencimiento.Visible = true;
            }
            else { txt_vencimiento.Visible = false; }
        }

        private DateTime llenarVencimiento ()
        {
            if (combo_medio_de_pago.Text == "Cheque" || combo_medio_de_pago.Text == "Cuenta Corriente")
            {
                return txt_vencimiento.Value;
            }
            else { return DateTime.Now; }
        }

        private bool llenarCobrada()
        {
            if (combo_medio_de_pago.Text == "Cheque" || combo_medio_de_pago.Text == "Cuenta Corriente")
            {
                return false;
            }
            else { return true; }
        }

    }
    }

