using System;

namespace Omega3
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reabastecimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuidoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.particularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCOMayoristaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferreteriaYViverosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minoristaSfactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subDistribuidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosNetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reparaciones_Realizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarListaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erogacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRealizadasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reparacionesToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductoToolStripMenuItem,
            this.solicitarStockToolStripMenuItem,
            this.reabastecimientoToolStripMenuItem,
            this.dolarToolStripMenuItem,
            this.listaDePreciosToolStripMenuItem});
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // administrarProductoToolStripMenuItem
            // 
            this.administrarProductoToolStripMenuItem.Name = "administrarProductoToolStripMenuItem";
            this.administrarProductoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.administrarProductoToolStripMenuItem.Text = "Administrar Productos";
            this.administrarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // solicitarStockToolStripMenuItem
            // 
            this.solicitarStockToolStripMenuItem.Name = "solicitarStockToolStripMenuItem";
            this.solicitarStockToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.solicitarStockToolStripMenuItem.Text = "Solicitar Stock";
            this.solicitarStockToolStripMenuItem.Click += new System.EventHandler(this.solicitarStockToolStripMenuItem_Click);
            // 
            // reabastecimientoToolStripMenuItem
            // 
            this.reabastecimientoToolStripMenuItem.Name = "reabastecimientoToolStripMenuItem";
            this.reabastecimientoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.reabastecimientoToolStripMenuItem.Text = "Reabastecimiento";
            this.reabastecimientoToolStripMenuItem.Click += new System.EventHandler(this.reabastecimientoToolStripMenuItem_Click);
            // 
            // dolarToolStripMenuItem
            // 
            this.dolarToolStripMenuItem.Name = "dolarToolStripMenuItem";
            this.dolarToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.dolarToolStripMenuItem.Text = "Dolar";
            this.dolarToolStripMenuItem.Click += new System.EventHandler(this.dolarToolStripMenuItem_Click);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribuidoraToolStripMenuItem,
            this.ferreteriaYViverosToolStripMenuItem,
            this.preciosNetosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            // 
            // distribuidoraToolStripMenuItem
            // 
            this.distribuidoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.particularToolStripMenuItem1,
            this.pCOToolStripMenuItem,
            this.pCOMayoristaToolStripMenuItem1});
            this.distribuidoraToolStripMenuItem.Name = "distribuidoraToolStripMenuItem";
            this.distribuidoraToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.distribuidoraToolStripMenuItem.Text = "Distribuidora";
            // 
            // particularToolStripMenuItem1
            // 
            this.particularToolStripMenuItem1.Name = "particularToolStripMenuItem1";
            this.particularToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.particularToolStripMenuItem1.Text = "Particular";
            this.particularToolStripMenuItem1.Click += new System.EventHandler(this.particularToolStripMenuItem1_Click);
            // 
            // pCOToolStripMenuItem
            // 
            this.pCOToolStripMenuItem.Name = "pCOToolStripMenuItem";
            this.pCOToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pCOToolStripMenuItem.Text = "PCO";
            this.pCOToolStripMenuItem.Click += new System.EventHandler(this.pCOToolStripMenuItem_Click);
            // 
            // pCOMayoristaToolStripMenuItem1
            // 
            this.pCOMayoristaToolStripMenuItem1.Name = "pCOMayoristaToolStripMenuItem1";
            this.pCOMayoristaToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.pCOMayoristaToolStripMenuItem1.Text = "PCO Mayorista";
            this.pCOMayoristaToolStripMenuItem1.Click += new System.EventHandler(this.pCOMayoristaToolStripMenuItem1_Click);
            // 
            // ferreteriaYViverosToolStripMenuItem
            // 
            this.ferreteriaYViverosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minoristaSfactToolStripMenuItem,
            this.subDistribuidorToolStripMenuItem});
            this.ferreteriaYViverosToolStripMenuItem.Name = "ferreteriaYViverosToolStripMenuItem";
            this.ferreteriaYViverosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.ferreteriaYViverosToolStripMenuItem.Text = "Ferreteria y Viveros";
            // 
            // minoristaSfactToolStripMenuItem
            // 
            this.minoristaSfactToolStripMenuItem.Name = "minoristaSfactToolStripMenuItem";
            this.minoristaSfactToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.minoristaSfactToolStripMenuItem.Text = "Minorista s/fact";
            this.minoristaSfactToolStripMenuItem.Click += new System.EventHandler(this.minoristaSfactToolStripMenuItem_Click);
            // 
            // subDistribuidorToolStripMenuItem
            // 
            this.subDistribuidorToolStripMenuItem.Name = "subDistribuidorToolStripMenuItem";
            this.subDistribuidorToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.subDistribuidorToolStripMenuItem.Text = "Sub-Distribuidor";
            this.subDistribuidorToolStripMenuItem.Click += new System.EventHandler(this.subDistribuidorToolStripMenuItem_Click);
            // 
            // preciosNetosToolStripMenuItem
            // 
            this.preciosNetosToolStripMenuItem.Name = "preciosNetosToolStripMenuItem";
            this.preciosNetosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.preciosNetosToolStripMenuItem.Text = "Precios Netos";
            this.preciosNetosToolStripMenuItem.Click += new System.EventHandler(this.preciosNetosToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.ventasRealizadasToolStripMenuItem,
            this.listarPresupuestosToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // ventasRealizadasToolStripMenuItem
            // 
            this.ventasRealizadasToolStripMenuItem.Name = "ventasRealizadasToolStripMenuItem";
            this.ventasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.ventasRealizadasToolStripMenuItem.Text = "Ventas Realizadas";
            this.ventasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.ventasRealizadasToolStripMenuItem_Click);
            // 
            // listarPresupuestosToolStripMenuItem
            // 
            this.listarPresupuestosToolStripMenuItem.Name = "listarPresupuestosToolStripMenuItem";
            this.listarPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.listarPresupuestosToolStripMenuItem.Text = "Listar Presupuestos";
            this.listarPresupuestosToolStripMenuItem.Click += new System.EventHandler(this.listarPresupuestosToolStripMenuItem_Click);
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNToolStripMenuItem,
            this.reparacionToolStripMenuItem,
            this.Reparaciones_Realizadas});
            this.reparacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            // 
            // crearNToolStripMenuItem
            // 
            this.crearNToolStripMenuItem.Name = "crearNToolStripMenuItem";
            this.crearNToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.crearNToolStripMenuItem.Text = "Crear";
            this.crearNToolStripMenuItem.Click += new System.EventHandler(this.crearNToolStripMenuItem_Click);
            // 
            // reparacionToolStripMenuItem
            // 
            this.reparacionToolStripMenuItem.Name = "reparacionToolStripMenuItem";
            this.reparacionToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.reparacionToolStripMenuItem.Text = "Modificar";
            this.reparacionToolStripMenuItem.Click += new System.EventHandler(this.reparacionToolStripMenuItem_Click);
            // 
            // Reparaciones_Realizadas
            // 
            this.Reparaciones_Realizadas.Name = "Reparaciones_Realizadas";
            this.Reparaciones_Realizadas.Size = new System.Drawing.Size(215, 26);
            this.Reparaciones_Realizadas.Text = "Listar Reparaciones";
            this.Reparaciones_Realizadas.Click += new System.EventHandler(this.listarReparacionesToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.clienteToolStripMenuItem1,
            this.proveedoresToolStripMenuItem,
            this.gastosToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.administracionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.toolStripMenuItem2.Text = "Cierre de Caja";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem1,
            this.exportarListaClientesToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // crearClienteToolStripMenuItem
            // 
            this.crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            this.crearClienteToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.crearClienteToolStripMenuItem.Text = "Crear Cliente";
            this.crearClienteToolStripMenuItem.Click += new System.EventHandler(this.crearClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem1
            // 
            this.listarClientesToolStripMenuItem1.Name = "listarClientesToolStripMenuItem1";
            this.listarClientesToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.listarClientesToolStripMenuItem1.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem1.Click += new System.EventHandler(this.listarClientesToolStripMenuItem1_Click);
            // 
            // exportarListaClientesToolStripMenuItem
            // 
            this.exportarListaClientesToolStripMenuItem.Name = "exportarListaClientesToolStripMenuItem";
            this.exportarListaClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.exportarListaClientesToolStripMenuItem.Text = "Exportar Lista Clientes";
            this.exportarListaClientesToolStripMenuItem.Click += new System.EventHandler(this.exportarListaClientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // crearProveedorToolStripMenuItem
            // 
            this.crearProveedorToolStripMenuItem.Name = "crearProveedorToolStripMenuItem";
            this.crearProveedorToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.crearProveedorToolStripMenuItem.Text = "Administrar Proveedor";
            this.crearProveedorToolStripMenuItem.Click += new System.EventHandler(this.crearProveedorToolStripMenuItem_Click);
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erogacionesToolStripMenuItem1,
            this.comprasToolStripMenuItem,
            this.listarComprasToolStripMenuItem});
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.gastosToolStripMenuItem.Text = "Gastos";
            // 
            // erogacionesToolStripMenuItem1
            // 
            this.erogacionesToolStripMenuItem1.Name = "erogacionesToolStripMenuItem1";
            this.erogacionesToolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.erogacionesToolStripMenuItem1.Text = "Erogaciones";
            this.erogacionesToolStripMenuItem1.Click += new System.EventHandler(this.erogacionesToolStripMenuItem1_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // listarComprasToolStripMenuItem
            // 
            this.listarComprasToolStripMenuItem.Name = "listarComprasToolStripMenuItem";
            this.listarComprasToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.listarComprasToolStripMenuItem.Text = "Listar Compras";
            this.listarComprasToolStripMenuItem.Click += new System.EventHandler(this.listarComprasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorCategoriaToolStripMenuItem,
            this.ventasRealizadasToolStripMenuItem1});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // ventasPorCategoriaToolStripMenuItem
            // 
            this.ventasPorCategoriaToolStripMenuItem.Name = "ventasPorCategoriaToolStripMenuItem";
            this.ventasPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ventasPorCategoriaToolStripMenuItem.Text = "Ventas Por Categoria";
            this.ventasPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorCategoriaToolStripMenuItem_Click);
            // 
            // ventasRealizadasToolStripMenuItem1
            // 
            this.ventasRealizadasToolStripMenuItem1.Name = "ventasRealizadasToolStripMenuItem1";
            this.ventasRealizadasToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ventasRealizadasToolStripMenuItem1.Text = "Ventas Realizadas";
            this.ventasRealizadasToolStripMenuItem1.Click += new System.EventHandler(this.ventasRealizadasToolStripMenuItem1_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 491);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Omega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reabastecimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        
//private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erogacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reparaciones_Realizadas;
        private System.Windows.Forms.ToolStripMenuItem listarPresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuidoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem particularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pCOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCOMayoristaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ferreteriaYViverosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minoristaSfactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subDistribuidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosNetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarListaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasRealizadasToolStripMenuItem1;
    }
}

