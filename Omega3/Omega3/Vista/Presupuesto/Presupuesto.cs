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
namespace Omega3.Vista.Presupuesto
{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            //
            //La funcion GenerateNumber() se utiliza unicamente para generar un Número
            //aleatorio que simulara ser el numerod e factura
           

            //Establecemos la propiedad AutoGenerateColumns en False para evitar que se agreguen
            //nuevas columnas a la derecha de las que creamos en tiempo de diseño.
            //
            dgvdetalle.AutoGenerateColumns = false;
            //
            //Establecemos el DataSource del control DataGridView
            //
            dgvdetalle.DataSource = Omega3.Controlador.ControlPresupuesto.FillDgv();
            //
            //Mapeamos las propiedades de la clase devuelta por la Funcion FillDgv()
            //recuerde que esta funcion devuelve una lista del tipo EArticulo
            //
            dgvdetalle.Columns["columnNumero"].DataPropertyName = "Numero";
            dgvdetalle.Columns["columnCod"].DataPropertyName = "Codigo";
            dgvdetalle.Columns["columnDescripcion"].DataPropertyName = "Descripcion";
            dgvdetalle.Columns["columnCantidad"].DataPropertyName = "Cantidad";
            dgvdetalle.Columns["columnPrecio"].DataPropertyName = "Precio";
            dgvdetalle.Columns["columnImporte"].DataPropertyName = "Importe";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
 
        }
    }
}
