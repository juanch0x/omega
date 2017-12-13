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
        ComboBox combo_ventana;
        bool desde_otra_ventana;
        
        public CrearCliente (ref ComboBox combo_ventana)
        {

            this.combo_ventana = combo_ventana;
            desde_otra_ventana = true;
            
            InitializeComponent();
            
        }

        public CrearCliente()
        {
            
            InitializeComponent();
            txt_documento.Visible = false;
            desde_otra_ventana = false;
            
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
            
            txt_documento.MaxLength = 8;
            ControlVentas.llenarCondicion(combo_condicion);
            ControlCliente.llenarProvincias(combo_provincia);
            ControlCliente.llenarTipoDocumento(combo_documento);
            ControlCliente.llenarListas(combo_lista);
            combo_provincia.SelectedIndex = -1;
            combo_lista.SelectedIndex = -1;
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

            if (validarCampos())
            {

                if (combo_documento.SelectedIndex == combo_documento.FindStringExact("DNI") && txt_documento.Text.Trim().Length < 8)
                    MessageBox.Show("El documento está incompleto");
                else if (combo_documento.SelectedIndex == combo_documento.FindStringExact("CUIT") && txt_cuit.Text.Trim().Length < 11)
                    MessageBox.Show("El campo documento está incompleto");
                else if (combo_documento.SelectedIndex == combo_documento.FindStringExact("CUIL") && txt_cuit.Text.Trim().Length < 11)
                    MessageBox.Show("El campo documento está incompleto");

                else
                {

                    if (combo_documento.Text == "DNI")
                        cliente.Documento = long.Parse(txt_documento.Text);
                    else
                        cliente.Documento = long.Parse(txt_cuit.Text);


                    cliente.Tipo_documento = Convert.ToInt32(combo_documento.SelectedValue);
                    cliente.Razon = txt_razon_social.Text;
                    cliente.Direccion = txt_direccion.Text;
                    cliente.Telefono = long.Parse(txt_telefono.Text);
                    cliente.Contacto = txt_contacto.Text;
                    cliente.Mail_contacto = txt_mail_contacto.Text;
                    cliente.Codigo_postal = Convert.ToInt32(txt_cod_postal.Text);
                    cliente.Localidad = txt_localidad.Text;
                    cliente.Impositiva = Convert.ToString(combo_condicion.SelectedValue);
                    cliente.Cod_provincia = Convert.ToInt32(combo_provincia.SelectedValue);
                    cliente.Lista = Convert.ToDecimal( combo_lista.SelectedValue);
                    cliente.Nombre1 = txt_nombre1.Text;
                    cliente.Nombre2 = txt_nombre2.Text;
                    cliente.Nombre3 = txt_nombre3.Text;
                    cliente.Email1 = txt_email1.Text;
                    cliente.Email2 = txt_email2.Text;
                    cliente.Email3 = txt_email3.Text;
                    cliente.Telefono1 = txt_telefono1.Text;
                    cliente.Telefono2 = txt_telefono2.Text;
                    cliente.Telefono3 = txt_telefono3.Text;
                    cliente.Plazo = txt_plazo.Text;
                    cliente.Maximo_credito = Convert.ToDecimal(txt_limite.Text);
                    cliente.Flete = txt_flete.Text;

                    if (!ControlCliente.validardocumento(cliente.Documento))
                    {
                        ControlCliente.AgregarCliente(cliente);

                        MessageBox.Show("El cliente fue agregado correctamente!");

                        if (desde_otra_ventana == true)
                        {
                            ControlVenta.llenarClientes(combo_ventana);
                            combo_ventana.SelectedIndex = combo_ventana.FindStringExact(cliente.Razon);
                            this.Close();

                        }

                        limpiarCampos();
                    }
                    else { MessageBox.Show("El documento ingresado ya existe"); }
                }
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
              //  cargar.Visible = false;
                txt_documento.Text = "";
                txt_documento.Visible = true;
                txt_cuit.Visible = false;
                txt_documento.Focus();
            }
            else { //cargar.Visible = true;
                txt_cuit.Text = "";
                txt_documento.Visible = false;
                txt_cuit.Visible = true;
                txt_cuit.Focus();
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
            combo_provincia.SelectedIndex = -1;

         }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlProveedor.validarCaracteresNumericos(e);
        }

        private void CrearCliente_KeyDown(object sender, KeyEventArgs e)
        {

       
            if (e.KeyCode == Keys.Escape && ControladorFuncVariadas.comboBoxAbierto(combo_provincia,combo_documento,combo_condicion,combo_lista))
            {
                this.Close();
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender,e);
        }

        private void txt_cod_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }


        private bool validarCampos()
        {
            
            if (txt_direccion.Text.Trim() == "")
            {
                MessageBox.Show("La dirección es obligatoria");
                //lbl_direccion.ForeColor = Color.Red;
                txt_direccion.Focus();
                return false;
            }

            ///LISTA
            else if (combo_lista.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una lista");
                //lbl_provincia.ForeColor = Color.Red;
                combo_lista.Focus();
                return false;
            }

            else if(combo_provincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una provincia");
                //lbl_provincia.ForeColor = Color.Red;
                combo_provincia.Focus();
                return false;
            }
            else if (txt_contacto.Text.Trim() == "")
            {
                MessageBox.Show("El contacto es obligatorio");
                //lbl_contacto.ForeColor = Color.Red;
                txt_contacto.Focus();
                return false;
            }
            else if (txt_mail_contacto.Text.Trim() == "")
            {
                MessageBox.Show("El mail de contacto es obligatorio");
                //lbl_mail.ForeColor = Color.Red;
                txt_mail_contacto.Focus();
                return false;
            }else if (txt_mail_contacto.Text.Trim() != "")
            {
                if (!ControladorFuncVariadas.validarEmail(txt_mail_contacto.Text))
                {
                    MessageBox.Show("El E-mail no contiene el formato requerido");
                    return false;
                }
            }

      
            else if(txt_razon_social.Text.Trim() == "")
            {
                MessageBox.Show("La razón social es obligatoria");
                //lbl_razon.ForeColor = Color.Red;
                txt_razon_social.Focus();
                return false;
            }
            else if(txt_telefono.Text.Trim() == "")
            {
                MessageBox.Show("El telefono es obligatorio");
                //lbl_telefono.ForeColor = Color.Red;
                txt_telefono.Focus();
                return false;
            }
            else if (txt_cod_postal.Text.Trim() == "")
            {
                MessageBox.Show("El código postal es obligatorio");
                //lbl_cod_postal.ForeColor = Color.Red;
                txt_cod_postal.Focus();
                return false;
            }
            else if (txt_localidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo localidad es obligatorio");
                //lbl_localidad.ForeColor = Color.Red;
                txt_localidad.Focus();
                return false;
            }
    


            return true;
        }

        private void CrearCliente_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txt_limite_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void datos_generales_Paint(object sender, PaintEventArgs e)
        {

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

