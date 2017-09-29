using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Pedidos
{
    public partial class Confirmar_Pedido : Form
    {

        public TextBox cantidad { get => txt_cantidad; set => txt_cantidad = value; }
        public Confirmar_Pedido()
        {
            InitializeComponent();
        }
    }
}
