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
                    cliente.Telefono = long.Parse(txt_telefono.Text);
                    cliente.Provincia = Convert.ToString(combo_provincia.SelectedValue);
                    cliente.Codigo_postal = Convert.ToInt32(txt_cod_postal.Text);
                    cliente.Contacto = txt_contacto.Text;
                    cliente.Localidad = txt_localidad.Text;
                    cliente.Mail_contacto = txt_mail_contacto.Text;
                    cliente.Lista = Convert.ToDecimal(combo_lista.SelectedValue);
                    cliente.Impositiva = Convert.ToString(combo_condicion.SelectedValue);

                    if (Controlador.ControlCliente.ModificarCliente(cliente) == 1)
                    {
                        MessageBox.Show("El cliente fue modificado correctamente");
                        this.Close();
                    }
                    else { MessageBox.Show("Hubo un error, contacte al administrador"); }
                }else { MessageBox.Show("Email invalido");}
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
