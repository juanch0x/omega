using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Controlador;
using Omega3.Modelo;

namespace Omega3.Vista.Gastos
{
    public partial class RetirarGuita : Form
    {
        public RetirarGuita()
        {
            InitializeComponent();
            txt_usuario.Enabled = false;
            txt_usuario.Text = Usuario.User;
            txt_destino.Tag = "Destino";
            txt_motivo.Tag = "Motivo";
            txt_monto.Tag = "Monto";
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.erogaciones erogacion = new erogaciones();



            if ( ControladorFuncVariadas.validarTextBoxVacios(txt_destino, txt_monto, txt_motivo)) { 
            erogacion.Id_usuario = txt_usuario.Text;
            erogacion.Motivo = txt_motivo.Text;
            erogacion.Destino = txt_destino.Text;
            erogacion.Monto = Convert.ToDecimal(txt_monto.Text);
            erogacion.Tipogasto = txt_tpo_gasto.Text;

            Omega3.Controlador.ControlAdministracion.insertarerogacion(erogacion);
                MessageBox.Show("Se inserto correctamente");

                ControladorFuncVariadas.limpiarTextBox(txt_motivo, txt_monto, txt_destino);
            }
        } 

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omega3.Controlador.ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void RetirarGuita_Load(object sender, EventArgs e)
        {

        }
    }
}
