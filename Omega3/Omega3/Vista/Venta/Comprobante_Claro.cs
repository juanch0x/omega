using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Venta
{
    public partial class Comprobante_Claro : Form
    {
        String url;
        public Comprobante_Claro()
        {
            InitializeComponent();
        }

        public Comprobante_Claro(String url)
        {
            InitializeComponent();
            this.url = url;
            
        }

        private void Comprobante_Claro_Load(object sender, EventArgs e)
        {
             pdfreader.src = this.url;
            
            
        }


    }
}
