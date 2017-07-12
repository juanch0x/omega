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

namespace Omega3.Vista.Clientes
{
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }
        // Returns JSON string
        string GET(string url)
        {
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
                    // log errorText
                }
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var a = JsonConvert.DeserializeObject<wea>(GET("https://soa.afip.gob.ar/sr-padron/v2/persona/20146155953"));

            
            Console.WriteLine("HOLA!"+a.data.nombre);


        }
    }



    public class Cliente_Json
    {

        public string nombre { get; set; }
        public string tipoPersona { get; set; }
        public string tipoClave { get; set; }

    }
    public class wea
    {
        public Cliente_Json data  { get; set; }
}
}

