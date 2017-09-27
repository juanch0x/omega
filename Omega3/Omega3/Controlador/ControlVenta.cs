




using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FacturanteMVC.API;
using FacturanteMVC.API.DTOs;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;
using System.Net;

namespace Omega3.Controlador
{
    class ControlVenta
    {
        public string ObjectToXml<T>(T objectToSerialise)
        {
            System.IO.StringWriter Output = new System.IO.StringWriter(new StringBuilder());
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(objectToSerialise.GetType());
            System.Xml.Serialization.XmlSerializerNamespaces ns = new System.Xml.Serialization.XmlSerializerNamespaces();
            ns.Add("fac", "http://www.facturante.com.API");
            xs.Serialize(Output, objectToSerialise, ns);
            return Output.ToString();
        }
        public void Venta()
        {
            ComprobantesClient client = new ComprobantesClient();

            
            ComprobantesClient comprobanteClient = new ComprobantesClient();

            CrearComprobanteRequest request = new CrearComprobanteRequest();
            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "TEST_API_GENERICO";
            request.Autenticacion.Hash = "test2016facturante";
            request.Autenticacion.Empresa = 118; //[Identificador de la empresa a la que pertenece el usuario]

            request.Cliente = new Cliente();
            request.Cliente.CodigoPostal = "5500";
            request.Cliente.CondicionPago = 1;
            request.Cliente.Contacto = "Jorge Catalino de la Cruz";
            request.Cliente.DireccionFiscal = "Av. SiempreViva 444";
            request.Cliente.EnviarComprobante = true;
            request.Cliente.Localidad = "Mendoza";
            request.Cliente.MailContacto = "bruno.jarg@gmail.com";
            request.Cliente.MailFacturacion = "bruno.jarg@gmail.com";
            request.Cliente.NroDocumento = "20146155953";
            request.Cliente.PercibeIIBB = false;
            request.Cliente.PercibeIVA = false;
            request.Cliente.Provincia = "Mendoza";
            request.Cliente.RazonSocial = "Probando Ventas Facturante julian puto";
            request.Cliente.Telefono = "4251869";
            request.Cliente.TipoDocumento = 1;
            request.Cliente.TratamientoImpositivo = 3;

            request.Encabezado = new ComprobanteEncabezado();
            request.Encabezado.Bienes = 2;
            request.Encabezado.CondicionVenta = 1;
            request.Encabezado.EnviarComprobante = true;
            request.Encabezado.FechaHora = DateTime.Now;
            request.Encabezado.FechaServDesde = DateTime.Now;
            request.Encabezado.FechaServHasta = DateTime.Now;
            request.Encabezado.FechaVtoPago = DateTime.Now;
            request.Encabezado.ImporteImpuestosInternos = 0;
            request.Encabezado.ImportePercepcionesMunic = 0;
            request.Encabezado.Moneda = 2;
            request.Encabezado.Observaciones = "GG LA WEA";
            request.Encabezado.OrdenCompra = "1487";
            request.Encabezado.PercepcionIIBB = 0;
            request.Encabezado.PercepcionIVA = 0;
            request.Encabezado.PorcentajeIIBB = 0;
            request.Encabezado.Prefijo = "0002";
            request.Encabezado.Remito = "444";
            request.Encabezado.SubTotal = (decimal)664.46;
            request.Encabezado.SubTotalExcento = 0;
            request.Encabezado.SubTotalNoAlcanzado = 0;
            request.Encabezado.TipoComprobante = "PF";
            request.Encabezado.TipoDeCambio = 1;
            request.Encabezado.Total = 804;
            request.Encabezado.TotalConDescuento = 0;
            request.Encabezado.TotalNeto = (decimal)664.46;

            request.Items = new ComprobanteItem[3];

            request.Items[0] = new ComprobanteItem();
            request.Items[0].Bonificacion = 0;
            request.Items[0].Cantidad = 1;
            request.Items[0].Codigo = "CODPROD";
            request.Items[0].Detalle = "Producto Uno";
            request.Items[0].Gravado = true;
            request.Items[0].IVA = 21;
            request.Items[0].PrecioUnitario = 100;
            request.Items[0].Total = 121;

            request.Items[1] = new ComprobanteItem();
            request.Items[1].Bonificacion = 0;
            request.Items[1].Cantidad = 1;
            request.Items[1].Codigo = "CODPROD2";
            request.Items[1].Detalle = "Producto Dos";
            request.Items[1].Gravado = true;
            request.Items[1].IVA = 21;
            request.Items[1].PrecioUnitario = (decimal)164.46;
            request.Items[1].Total = 199;

            request.Items[2] = new ComprobanteItem();
            request.Items[2].Bonificacion = 0;
            request.Items[2].Cantidad = 2;
            request.Items[2].Codigo = "CODPROD3";
            request.Items[2].Detalle = "Producto Tres";
            request.Items[2].Gravado = true;
            request.Items[2].IVA = 21;
            request.Items[2].PrecioUnitario = 200;
            request.Items[2].Total = 484;

            
            CrearComprobanteResponse response = comprobanteClient.CrearComprobante(request);
            
            Console.Write(ObjectToXml<CrearComprobanteResponse>(response));

            String id_comprobante = "PEDRO";

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<CrearComprobanteResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"

            XmlNodeList xnList = xml.SelectNodes("/CrearComprobanteResponse");
            foreach (XmlNode xn in xnList)
            {

                id_comprobante = xn["IdComprobante"].InnerText;
             
            }


            comprobanteClient.Close();

            detalleComprobante(id_comprobante);
        }


        public void detalleComprobante(string id_comprobante)
        {
            ListadoComprobantesRequest request = new ListadoComprobantesRequest();
            ComprobantesClient comprobanteClient = new ComprobantesClient();

            
            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "TEST_API_GENERICO";
            request.Autenticacion.Hash = "test2016facturante";
            request.Autenticacion.Empresa = 118; //[Identificador de la empresa a la que pertenece el usuario]
            request.IdComprobante = Convert.ToInt32(id_comprobante);

            ListadoComprobantesResponse response = comprobanteClient.ListadoComprobantes(request);
            
            String url = "PEDRO";

             XmlDocument xml = new XmlDocument();
             xml.LoadXml(ObjectToXml<ListadoComprobantesResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"

              XmlNodeList xnList = xml.SelectNodes("/ListadoComprobantesResponse/ListadoComprobantes/Comprobante");
              foreach (XmlNode xn in xnList)
              {

                url = xn["URLPDF"].InnerText;
                  //System.Diagnostics.Process.Start(xn["URLPDF"].InnerText);
               }

           /* 
            * Función que hace que los pdf se vallan guardando por si los quiere..
            * 
            * using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(url, "C:\\carpeta\\Comprobante_"+request.IdComprobante+".pdf");
            }
            
            
             *
             * Para hacer que use la ventana mdi principal como padre desde un formulario hijo   
             * 
             Form2 f2 = new Form2;
            f2.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
            f2.Show();
             */

            Omega3.Vista.Venta.Comprobante_Claro MostrarComprobante = new Vista.Venta.Comprobante_Claro(url);
            MostrarComprobante.Show();

        }

        public static void llenarClientes(ComboBox combo)
        {

            string query = "SELECT documento, razon_social from cliente";

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            combo.ValueMember = "documento";
            combo.DisplayMember = "razon_social";
            combo.DataSource = dt;
       

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado 
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["razon_social"]));
            }

            combo.AutoCompleteCustomSource = coleccion;
            combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


    }
}
