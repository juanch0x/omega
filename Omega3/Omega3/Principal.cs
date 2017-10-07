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
using Omega3.Vista.Productos;
using Omega3.Vista.Pedidos;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace Omega3
{
    public partial class Principal : Form
    {
        
        public MenuStrip menu { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem MenuVentas { get => ventasToolStripMenuItem; set => ventasToolStripMenuItem = value; }
        public ToolStripMenuItem MenuProducto { get => productoToolStripMenuItem; set => productoToolStripMenuItem = value; }
        public decimal dolar;
        public decimal dolar_guardado;

        public Principal()
        {
            InitializeComponent();
        }

        string GETDolar()
        {
            string url = "http://ws.geeklab.com.ar/dolar/get-dolar-json.php";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();

                }
                throw;
            }
        }

        private void Principal_load(object sender, EventArgs e)
        {

            Login login = new Login();
            if (!ControladorFuncVariadas.AccesoInternet())
            {
                MessageBox.Show("No hay internet!");
                actualizarDolarSinConexion();
                this.Visible = true;

                
                login.StartPosition = FormStartPosition.CenterScreen;
                login.MdiParent = this;
                login.Show();

                menuStrip1.Visible = false;
                GetProductoToolStripMenuItem().Visible = false;
                ventasToolStripMenuItem.Visible = false;
                //clientesToolStripMenuItem.Visible = false;

                panel_dolar.BackColor = Color.FromArgb(248, 248, 248);
            }
            else
            {
                actualizarDolarInternet();

                this.Visible = true;


                login.StartPosition = FormStartPosition.CenterScreen;
                login.MdiParent = this;
                login.Show();

                menuStrip1.Visible = false;
                GetProductoToolStripMenuItem().Visible = false;
                ventasToolStripMenuItem.Visible = false;
                //clientesToolStripMenuItem.Visible = false;

                panel_dolar.BackColor = Color.FromArgb(248, 248, 248);
            }

        }

        private ToolStripMenuItem GetProductoToolStripMenuItem()
        {
            return productoToolStripMenuItem;
        }


    
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ABMProductos modificarproducto;// = new Vista.Productos.ModificarProductos();
           
        
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {
                
                if (form.Name.Equals("ABMProductos"))
                {
                    
                    encontrado = true;
                    form.Show();
                }
                
            }

            if (!encontrado)
            {
                
                modificarproducto = new ABMProductos();
                modificarproducto.StartPosition = FormStartPosition.CenterScreen;
                modificarproducto.MdiParent = this;
                modificarproducto.Show();
            }

        }

        private void solicitarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Pedidos.Solicitar_stock solicitarstock;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Solicitar_stock"))
                {

                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                solicitarstock = new Vista.Pedidos.Solicitar_stock();
                solicitarstock.StartPosition = FormStartPosition.CenterScreen;
                solicitarstock.MdiParent = this;
                solicitarstock.Show();
            }
        }

        private void administrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Proveedores.ABMProveedores a = new Vista.Proveedores.ABMProveedores();
            a.MdiParent = this;
            a.Show();

        }

        private void reabastecimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                pedidos a = new pedidos();
                a.MdiParent = this;
                a.Show();

            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                Vista.Clientes.CrearCliente a = new Vista.Clientes.CrearCliente();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this;
                a.Show();

            }
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                Vista.Venta.Venta_1 a = new Vista.Venta.Venta_1();
                a.MdiParent = this;
                a.Show();

            }
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Presupuesto.Presupuesto a = new Vista.Presupuesto.Presupuesto();
            a.MdiParent = this;
            a.Show();
        }

        private void reparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Reparaciones.Reparacion a = new Vista.Reparaciones.Reparacion();
            a.MdiParent = this;
            a.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Presupuesto.ListaPresupuestos a = new Vista.Presupuesto.ListaPresupuestos();

            a.MdiParent = this;

            a.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
           DialogResult a =  MessageBox.Show("\t¿Esta seguro que quiere cerrar sesión? \n\t¡Todas las ventanas se cerrarán!",
    "¡Alerta!",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);

            if(a == DialogResult.Yes) {
                Application.Restart();
            }

        }

        private void facturanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ControlVenta a = new ControlVenta();
            a.Venta();

        }

        private void errorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ControlVenta a = new ControlVenta();
            //a.detalleComprobante();
            Omega3.Vista.Venta.Comprobante_Claro claro = new Vista.Venta.Comprobante_Claro();
            claro.Show();
        }

        private void dolarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            valor_Dolar b = new valor_Dolar(dolar, dolar_guardado);
            b.Show();

        }

        private void actualizarDolarInternet()
        {
            dolar a = new dolar();
            a = JsonConvert.DeserializeObject<dolar>(GETDolar());
            dolar = a.libre + new decimal(0.10);
            txt_dolar.Text = dolar.ToString();

            dolar_guardado = new decimal();
            dolar_guardado = ControlProducto.obtenerValorDolar();

            txt_dolar_guardado.Text = dolar_guardado.ToString();
        }

        private void actualizarDolarSinConexion()
        {

            txt_dolar.Text = "0";
            dolar_guardado = new decimal();
            dolar_guardado = ControlProducto.obtenerValorDolar();
            txt_dolar_guardado.Text = dolar_guardado.ToString();

        }

    }

    public class dolar
    {

        public decimal libre { get; set; }

    }

    }