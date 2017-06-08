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
        public ToolStripMenuItem MenuVentas { get => ventasToolStripMenuItem; set => ventasToolStripMenuItem = value; }
        public ToolStripMenuItem MenuProducto { get => productoToolStripMenuItem; set => productoToolStripMenuItem = value; }


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


       

    
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ModificarProductos modificarproducto = new Vista.Productos.ModificarProductos();
            modificarproducto.StartPosition = FormStartPosition.CenterScreen;
            modificarproducto.MdiParent = this;
            modificarproducto.Show();
        }
    }
}
