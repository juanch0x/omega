using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Omega3.Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;
using Omega3.Controlador;

namespace Omega3.Vista.Clientes
{
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
            txt_documento.Visible = false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // Returns JSON string
        string GET(string cuit)
        {
            string url = "https://soa.afip.gob.ar/sr-padron/v2/persona/"+cuit;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                 
                }
                throw;
            }
        }


        private void CrearCliente_Load(object sender, EventArgs e)
        {
            ControlVentas.llenarCondicion(combo_condicion);
            ControlCliente.llenarProvincias(combo_provincia);
            ControlCliente.llenarTipoDocumento(combo_documento);
        }


        private void cargar_Click(object sender, EventArgs e)
        {
            datos a = new datos();
            if (ControladorFuncVariadas.AccesoInternet()) {

                if (combo_documento.Text == "CUIT")
                {

                    if (txt_cuit.Text.Trim().Length < 11)
                    {
                        MessageBox.Show("El campo CUIT se encuentra incompleto");
                    }
                    else
                    {

                        a = JsonConvert.DeserializeObject<datos>(GET(txt_cuit.Text));
                        if (a.data.nombre != null)
                            txt_razon_social.Text = a.data.nombre;
                        if (a.data.domicilioFiscal.direccion != null)
                            txt_direccion.Text = a.data.domicilioFiscal.direccion;

                        if (Convert.ToString(a.data.domicilioFiscal.codPostal) != "0")
                            txt_cod_postal.Text = Convert.ToString(a.data.domicilioFiscal.codPostal);


                        combo_provincia.SelectedIndex = a.data.domicilioFiscal.idProvincia;
                    }
                }
                else if (combo_documento.Text == "CUIL")
                {

                    if (txt_cuit.Text.Trim().Length < 11)
                    {
                        MessageBox.Show("El campo CUIL se encuentra incompleto");
                    }
                    else
                    {

                        a = JsonConvert.DeserializeObject<datos>(GET(txt_cuit.Text));
                        if (a.data.nombre != null)
                            txt_razon_social.Text = a.data.nombre;
                        if (a.data.domicilioFiscal.direccion != null)
                            txt_direccion.Text = a.data.domicilioFiscal.direccion;

                        if (Convert.ToString(a.data.domicilioFiscal.codPostal) != "0")
                            txt_cod_postal.Text = Convert.ToString(a.data.domicilioFiscal.codPostal);


                        combo_provincia.SelectedIndex = a.data.domicilioFiscal.idProvincia;
                    }


                } }
            else { MessageBox.Show("No es posible autocompletar los datos, debido a que no hay conexión a internet"); }
        }



        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (combo_documento.Text == "DNI" && txt_documento.Text.Trim().Length < 8)
                MessageBox.Show("El documento está incompleto");
            else if (txt_cuit.Text.Trim().Length < 11)
                MessageBox.Show("El campo documento está incompleto");
            else
            {

                if (combo_documento.Text == "DNI")
                    cliente.Documento = long.Parse(txt_documento.Text);
                else
                    cliente.Documento = long.Parse(txt_cuit.Text);


                cliente.Tipo_documento = combo_documento.SelectedIndex;
                cliente.Razon = txt_razon_social.Text;
                cliente.Direccion = txt_direccion.Text;
                cliente.Telefono = long.Parse(txt_telefono.Text);
                cliente.Contacto = txt_contacto.Text;
                cliente.Mail_contacto = txt_mail_contacto.Text;
                cliente.Codigo_postal = Convert.ToInt32(txt_cod_postal.Text);
                cliente.Localidad = txt_localidad.Text;
                cliente.Impositiva = combo_condicion.Text;
                cliente.Cod_provincia = combo_provincia.SelectedIndex;


                if (!ControlCliente.validardocumento(cliente.Documento))
                {
                    ControlCliente.AgregarCliente(cliente);


                    MessageBox.Show("El cliente fue agregado correctamente!");
                    limpiarCampos();
                }
                else { MessageBox.Show("El documento ingresado ya existe"); }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_cuit.Text);
            txt_cuit.ResetText();
        }

        private void combo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_documento.Text == "DNI")
            {
                cargar.Visible = false;
                txt_documento.Visible = true;
                txt_cuit.Visible = false;
            }
            else { cargar.Visible = true;
                txt_documento.Visible = false;
                txt_cuit.Visible = true;
            }
        }

        private void limpiarCampos()
        {
            txt_documento.ResetText();
            txt_cuit.ResetText();
            txt_cod_postal.ResetText();
            txt_contacto.ResetText();
            txt_direccion.ResetText();
            txt_localidad.ResetText();
            txt_mail_contacto.ResetText();
            txt_razon_social.ResetText();
            txt_telefono.ResetText();
            combo_documento.SelectedIndex = 0;
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumericos(e);
        }

        private void CrearCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }



    public class Cliente_Json
    {

        public string nombre { get; set; }
        public string tipoPersona { get; set; }
        public string tipoClave { get; set; }
        public DomicilioFiscal domicilioFiscal { get; set; }

        public Cliente_Json() {
            this.nombre = "";
            this.tipoPersona = "";
            domicilioFiscal = new DomicilioFiscal();
       
        }

    }
    public class datos
    {
        public Cliente_Json data  { get; set; }

        public datos() { data = new Cliente_Json(); }

    }
    public class DomicilioFiscal
    {
        public string direccion { get; set; }
        //string localidad { get; set; }
        public long codPostal { get; set; }
        public int idProvincia { get; set; }


    }

  }

