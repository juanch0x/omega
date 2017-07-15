using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturanteMVC.API;
using FacturanteMVC.API.DTOs;
using System.Windows.Forms;
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

            ComprobantesClient comprobanteClient = new ComprobantesClient();

            CrearComprobanteRequest request = new CrearComprobanteRequest();
            request.Autenticacion = new Autenticacion();
            request.Autenticacion.Usuario = "[usuario]";
            request.Autenticacion.Hash = "[contraseña]";
            request.Autenticacion.Empresa = 0; //[Identificador de la empresa a la que pertenece el usuario]

            request.Cliente = new Cliente();
            request.Cliente.CodigoPostal = "5500";
            request.Cliente.CondicionPago = 1;
            request.Cliente.Contacto = "Jorge Catalino de la Cruz";
            request.Cliente.DireccionFiscal = "Av. SiempreViva 444";
            request.Cliente.EnviarComprobante = true;
            request.Cliente.Localidad = "Mendoza";
            request.Cliente.MailContacto = "thejuasz@gmail.com";
            request.Cliente.MailFacturacion = "thejuasz@gmail.com";
            request.Cliente.NroDocumento = "38491829";
            request.Cliente.PercibeIIBB = false;
            request.Cliente.PercibeIVA = false;
            request.Cliente.Provincia = "Mendoza";
            request.Cliente.RazonSocial = "La tarbetna de Moe's";
            request.Cliente.Telefono = "4251869";
            request.Cliente.TipoDocumento = 1;
            request.Cliente.TratamientoImpositivo = 3;

            request.Encabezado = new ComprobanteEncabezado();
            request.Encabezado.Bienes = 2;
            request.Encabezado.CondicionVenta = 1;
            request.Encabezado.EnviarComprobante = true;
            request.Encabezado.FechaHora = new DateTime(2015, 09, 30);
            request.Encabezado.FechaServDesde = new DateTime(2015, 09, 30);
            request.Encabezado.FechaServHasta = new DateTime(2015, 10, 05);
            request.Encabezado.FechaVtoPago = new DateTime(2015, 10, 05);
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
            request.Encabezado.TipoComprobante = "FB";
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

            MessageBox.Show(ObjectToXml<CrearComprobanteResponse>(response));
            comprobanteClient.Close();
        }


    }
}
