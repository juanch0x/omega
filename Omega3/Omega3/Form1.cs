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
using System.Globalization;

namespace Omega3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            //IMPORTANTISIMO//
           // Esta función hace que se conviertan las COMAS de todo el proyecto a puntos, si esta función no está, no se puede insertar los decimales en MYSQL//
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Producto a = new Producto();
            a.gsProducto = "Wea";
            a.Precio_costo = 17.5m;
            a.Precio_venta = 99.111m;
            
            a.Cantidad = 2;

            ControlProducto.AgregarProducto(a);

        }
    }
}
