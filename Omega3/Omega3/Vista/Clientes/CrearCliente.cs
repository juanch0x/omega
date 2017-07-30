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
        }
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
            
            var a = JsonConvert.DeserializeObject<datos>(GET(txt_documento.Text));
            
             txt_razon_social.Text=a.data.nombre;
             txt_direccion.Text = a.data.domicilioFiscal.direccion;
             txt_cod_postal.Text = Convert.ToString(a.data.domicilioFiscal.codPostal);
             combo_provincia.SelectedIndex = a.data.domicilioFiscal.idProvincia;
                       
        }



        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Tipo_documento = combo_documento.SelectedIndex;
            cliente.Documento = long.Parse(txt_documento.Text);
            cliente.Razon = txt_razon_social.Text;
            cliente.Direccion = txt_direccion.Text;
            cliente.Telefono = long.Parse(txt_telefono.Text);
            cliente.Contacto = txt_contacto.Text;
            cliente.Mail_contacto = txt_mail_contacto.Text;
            cliente.Codigo_postal = Convert.ToInt32(txt_cod_postal.Text);
            cliente.Localidad = txt_localidad.Text;
            cliente.Impositiva = combo_condicion.Text;
            cliente.Cod_provincia = combo_provincia.SelectedIndex;

            ControlCliente.AgregarCliente(cliente);
            

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
        }

    }
    public class datos
    {
        public Cliente_Json data  { get; set; }
    }
    public class DomicilioFiscal
    {
        public string direccion { get; set; }
        //string localidad { get; set; }
        public long codPostal { get; set; }
        public int idProvincia { get; set; }

        public DomicilioFiscal() {
            this.codPostal = 0;
            this.direccion = "";
            }

    }
}

