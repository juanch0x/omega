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

namespace Omega3.Vista.Reparaciones
{
    public partial class Nueva_Reparacion : Form
    {
        public Nueva_Reparacion()
        {
            InitializeComponent();
           
        }

        private void crear_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Reparacion a = new Omega3.Modelo.Reparacion();


            if (txt_problema.Text.Trim() != "" && txt_maquina.Text.Trim() != "" && fecha_entrada.Value <= fecha_salida.Value && txt_cliente.Text.Trim()!= "")
            {
                a.documento = long.Parse(txt_cliente.Text);
                a.problema = txt_problema.Text;
                a.fecha_entrada = fecha_entrada.Value;
                a.fecha_salida = fecha_salida.Value;
                a.id_motor = txt_numero_serie.Text;
                a.maquina = txt_maquina.Text;

                Omega3.Controlador.ControlReparaciones.AgregarReparacion(a);
                MessageBox.Show("SE AGREGO CORRECTAMENTE");
                limpiarcampos();
            }
            else
                MessageBox.Show("Compruebe uno de los siguientes errores:\n 1)Hay campos incompletos \n 2)La fecha de salida no puede ser anterior a la fecha actual");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
            BuscarCliente a = new BuscarCliente(ref txt_cliente);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
           
        }

        private void limpiarcampos()
        {
            txt_cliente.Text = "";
            txt_problema.Text = "";
            fecha_entrada.Value = DateTime.Now;
            fecha_salida.Value = DateTime.Now;
            txt_numero_serie.Text = "";
             txt_maquina.Text="";


        }
    }
}
