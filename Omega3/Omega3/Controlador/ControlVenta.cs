﻿using System;
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
using Omega3.Vista.Venta;
using Omega3.Modelo;

namespace Omega3.Controlador
{
    class ControlVenta
    {


        public ControlVenta()
        {


        }

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
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]

            request.Cliente = new FacturanteMVC.API.DTOs.Cliente();
            request.Cliente.CodigoPostal = "5500";
            request.Cliente.CondicionPago = 1;
            request.Cliente.Contacto = "Jorge Catalino de la Cruz";
            request.Cliente.DireccionFiscal = "Av. SiempreViva 444";
            request.Cliente.EnviarComprobante = true;
            request.Cliente.Localidad = "Mendoza";
            request.Cliente.MailContacto = "thejuasz@gmail.com";
            request.Cliente.MailFacturacion = "thejuasz@gmail.com";
            request.Cliente.NroDocumento = "20146155953";
            request.Cliente.PercibeIIBB = false;
            request.Cliente.PercibeIVA = false;
            request.Cliente.Provincia = "Mendoza";
            request.Cliente.RazonSocial = "Probando Ventas Facturante";
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
            request.Encabezado.Prefijo = "0004";
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
            request.Autenticacion.Usuario = "comercial@omegadistribuidora.com";
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]
            request.IdComprobante = Convert.ToInt32(id_comprobante);

            ListadoComprobantesResponse response = comprobanteClient.ListadoComprobantes(request);

            String url = "PEDRO";

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<ListadoComprobantesResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"
                                                                             //  MessageBox.Show(ObjectToXml<ListadoComprobantesResponse>(response));
            XmlNodeList xnList = xml.SelectNodes("/ListadoComprobantesResponse/ListadoComprobantes/Comprobante");
            foreach (XmlNode xn in xnList)
            {

                url = xn["URLPDF"].InnerText;
                //System.Diagnostics.Process.Start(xn["URLPDF"].InnerText);
            }


            //Función que hace que los pdf se vallan guardando por si los quiere..

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(url, Path.GetTempPath() + "Comprobante_" + request.IdComprobante + ".pdf");
                }
                catch (FileLoadException ex) { Console.Write(ex); }
            }


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
           // combo.AutoCompleteMode = AutoCompleteMode.Suggest;
          //  combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }



        public string Facturar(Omega3.Modelo.Venta venta, Omega3.Modelo.Cliente cliente, List<Detalle_Facturante> detalle)
        {

            ComprobantesClient client = new ComprobantesClient();


            ComprobantesClient comprobanteClient = new ComprobantesClient();

            CrearComprobanteRequest request = new CrearComprobanteRequest();

            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "comercial@omegadistribuidora.com";
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]

            request.Cliente = new FacturanteMVC.API.DTOs.Cliente();
            request.Cliente.CodigoPostal = Convert.ToString(cliente.Codigo_postal);
            request.Cliente.CondicionPago = venta.medio_de_pago;
            request.Cliente.Contacto = cliente.Contacto;
            request.Cliente.DireccionFiscal = cliente.Direccion;
            request.Cliente.EnviarComprobante = true;
            request.Cliente.Localidad = cliente.Localidad;
            request.Cliente.MailContacto = cliente.Mail_contacto;
            request.Cliente.MailFacturacion = cliente.Mail_contacto;
            request.Cliente.NroDocumento = Convert.ToString(cliente.Documento);
            request.Cliente.PercibeIIBB = false;
            request.Cliente.PercibeIVA = false;
            request.Cliente.Provincia = cliente.Provincia;
            request.Cliente.RazonSocial = cliente.Razon;
            request.Cliente.Telefono = Convert.ToString(cliente.Telefono);
            request.Cliente.TipoDocumento = cliente.Tipo_documento;
            request.Cliente.TratamientoImpositivo = Convert.ToInt32(cliente.Impositiva_Id);


            request.Encabezado = new ComprobanteEncabezado();
            //Definir si vamos a tratar todo como bienes o lo vamos a modificar.
            request.Encabezado.Bienes = 1;
            request.Encabezado.CondicionVenta = venta.medio_de_pago;
            request.Encabezado.EnviarComprobante = true;
            request.Encabezado.FechaHora = DateTime.Now;
            /*Son obligatorios si ponemos bienes en 2 (servicios) o en 3 (productos y servicios)
            request.Encabezado.FechaServDesde = DateTime.Now;
            request.Encabezado.FechaServHasta = DateTime.Now;*/
            request.Encabezado.FechaVtoPago = DateTime.Now;
            request.Encabezado.ImporteImpuestosInternos = 0;
            request.Encabezado.ImportePercepcionesMunic = 0;
            request.Encabezado.Moneda = 2;
            /* No son obligatorios 
            request.Encabezado.Observaciones = "GG LA WEA";
            request.Encabezado.OrdenCompra = "1487"; */
            //PREGUNTAR
            request.Encabezado.PercepcionIIBB = 0;
            request.Encabezado.PercepcionIVA = 0;
            request.Encabezado.PorcentajeIIBB = 0;
            //CAMBIAR CUANDO NOS PASEMOS A PRODUCCIóN
            request.Encabezado.Prefijo = "0004";
            /*Se siguen usando? No son obligatorios
            request.Encabezado.Remito = "444";*/
            request.Encabezado.TipoComprobante = venta.tipo_factura;
            //request.Encabezado.TipoComprobante = "PF";
            request.Encabezado.TipoDeCambio = 1;
            //Campos nuevos
            request.Encabezado.Remito = venta.remito.ToString();
            request.Encabezado.OrdenCompra = venta.ordendeCompra.ToString();

            request.Items = new ComprobanteItem[detalle.Count];
            int i = 0;
            foreach (Detalle_Facturante elemento in detalle)
            {
                request.Items[i] = new ComprobanteItem();
                request.Items[i].Bonificacion = elemento.Bonificacion;
                request.Items[i].Codigo = elemento.codigo;
                request.Items[i].Detalle = elemento.detalle;
                request.Items[i].Gravado = true;
                request.Items[i].IVA = elemento.iva;
                request.Items[i].PrecioUnitario = elemento.precio_unitario;
                request.Items[i].Total = elemento.total;
                request.Items[i].Cantidad = elemento.cantidad;
                i++;
            }



            CrearComprobanteResponse response = comprobanteClient.CrearComprobante(request);

            //MessageBox.Show(ObjectToXml<CrearComprobanteResponse>(response));

            String id_comprobante = "PEDRO";

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<CrearComprobanteResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"

            XmlNodeList xnList = xml.SelectNodes("/CrearComprobanteResponse");
            foreach (XmlNode xn in xnList)
            {

                id_comprobante = xn["IdComprobante"].InnerText;
                MessageBox.Show("Respuesta de facturante: " + xn["Estado"].InnerText);

            }


            comprobanteClient.Close();


            return id_comprobante;
        }


        public string FacturarReparacion(Omega3.Modelo.Venta venta, Omega3.Modelo.Cliente cliente, DataGridView dgv_tabla)
        {

            ComprobantesClient client = new ComprobantesClient();


            ComprobantesClient comprobanteClient = new ComprobantesClient();

            CrearComprobanteRequest request = new CrearComprobanteRequest();

            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "comercial@omegadistribuidora.com";
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]

            request.Cliente = new FacturanteMVC.API.DTOs.Cliente();
            request.Cliente.CodigoPostal = Convert.ToString(cliente.Codigo_postal);
            request.Cliente.CondicionPago = venta.medio_de_pago;
            request.Cliente.Contacto = cliente.Contacto;
            request.Cliente.DireccionFiscal = cliente.Direccion;
            request.Cliente.EnviarComprobante = true;
            request.Cliente.Localidad = cliente.Localidad;
            request.Cliente.MailContacto = cliente.Mail_contacto;
            request.Cliente.MailFacturacion = cliente.Mail_contacto;
            request.Cliente.NroDocumento = Convert.ToString(cliente.Documento);
            request.Cliente.PercibeIIBB = false;
            request.Cliente.PercibeIVA = false;
            request.Cliente.Provincia = cliente.Provincia;
            request.Cliente.RazonSocial = cliente.Razon;
            request.Cliente.Telefono = Convert.ToString(cliente.Telefono);
            request.Cliente.TipoDocumento = cliente.Tipo_documento;
            request.Cliente.TratamientoImpositivo = Convert.ToInt32(cliente.Impositiva_Id);


            request.Encabezado = new ComprobanteEncabezado();
            //Definir si vamos a tratar todo como bienes o lo vamos a modificar.
            request.Encabezado.Bienes = 1;
            request.Encabezado.CondicionVenta = venta.medio_de_pago;
            request.Encabezado.EnviarComprobante = true;
            //request.Encabezado.FechaHora = DateTime.Now;
            // request.Encabezado.FechaHora = new DateTime(2017,10,25);
            request.Encabezado.FechaHora = DateTime.Now;
            /*Son obligatorios si ponemos bienes en 2 (servicios) o en 3 (productos y servicios)
            request.Encabezado.FechaServDesde = DateTime.Now;
            request.Encabezado.FechaServHasta = DateTime.Now;*/
            request.Encabezado.FechaVtoPago = DateTime.Now;
            request.Encabezado.ImporteImpuestosInternos = 0;
            request.Encabezado.ImportePercepcionesMunic = 0;
            request.Encabezado.Moneda = 2;
            /* No son obligatorios 
            request.Encabezado.Observaciones = "GG LA WEA";
            //request.Encabezado.OrdenCompra = "1487"; */
            //PREGUNTAR
            request.Encabezado.PercepcionIIBB = 0;
            request.Encabezado.PercepcionIVA = 0;
            request.Encabezado.PorcentajeIIBB = 0;
            //CAMBIAR CUANDO NOS PASEMOS A PRODUCCIóN
            request.Encabezado.Prefijo = "0004";
            /*Se siguen usando? No son obligatorios
            request.Encabezado.Remito = "444";*/
            //request.Encabezado.TipoComprobante = venta.tipo_factura;
            request.Encabezado.TipoComprobante = venta.tipo_factura;
            //request.Encabezado.TipoComprobante = "PF";
            request.Encabezado.TipoDeCambio = 1;
            request.Encabezado.Remito = venta.remito.ToString();
            request.Encabezado.OrdenCompra = venta.ordendeCompra;


            request.Items = new ComprobanteItem[dgv_tabla.Rows.Count];
            int i = 0;
            foreach (DataGridViewRow item in dgv_tabla.Rows)
            {
                request.Items[i] = new ComprobanteItem();
                request.Items[i].Bonificacion = Convert.ToDecimal(item.Cells["Bonificacion"].Value);
                request.Items[i].Cantidad = Convert.ToInt32(item.Cells["Cantidad"].Value);
                request.Items[i].Codigo = Convert.ToString(item.Cells["Codigo"].Value);
                request.Items[i].Detalle = Convert.ToString(item.Cells["Descripcion"].Value);
                request.Items[i].Gravado = true;
                request.Items[i].IVA = Convert.ToDecimal(item.Cells["iva"].Value);
                request.Items[i].PrecioUnitario = Convert.ToDecimal(item.Cells["Precio"].Value);
                request.Items[i].Total = Convert.ToDecimal(request.Items[i].Cantidad * Convert.ToDecimal(request.Items[i].PrecioUnitario));
                i++;
            }



            CrearComprobanteResponse response = comprobanteClient.CrearComprobante(request);

            //MessageBox.Show(ObjectToXml<CrearComprobanteResponse>(response));

            String id_comprobante = string.Empty;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<CrearComprobanteResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"

            XmlNodeList xnList = xml.SelectNodes("/CrearComprobanteResponse");
            foreach (XmlNode xn in xnList)
            {

                id_comprobante = xn["IdComprobante"].InnerText;
                MessageBox.Show("Respuesta de facturante: " + xn["Estado"].InnerText);

            }


            comprobanteClient.Close();


            return id_comprobante;
        }

        public string obtenerDatosComprobante(string id_comprobante)
        {


            ListadoComprobantesRequest request = new ListadoComprobantesRequest();
            ComprobantesClient comprobanteClient = new ComprobantesClient();



            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "comercial@omegadistribuidora.com";
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]
            request.IdComprobante = Convert.ToInt32(id_comprobante);

            ListadoComprobantesResponse response = comprobanteClient.ListadoComprobantes(request);

            String url = String.Empty;
            String numero_factura = String.Empty;
            String prefijo_factura = String.Empty;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<ListadoComprobantesResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"
            Console.WriteLine(ObjectToXml<ListadoComprobantesResponse>(response));
            XmlNodeList xnList = xml.SelectNodes("/ListadoComprobantesResponse/ListadoComprobantes/Comprobante");
            foreach (XmlNode xn in xnList)
            {
                url = xn["URLPDF"].InnerText;
                numero_factura = xn["Numero"].InnerText;
                prefijo_factura = xn["Prefijo"].InnerText;

            }


            MessageBox.Show("Numero de factura = " + numero_factura + " Prefijo: " + prefijo_factura);

            return url;


        }

        public void descargarYMostrarComprobante(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(url, Path.GetTempPath() + "Comprobante_" + 3 + ".pdf");
                    System.Diagnostics.Process.Start(Path.GetTempPath() + "Comprobante_" + 3 + ".pdf");
                }
                catch (FileLoadException ex) { Console.Write(ex); }
            }
        }

        public string[] obtenerDatosComprobanteVenta(string id_comprobante)
        {


            ListadoComprobantesRequest request = new ListadoComprobantesRequest();
            ComprobantesClient comprobanteClient = new ComprobantesClient();



            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "comercial@omegadistribuidora.com";
            request.Autenticacion.Hash = "comercial";
            request.Autenticacion.Empresa = 6348; //[Identificador de la empresa a la que pertenece el usuario]
            request.IdComprobante = Convert.ToInt32(id_comprobante);

            ListadoComprobantesResponse response = comprobanteClient.ListadoComprobantes(request);

            string[] retorno = new string[3];
            retorno[0] = string.Empty;
            retorno[1] = string.Empty;
            retorno[2] = string.Empty;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(ObjectToXml<ListadoComprobantesResponse>(response)); // suppose that myXmlString contains "<Names>...</Names>"
            Console.WriteLine(ObjectToXml<ListadoComprobantesResponse>(response));
            XmlNodeList xnList = xml.SelectNodes("/ListadoComprobantesResponse/ListadoComprobantes/Comprobante");
            foreach (XmlNode xn in xnList)
            {
                retorno[0] = xn["URLPDF"].InnerText;
                retorno[2] = xn["Numero"].InnerText;
                retorno[1] = xn["Prefijo"].InnerText;

            }

            return retorno;


        }


    }
}
