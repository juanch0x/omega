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
    public partial class BuscarReparacion : Form
    {
        TextBox txt;
        Omega3.Modelo.Reparacion reparacion;
       

        public BuscarReparacion()
        {
            InitializeComponent();
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        public BuscarReparacion(ref TextBox txt, ref Omega3.Modelo.Reparacion reparacion)
        {
            InitializeComponent();
            //reparacion = new Modelo.Reparacion();

            this.txt = txt;
            this.reparacion = reparacion;
           // this.lista = lista;
            

        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void BuscarReparacion_Load(object sender, EventArgs e)
        {
            ControlReparaciones.llenarTablaReparaciones(dgv_tabla);
            dgv_tabla.Columns[0].DisplayIndex = 6;
            dgv_tabla.Columns[7].DisplayIndex = 0;
            //ControlReparaciones.AutoFill(dgv_tabla);
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                txt.Text = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[2].Value);
                reparacion.documento = long.Parse(Convert.ToString((dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[1].Value))); 
                reparacion.problema = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[3].Value);
                reparacion.fecha_salida = Convert.ToDateTime(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[4].Value);
                reparacion.id_motor = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[5].Value);
                reparacion.maquina = Convert.ToString(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[6].Value);
                reparacion.id = Convert.ToInt32(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[7].Value);
                reparacion.lista = Convert.ToDecimal(dgv_tabla.Rows[dgv_tabla.CurrentCell.RowIndex].Cells[8].Value);
                


                this.Close();

            }
        }
    }
}
