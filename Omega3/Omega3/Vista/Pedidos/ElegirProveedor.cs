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
    public partial class ElegirProveedor : Form
    {
        private Solicitar_stock a;
        public ElegirProveedor()
        {
            InitializeComponent();
        }

        public ElegirProveedor(Solicitar_stock a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void ElegirProveedor_Load(object sender, EventArgs e)
        {

            //Lleno los datos del datagridview
            Omega3.Controlador.ControlProveedor.llenarTabla(tabla_proveedores);

           
            //Hago que solo se pueda seleccionar la fila completa
            tabla_proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //Acomodo el tamaño de las cabaceras al tamaño del datagridview
            Omega3.Controlador.ControlProveedor.AutoFill(tabla_proveedores);

            //Pongo el boton al fondo
            tabla_proveedores.Columns[0].DisplayIndex = 6; // or 1, 2, 3 etc
            tabla_proveedores.Columns[3].HeaderText = "Dirección";
            tabla_proveedores.Columns[5].HeaderText = "Teléfono";



        }


        private void tabla_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                a.proveedor.Text = this.tabla_proveedores[1, e.RowIndex].Value.ToString();
                this.Close();
            }
        }
    }
}
