﻿using System;
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
using Omega3.Vista.Gastos;
using System.Net;
using System.IO;
using Newtonsoft.Json;

/*
 ventas por cat

SELECT categoria_producto.categoria as 'Categoria',
       sum(round(subtotal,2))  as 'Precio Venta',
       sum(round(
       	if(productos.dolar = 0,
       productos.precio_compra * detalle_venta.cantidad,
       productos.precio_compra * (select valor from valor_dolar where id = 1) * detalle_venta.cantidad)
       	,2)) as 'Precio Compra'
FROM   detalle_venta INNER JOIN productos on detalle_venta.codigo = productos.cod_producto INNER JOIN categoria_producto on productos.id_categoria = categoria_producto.id
GROUP BY productos.id_categoria

lista de productos vendidos por mes

SELECT productos.producto as 'Nombre',
	   productos.cod_producto as 'Codigo',
	   detalle_venta.cantidad as 'Cantidad',
	   productos.precio_compra as 'Precio Compra',
	   detalle_venta.subtotal / detalle_venta.cantidad as 'Precio Venta',
	   detalle_venta.subtotal as 'Total',
       date(venta.fecha_venta)
FROM   detalle_venta INNER JOIN productos on detalle_venta.codigo = productos.cod_producto
					 INNER JOIN venta on detalle_venta.id_venta = venta.id
WHERE  date(venta.fecha_venta) BETWEEN '2018-01-17' and '2018-01-20'
*/



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

                //panel_dolar.BackColor = Color.FromArgb(248, 248, 248);
            }
            else
            {
                //actualizarDolarInternet();

                this.Visible = true;


                login.StartPosition = FormStartPosition.CenterScreen;
                login.MdiParent = this;
                login.Show();

                menuStrip1.Visible = false;
                GetProductoToolStripMenuItem().Visible = false;
                ventasToolStripMenuItem.Visible = false;
                //clientesToolStripMenuItem.Visible = false;

                //panel_dolar.BackColor = Color.FromArgb(248, 248, 248);
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

        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

             

                Vista.Venta.Venta_1 venta;
                bool encontrado = false;
                foreach (Form form in this.MdiChildren)
                {

                    if (form.Name.Equals("Venta_1"))
                    {
                        encontrado = true;
                        form.Show();
                    }

                }

                if (!encontrado)
                {

                    venta = new Vista.Venta.Venta_1(); ;
                    venta.StartPosition = FormStartPosition.CenterScreen;
                    venta.MdiParent = this;
                    venta.Show();
                }

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


            Vista.Reparaciones.Reparacion reparacion;
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Reparacion"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                reparacion = new Vista.Reparaciones.Reparacion(); ;
                reparacion.StartPosition = FormStartPosition.CenterScreen;
                reparacion.MdiParent = this;
                reparacion.Show();
            }


        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Presupuesto.ListaPresupuestos a = new Vista.Presupuesto.ListaPresupuestos();

            a.MdiParent = this;

            a.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DialogResult a = MessageBox.Show("\t¿Esta seguro que quiere cerrar sesión? \n\t¡Todas las ventanas se cerrarán!",
     "¡Alerta!",
     MessageBoxButtons.YesNoCancel,
     MessageBoxIcon.Exclamation,
     MessageBoxDefaultButton.Button1);

            if (a == DialogResult.Yes)
            {
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
            /*  dolar a = new dolar();
              a = JsonConvert.DeserializeObject<dolar>(GETDolar());
              dolar = a.libre + new decimal(0.10);
              txt_dolar.Text = dolar.ToString();

              dolar_guardado = new decimal();
              dolar_guardado = ControlProducto.obtenerValorDolar();

              txt_dolar_guardado.Text = dolar_guardado.ToString();*/

        }

        private void actualizarDolarSinConexion()
        {
            /*
            txt_dolar.Text = "0";
            dolar_guardado = new decimal();
            dolar_guardado = ControlProducto.obtenerValorDolar();
            txt_dolar_guardado.Text = dolar_guardado.ToString();*/

        }

        private void crearNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Reparaciones.Nueva_Reparacion reparacion;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Nueva_Reparacion"))
                {

                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                reparacion = new Vista.Reparaciones.Nueva_Reparacion();
                reparacion.StartPosition = FormStartPosition.CenterScreen;
                reparacion.MdiParent = this;
                reparacion.Show();
            }
        }

        private void ventasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Venta.Ventas_Realizadas ventas;
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Ventas Realizadas"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                ventas = new Vista.Venta.Ventas_Realizadas();
                ventas.StartPosition = FormStartPosition.CenterScreen;
                ventas.MdiParent = this;
                ventas.Show();
            }

        }

        private void erogacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Gastos.RetirarGuita erogacion;
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Erogaciones"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                erogacion = new Vista.Gastos.RetirarGuita();
                erogacion.StartPosition = FormStartPosition.CenterScreen;
                erogacion.MdiParent = this;
                erogacion.Show();
            }


        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Clientes.Modificar_Cliente modificarcliente;

            Modelo.Cliente cliente = new Modelo.Cliente();

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Modificar_Cliente"))
                {

                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                modificarcliente = new Vista.Clientes.Modificar_Cliente(cliente);
                modificarcliente.StartPosition = FormStartPosition.CenterScreen;
                modificarcliente.MdiParent = this;
                modificarcliente.Show();
            }

        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

     

            Vista.Administracion.CierreDeCaja a = new Vista.Administracion.CierreDeCaja();
            a.Show();
            a.crearExcel();
        }

        private void modificarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Vista.Clientes.Modificar_Cliente modificarcliente;

            Modelo.Cliente cliente = new Modelo.Cliente();

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Modificar_Cliente"))
                {

                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                modificarcliente = new Vista.Clientes.Modificar_Cliente(cliente);
                modificarcliente.StartPosition = FormStartPosition.CenterScreen;
                modificarcliente.MdiParent = this;
                modificarcliente.Show();
            }
        }

        private void listarClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Vista.Clientes.Listar_Clientes listarclientes;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Modificar Cliente"))
                {

                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                listarclientes = new Vista.Clientes.Listar_Clientes();
                listarclientes.StartPosition = FormStartPosition.CenterScreen;
                listarclientes.MdiParent = this;
                listarclientes.Show();
            }




        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                Vista.Clientes.CrearCliente a = new Vista.Clientes.CrearCliente();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this;
                a.Show();

            }
        }

        private void crearProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Proveedores.ABMProveedores a = new Vista.Proveedores.ABMProveedores();
            a.MdiParent = this;
            a.Show();


            Vista.Proveedores.ABMProveedores proveedores;
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("ABMProveedores"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                proveedores = new Vista.Proveedores.ABMProveedores(); 
                proveedores.StartPosition = FormStartPosition.CenterScreen;
                proveedores.MdiParent = this;
                proveedores.Show();
            }



        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Vista.Administracion.Compras a = new Vista.Administracion.Compras();
            a.MdiParent = this;
            a.Show();



            Vista.Administracion.Compras compras;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Compras"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                compras = new Vista.Administracion.Compras();
                compras.StartPosition = FormStartPosition.CenterScreen;
                compras.MdiParent = this;
                compras.Show();
            }



        }

        private void listarReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Reparaciones.Reparaciones_Realizadas a;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("Reparaciones_Realizadas"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                a = new Vista.Reparaciones.Reparaciones_Realizadas();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void listarPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Vista.Venta.ListarPresupuestos a;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("ListarPresupuesto"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                a = new Vista.Venta.ListarPresupuestos();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this;
                a.Show();

            }
        }

        private void listarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Vista.Administracion.listarcompras compras;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("listarcompras"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                compras = new Vista.Administracion.listarcompras();
                compras.StartPosition = FormStartPosition.CenterScreen;
                compras.MdiParent = this;
                compras.Show();
            }

        }

        private void erogacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vista.Gastos.RetirarGuita erogacion;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("RetirarGuita"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                erogacion = new Vista.Gastos.RetirarGuita();
                erogacion.StartPosition = FormStartPosition.CenterScreen;
                erogacion.MdiParent = this;
                erogacion.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vista.Clientes.ExportarClientesExcel a = new Vista.Clientes.ExportarClientesExcel();

        }

        private void particularToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(1);

        }

        private void pCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(2);
            
        }

        private void pCOMayoristaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(3);
            
        }

        private void minoristaSfactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(4);

        }

        private void subDistribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(5);

        }

        private void preciosNetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(6); 
                      
        }

        private void exportarListaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Clientes.ExportarClientesExcel a = new Vista.Clientes.ExportarClientesExcel();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ListaPrecios listaprecios = new Vista.Productos.ListaPrecios(10);
        }

        private void ventasPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Vista.Venta.VentasPorCategoria a;
            a = new Vista.Venta.VentasPorCategoria();

        }



        private void ventasRealizadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Vista.Venta.ProductosVendidos ventasRealizadas;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("ProductosVendidos"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                ventasRealizadas = new Vista.Venta.ProductosVendidos();
                ventasRealizadas.StartPosition = FormStartPosition.CenterScreen;
                ventasRealizadas.MdiParent = this;
                ventasRealizadas.Show();
            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            Omega3.Vista.Venta.ProductosVendidos a = new Vista.Venta.ProductosVendidos();
            a.Show();


        }

        private void rendicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            

            Vista.Rendicion.CriterioRendicion criterioRendicion;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("CriterioRendicion"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                criterioRendicion = new Vista.Rendicion.CriterioRendicion();
                criterioRendicion.StartPosition = FormStartPosition.CenterScreen;
                criterioRendicion.MdiParent = this;
                criterioRendicion.Show();
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ControlVentas.mostrarFacturaNegro(13);
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vista.Administracion.CuentaCorriente cuentacorriente;

            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Name.Equals("CuentaCorriente"))
                {
                    encontrado = true;
                    form.Show();
                }

            }

            if (!encontrado)
            {

                cuentacorriente = new Vista.Administracion.CuentaCorriente();
                cuentacorriente.StartPosition = FormStartPosition.CenterScreen;
                cuentacorriente.MdiParent = this;
                cuentacorriente.Show();
            }
        }
    }
    }

    public class dolar
    {

        public decimal libre { get; set; }

    }

            
      
            

            