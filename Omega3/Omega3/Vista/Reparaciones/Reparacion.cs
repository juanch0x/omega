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

namespace Omega3.Vista.Reparaciones
{
    
    public partial class Reparacion : Form
    {
        Omega3.Modelo.Reparacion reparacion = new Modelo.Reparacion();
        

        public Reparacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            reparacion.fecha_salida = DateTime.Now;
            BuscarReparacion a = new BuscarReparacion(ref txt_cliente, ref reparacion);
            a.ShowDialog();
            txt_maquina.Text = reparacion.maquina;
            txt_nmotor.Text = reparacion.id_motor;
            txt_trabajo.Text = reparacion.problema;
            txt_fecha.Value = reparacion.fecha_salida;
           
            MessageBox.Show(Convert.ToString(reparacion.lista));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vista.Reparaciones.BuscarProducto a = new Vista.Reparaciones.BuscarProducto(reparacion);
            a.ShowDialog();
        }
    }
}
