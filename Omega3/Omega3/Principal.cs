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
            //clientesToolStripMenuItem.Visible = false;


        }

        private ToolStripMenuItem GetProductoToolStripMenuItem()
        {
            return productoToolStripMenuItem;
        }


       

    
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Productos.ABMProductos modificarproducto;// = new Vista.Productos.ModificarProductos();
            //modificarproducto.StartPosition = FormStartPosition.CenterScreen;
            //modificarproducto.MdiParent = this;
            //modificarproducto.Show();

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
    }
    }

