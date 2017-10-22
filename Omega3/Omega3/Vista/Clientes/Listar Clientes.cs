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

namespace Omega3.Vista.Clientes
{
    public partial class Listar_Clientes : Form
    {
        public Listar_Clientes()
        {
            InitializeComponent();
            ControlCliente.ListarClientes(dgv_tabla);
        }

    }
}
