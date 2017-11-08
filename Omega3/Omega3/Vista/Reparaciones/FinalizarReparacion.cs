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

namespace Omega3.Vista.Reparaciones
{
    public partial class FinalizarReparacion : Form
    {
        bool stoptimer;
        string id_comprobante;
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
            progressBar1.Maximum = 100;
            stoptimer = false;
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {

            Modelo.Venta venta = new Modelo.Venta();
            venta.medio_de_pago = Convert.ToInt32(combo_medio_de_pago.SelectedValue);
            venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
            ControlVenta facturar = new ControlVenta();
            //facturar.FacturarReparacion(venta, cliente, dgv_tabla);
            if (ControlReparaciones.FinalizarReparacion(id_reparacion) == 1)
            {
                MessageBox.Show("Se realizó la venta correctamente!");
                
            }
            try { 
            id_comprobante = facturar.FacturarReparacion(venta, cliente, dgv_tabla);
                //facturar.detalleComprobante(id_comprobante);
                /*  ControladorFuncVariadas.chequearComprobante(id_comprobante);
                  */
                // timer1.Start();
            }catch(Exception a) { Console.WriteLine(a); }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
            ControlVenta ab = new ControlVenta();
            progressBar1.Visible = true;
            lbl_cargando.Visible = true;

            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
                if (lbl_cargando.Text == "Cargando")
                {
                    lbl_cargando.Text = "Cargando.";
                }
                else if (lbl_cargando.Text == "Cargando.")
                {
                    lbl_cargando.Text = "Cargando..";
                }
                else if (lbl_cargando.Text == "Cargando..")
                {
                    lbl_cargando.Text = "Cargando...";
                }
                else if (lbl_cargando.Text == "Cargando...")
                {
                    lbl_cargando.Text = "Cargando";
                }
            }
            else if (progressBar1.Value == 100)
            {
                ab.detalleComprobante(id_comprobante);
                if (ControladorFuncVariadas.chequearComprobante(id_comprobante))
                {
                    timer1.Stop();
                    this.Close();
                    a.Close();
                }
                else
                {
                    timer1.Stop();
                    
                    this.Close();
                    a.Close();
                    MessageBox.Show("Hubo un error descargando el comprobante, porque el CAE no estaba listo, para descargalo utilice la platataforma de Facturante.");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

