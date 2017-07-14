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
        private void button1_Click(object sender, EventArgs e)
        {

            var a = JsonConvert.DeserializeObject<datos>(GET(txt_documento.Text));

            
            Console.WriteLine("HOLA!"+a.data.domicilioFiscal.codPostal);
            Console.WriteLine("HOLA!" + a.data.nombre);


        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            ControlVentas.llenarCondicion(combo_condicion);
            ControlVentas.llenarMedios_de_Pago(combo_pago);

        }

        private void combo_condicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlVentas.llenarFacturas(combo_tipo_factura, Convert.ToInt32(combo_condicion.SelectedValue));

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            
            var a = JsonConvert.DeserializeObject<datos>(GET(txt_documento.Text));

                txt_razon_social.Text=a.data.nombre;
                txt_direccion.Text = a.data.domicilioFiscal.direccion;
                txt_cod_postal.Text = Convert.ToString(a.data.domicilioFiscal.codPostal);
           
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

        public DomicilioFiscal() {
            this.codPostal = 0;
            this.direccion = "";
        }

    }
}

