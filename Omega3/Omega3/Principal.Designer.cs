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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erogacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_dolar = new System.Windows.Forms.Label();
            this.panel_dolar = new System.Windows.Forms.Panel();
            this.txt_dolar_guardado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_dolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reparacionesToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.administracionToolStripMenuItem});
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
            this.clienteToolStripMenuItem,
            this.dolarToolStripMenuItem});
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
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // dolarToolStripMenuItem
            // 
            this.dolarToolStripMenuItem.Name = "dolarToolStripMenuItem";
            this.dolarToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.dolarToolStripMenuItem.Text = "Dolar";
            this.dolarToolStripMenuItem.Click += new System.EventHandler(this.dolarToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProveedoresToolStripMenuItem});
            this.proveedorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // administrarProveedoresToolStripMenuItem
            // 
            this.administrarProveedoresToolStripMenuItem.Name = "administrarProveedoresToolStripMenuItem";
            this.administrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.administrarProveedoresToolStripMenuItem.Text = "Administrar Proveedores";
            this.administrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.administrarProveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.presupuestoToolStripMenuItem,
            this.facturanteToolStripMenuItem,
            this.errorToolStripMenuItem,
            this.ventasRealizadasToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.presupuestoToolStripMenuItem.Text = "Presupuesto";
            this.presupuestoToolStripMenuItem.Click += new System.EventHandler(this.presupuestoToolStripMenuItem_Click);
            // 
            // facturanteToolStripMenuItem
            // 
            this.facturanteToolStripMenuItem.Name = "facturanteToolStripMenuItem";
            this.facturanteToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.facturanteToolStripMenuItem.Text = "Facturante";
            this.facturanteToolStripMenuItem.Click += new System.EventHandler(this.facturanteToolStripMenuItem_Click);
            // 
            // errorToolStripMenuItem
            // 
            this.errorToolStripMenuItem.Name = "errorToolStripMenuItem";
            this.errorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.errorToolStripMenuItem.Text = "Error";
            this.errorToolStripMenuItem.Click += new System.EventHandler(this.errorToolStripMenuItem_Click);
            // 
            // ventasRealizadasToolStripMenuItem
            // 
            this.ventasRealizadasToolStripMenuItem.Name = "ventasRealizadasToolStripMenuItem";
            this.ventasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.ventasRealizadasToolStripMenuItem.Text = "Ventas Realizadas";
            this.ventasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.ventasRealizadasToolStripMenuItem_Click);
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reparacionToolStripMenuItem,
            this.crearNToolStripMenuItem});
            this.reparacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            // 
            // reparacionToolStripMenuItem
            // 
            this.reparacionToolStripMenuItem.Name = "reparacionToolStripMenuItem";
            this.reparacionToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.reparacionToolStripMenuItem.Text = "Crear";
            this.reparacionToolStripMenuItem.Click += new System.EventHandler(this.reparacionToolStripMenuItem_Click);
            // 
            // crearNToolStripMenuItem
            // 
            this.crearNToolStripMenuItem.Name = "crearNToolStripMenuItem";
            this.crearNToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.crearNToolStripMenuItem.Text = "Crear_N";
            this.crearNToolStripMenuItem.Click += new System.EventHandler(this.crearNToolStripMenuItem_Click);
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem});
            this.presupuestosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erogacionesToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.cierreDeCajaToolStripMenuItem});
            this.administracionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // erogacionesToolStripMenuItem
            // 
            this.erogacionesToolStripMenuItem.Name = "erogacionesToolStripMenuItem";
            this.erogacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.erogacionesToolStripMenuItem.Text = "Erogaciones";
            this.erogacionesToolStripMenuItem.Click += new System.EventHandler(this.erogacionesToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // txt_dolar
            // 
            this.txt_dolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dolar.AutoSize = true;
            this.txt_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dolar.Location = new System.Drawing.Point(128, 6);
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(58, 16);
            this.txt_dolar.TabIndex = 3;
            this.txt_dolar.Text = "txt_dolar";
            // 
            // panel_dolar
            // 
            this.panel_dolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dolar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel_dolar.Controls.Add(this.txt_dolar_guardado);
            this.panel_dolar.Controls.Add(this.label2);
            this.panel_dolar.Controls.Add(this.label1);
            this.panel_dolar.Controls.Add(this.txt_dolar);
            this.panel_dolar.Location = new System.Drawing.Point(686, 2);
            this.panel_dolar.Name = "panel_dolar";
            this.panel_dolar.Size = new System.Drawing.Size(344, 24);
            this.panel_dolar.TabIndex = 5;
            // 
            // txt_dolar_guardado
            // 
            this.txt_dolar_guardado.AutoSize = true;
            this.txt_dolar_guardado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dolar_guardado.Location = new System.Drawing.Point(296, 6);
            this.txt_dolar_guardado.Name = "txt_dolar_guardado";
            this.txt_dolar_guardado.Size = new System.Drawing.Size(45, 16);
            this.txt_dolar_guardado.TabIndex = 6;
            this.txt_dolar_guardado.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Guardado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dolar: Sugerido";
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de Caja";
            this.cierreDeCajaToolStripMenuItem.Click += new System.EventHandler(this.cierreDeCajaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 491);
            this.Controls.Add(this.panel_dolar);
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
            this.panel_dolar.ResumeLayout(false);
            this.panel_dolar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reabastecimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorToolStripMenuItem;
        private System.Windows.Forms.Label txt_dolar;
        private System.Windows.Forms.Panel panel_dolar;
        private System.Windows.Forms.Label txt_dolar_guardado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erogacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
    }
}

