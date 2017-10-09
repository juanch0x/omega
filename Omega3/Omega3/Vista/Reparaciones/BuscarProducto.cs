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
namespace Omega3.Vista.Reparaciones
{
    public partial class BuscarProducto : Form
    {
        Omega3.Modelo.Reparacion reparacion;
        
        public BuscarProducto()
        {
            InitializeComponent();
        }
        public BuscarProducto(Omega3.Modelo.Reparacion reparacion)
        {
            InitializeComponent();
            this.reparacion = reparacion;

        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
           
            ControlReparaciones.llenarTablaProducto(dgv_tabla,reparacion);
            
        }
    }
}
