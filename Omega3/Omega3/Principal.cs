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
using Omega3.Vista;

namespace Omega3
{
    public partial class Principal : Form
    {

        public MenuStrip menu { get => menuStrip1; set => menuStrip1 = value; }

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_load(object sender, EventArgs e)
        {

            this.Visible = true;

            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.MdiParent = this;
            login.Show();

            menuStrip1.Visible = false;
            GetProductoToolStripMenuItem().Visible = false;
            ventasToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;


        }

        private ToolStripMenuItem GetProductoToolStripMenuItem()
        {
            return productoToolStripMenuItem;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            
            //IMPORTANTISIMO//
           // Esta función hace que se conviertan las COMAS de todo el proyecto a puntos, si esta función no está, no se puede insertar los decimales en MYSQL//
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Producto a = new Producto();
            a.Nombre_producto = "Ahora se llama diferente";
            a.Precio_costo = 55.5m;
            a.Precio_venta = 55.111m;
            a.Cod_producto = 14;
            a.Cantidad = 100;

            ControlProducto.EliminarProducto(a);

        }


    }
}
