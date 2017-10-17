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

namespace Omega3.Vista.Pedidos
{
    public partial class Confirmar_Pedido : Form
    {

        //public TextBox cantidad { get => txt_cantidad; set => txt_cantidad = value; }
        public int id_pedido;
        public DataGridView dgv_tabla;
        public Confirmar_Pedido(int id_pedido, DataGridView dgv_tabla)
        {
            InitializeComponent();
            this.id_pedido = id_pedido;
            this.dgv_tabla = dgv_tabla;

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int error;

            if (this.validarTextboxVacios()) {

                error = Omega3.Controlador.ControlPedidos.modificarPedido(Convert.ToInt32(txt_cantidad.Text), id_pedido);
                if (error == 1) { MessageBox.Show("Datos actualizados correctamente"); }
                else { MessageBox.Show("Hubo un error"); }
                this.Close();
            }
        }

        private void Confirmar_Pedido_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private bool validarTextboxVacios()
        {
            if (txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo cantidad es obligatorio!");
                txt_cantidad.Focus();
                return false;
            }
            return true;
        }

    }
}
