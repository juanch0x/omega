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
namespace Omega3.Vista.Venta
{
    public partial class Ventas_Realizadas : Form
    {
        public Ventas_Realizadas()
        {
            InitializeComponent();
            Omega3.Controlador.ControlVentas.llenar_ventas_realizadas(dgv_tabla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Venta a = new Modelo.Venta();

            if (dgv_tabla.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_tabla.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_tabla.Rows[selectedrowindex];

                a.id = long.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                a.nrofactura = long.Parse(Convert.ToString(selectedRow.Cells[2].Value));
                a.remito = long.Parse(Convert.ToString(selectedRow.Cells["Remito"].Value));

                if (Convert.ToInt32(selectedRow.Cells["Cobrada"].Value) == 1)
                    a.cobrada = true;
                else
                    a.cobrada = false;

                CobrarVenta c = new CobrarVenta(a);
                c.ShowDialog();

            }


            }
        }
}
