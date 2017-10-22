using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista
{
    public partial class BarraDeProgreso : Form
    {
        public BarraDeProgreso()
        {
            InitializeComponent();
            this.Contador.Start();
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            
            progress.Increment(25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(progress.Value));
        }
    }
}
