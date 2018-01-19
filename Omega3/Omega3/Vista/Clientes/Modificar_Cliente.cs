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

namespace Omega3.Vista.Clientes
{
    public partial class Modificar_Cliente : Form
    {
        Cliente cliente = new Cliente();

        public Modificar_Cliente(Cliente cliente)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            this.cliente = cliente;
            txt_documento.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Controlador.ControladorFuncVariadas.validarTextBoxVacios(txt_documento, txt_razon_social, txt_direccion, txt_telefono, txt_cod_postal, txt_contacto, txt_localidad, txt_mail_contacto))
            {
                if (Controlador.ControladorFuncVariadas.validarEmail(txt_mail_contacto.Text))
                {

                    cliente.Documento = long.Parse(txt_documento.Text);
                    cliente.Razon = txt_razon_social.Text;
                    cliente.Direccion = txt_direccion.Text;
                    if (txt_telefono.Text.Trim() != "" || !string.IsNullOrEmpty(txt_telefono.Text))
                    {
                        cliente.Telefono = long.Parse(txt_telefono.Text);
                    }
                    cliente.Provincia = Convert.ToString(combo_provincia.SelectedValue);
                    if (txt_cod_postal.Text.Trim() != "" || !string.IsNullOrEmpty(txt_cod_postal.Text.Trim()))
                        cliente.Codigo_postal = Convert.ToInt32(txt_cod_postal.Text);
                    cliente.Contacto = txt_contacto.Text;
                    cliente.Localidad = txt_localidad.Text;
                    cliente.Mail_contacto = txt_mail_contacto.Text;
                    cliente.Lista = Convert.ToDecimal(combo_lista.SelectedValue);
                    cliente.Impositiva = Convert.ToString(combo_condicion.SelectedValue);

                    cliente.Nombre1 = txt_nombre1.Text;
                    cliente.Nombre1 = txt_nombre2.Text;
                    cliente.Nombre3 = txt_nombre3.Text;
                    cliente.Email1 = txt_email1.Text;
                    cliente.Email2 = txt_email2.Text;
                    cliente.Email3 = txt_email3.Text;
                    cliente.Telefono1 = txt_telefono1.Text;
                    cliente.Telefono2 = txt_telefono2.Text;
                    cliente.Telefono3 = txt_telefono3.Text;
                    cliente.Plazo = txt_plazo.Text;
                    cliente.Flete = txt_flete.Text;
                    if (txt_limite.Text.Trim() != "" || !string.IsNullOrEmpty(txt_limite.Text))
                    {
                        cliente.Maximo_credito = Convert.ToDecimal(txt_limite.Text);
                    }

                    

                    if (Controlador.ControlCliente.ModificarCliente(cliente) == 1)
                    {
                        MessageBox.Show("El cliente fue modificado correctamente");
                        this.Close();
                    }
                    else { MessageBox.Show("Hubo un error, contacte al administrador"); }
                }
                else { MessageBox.Show("Email invalido"); }
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void Modificar_Cliente_Load(object sender, EventArgs e)
        {
            ControlCliente.llenarProvincias(combo_provincia);
            ControlCliente.llenarListas(combo_lista);
            ControlVentas.llenarCondicion(combo_condicion);


            cliente = ControlCliente.obtenerCliente(cliente.Documento);

            //lleno los textbox

            txt_documento.Text = Convert.ToString(cliente.Documento);
            txt_razon_social.Text = cliente.Razon;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = Convert.ToString(cliente.Telefono);
            combo_provincia.SelectedValue = cliente.Cod_provincia;
            txt_cod_postal.Text = Convert.ToString(cliente.Codigo_postal);
            txt_contacto.Text = cliente.Contacto;
            txt_localidad.Text = cliente.Localidad;
            txt_mail_contacto.Text = cliente.Mail_contacto;
            combo_lista.SelectedValue = cliente.Lista;
            combo_condicion.SelectedValue = cliente.Impositiva_Id;
        }
    }
}
