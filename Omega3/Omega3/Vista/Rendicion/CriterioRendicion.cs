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

namespace Omega3.Vista.Rendicion
{
    public partial class CriterioRendicion : Form
    {
        public CriterioRendicion()
        {
            InitializeComponent();
        }

        private void CriterioRendicion_Load(object sender, EventArgs e)
        {
            ControlRendiciones.llenarUsuarios(combo_usuarios);
            this.MaximumSize = new Size(254, 293);
            this.MinimumSize = new Size(254, 293);



        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            GenerarRendicion a = new GenerarRendicion(combo_usuarios.Text, txt_desde.Value, txt_hasta.Value);
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
