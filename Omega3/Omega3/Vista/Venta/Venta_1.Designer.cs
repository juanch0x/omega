namespace Omega3.Vista.Venta
{
    partial class Venta_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta_1));
            this.combo_pago = new System.Windows.Forms.ComboBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.fecha_pago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.combo_cliente = new System.Windows.Forms.ComboBox();
            this.filtro_cuit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_principal = new System.Windows.Forms.TabControl();
            this.tab_cliente = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.Label();
            this.domicilio = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.Label();
            this.lbl_condicion = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.razon = new System.Windows.Forms.Label();
            this.tab_venta = new System.Windows.Forms.TabPage();
            this.btn_presupuesto = new System.Windows.Forms.Button();
            this.btn_no_factura = new System.Windows.Forms.Button();
            this.panel_ventas_detalle = new System.Windows.Forms.Panel();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_ventas_item = new System.Windows.Forms.Panel();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ventas_subtotal = new System.Windows.Forms.TextBox();
            this.txt_ventas_iva = new System.Windows.Forms.TextBox();
            this.txt_ventas_lista = new System.Windows.Forms.TextBox();
            this.txt_ventas_precio = new System.Windows.Forms.TextBox();
            this.txt_ventas_codigo = new System.Windows.Forms.TextBox();
            this.txt_ventas_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_venta_subtotal = new System.Windows.Forms.Label();
            this.lbl_venta_iva = new System.Windows.Forms.Label();
            this.lbl_venta_lista = new System.Windows.Forms.Label();
            this.lbl_venta_precio = new System.Windows.Forms.Label();
            this.lbl_venta_descripcion = new System.Windows.Forms.Label();
            this.lbl_venta_codigo = new System.Windows.Forms.Label();
            this.lbl_venta_cantidad = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.panel_cliente.SuspendLayout();
            this.panel_principal.SuspendLayout();
            this.tab_cliente.SuspendLayout();
            this.panel_datos.SuspendLayout();
            this.tab_venta.SuspendLayout();
            this.panel_ventas_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel_ventas_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_pago
            // 
            this.combo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pago.FormattingEnabled = true;
            this.combo_pago.Location = new System.Drawing.Point(240, 18);
            this.combo_pago.Name = "combo_pago";
            this.combo_pago.Size = new System.Drawing.Size(169, 21);
            this.combo_pago.TabIndex = 5;
            this.combo_pago.SelectedIndexChanged += new System.EventHandler(this.combo_pago_SelectedIndexChanged);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.fecha_pago);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.combo_pago);
            this.Panel.Location = new System.Drawing.Point(192, 360);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(693, 61);
            this.Panel.TabIndex = 6;
            // 
            // fecha_pago
            // 
            this.fecha_pago.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_pago.Location = new System.Drawing.Point(424, 18);
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.Size = new System.Drawing.Size(200, 20);
            this.fecha_pago.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Condición de Venta:";
            // 
            // panel_cliente
            // 
            this.panel_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cliente.Controls.Add(this.btn_buscar);
            this.panel_cliente.Controls.Add(this.btn_nuevo);
            this.panel_cliente.Controls.Add(this.combo_cliente);
            this.panel_cliente.Controls.Add(this.filtro_cuit);
            this.panel_cliente.Controls.Add(this.label4);
            this.panel_cliente.Location = new System.Drawing.Point(192, 53);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(693, 56);
            this.panel_cliente.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(505, 17);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 20);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 6;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(424, 17);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 20);
            this.btn_nuevo.TabIndex = 14;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // combo_cliente
            // 
            this.combo_cliente.FormattingEnabled = true;
            this.combo_cliente.Location = new System.Drawing.Point(11, 16);
            this.combo_cliente.Name = "combo_cliente";
            this.combo_cliente.Size = new System.Drawing.Size(217, 21);
            this.combo_cliente.TabIndex = 15;
            // 
            // filtro_cuit
            // 
            this.filtro_cuit.Location = new System.Drawing.Point(269, 17);
            this.filtro_cuit.Name = "filtro_cuit";
            this.filtro_cuit.Size = new System.Drawing.Size(149, 20);
            this.filtro_cuit.TabIndex = 13;
            this.filtro_cuit.Enter += new System.EventHandler(this.filtro_cuit_Enter);
            this.filtro_cuit.Leave += new System.EventHandler(this.filtro_cuit_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ó";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 26);
            this.label16.TabIndex = 3;
            this.label16.Text = "Facturación";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(997, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "Siguiente";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.tab_cliente);
            this.panel_principal.Controls.Add(this.tab_venta);
            this.panel_principal.Location = new System.Drawing.Point(2, 2);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.SelectedIndex = 0;
            this.panel_principal.Size = new System.Drawing.Size(1104, 528);
            this.panel_principal.TabIndex = 14;
            this.panel_principal.SelectedIndexChanged += new System.EventHandler(this.panel_principal_SelectedIndexChanged);
            // 
            // tab_cliente
            // 
            this.tab_cliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_cliente.Controls.Add(this.label17);
            this.tab_cliente.Controls.Add(this.panel_cliente);
            this.tab_cliente.Controls.Add(this.panel_datos);
            this.tab_cliente.Controls.Add(this.Panel);
            this.tab_cliente.Controls.Add(this.button5);
            this.tab_cliente.Controls.Add(this.label16);
            this.tab_cliente.Location = new System.Drawing.Point(4, 22);
            this.tab_cliente.Name = "tab_cliente";
            this.tab_cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cliente.Size = new System.Drawing.Size(1096, 502);
            this.tab_cliente.TabIndex = 0;
            this.tab_cliente.Text = "Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(35, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 26);
            this.label17.TabIndex = 11;
            this.label17.Text = "Datos de Cliente";
            // 
            // panel_datos
            // 
            this.panel_datos.BackColor = System.Drawing.Color.White;
            this.panel_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.Controls.Add(this.lbl_lista);
            this.panel_datos.Controls.Add(this.iva);
            this.panel_datos.Controls.Add(this.domicilio);
            this.panel_datos.Controls.Add(this.email);
            this.panel_datos.Controls.Add(this.cuit);
            this.panel_datos.Controls.Add(this.lbl_condicion);
            this.panel_datos.Controls.Add(this.lbl_domicilio);
            this.panel_datos.Controls.Add(this.lbl_email);
            this.panel_datos.Controls.Add(this.lbl_cuit);
            this.panel_datos.Controls.Add(this.razon);
            this.panel_datos.Location = new System.Drawing.Point(192, 128);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(693, 218);
            this.panel_datos.TabIndex = 12;
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(13, 183);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(58, 20);
            this.lbl_lista.TabIndex = 9;
            this.lbl_lista.Text = "Lista: ";
            // 
            // iva
            // 
            this.iva.AutoSize = true;
            this.iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iva.Location = new System.Drawing.Point(219, 151);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(0, 20);
            this.iva.TabIndex = 8;
            // 
            // domicilio
            // 
            this.domicilio.AutoSize = true;
            this.domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio.Location = new System.Drawing.Point(105, 120);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(0, 20);
            this.domicilio.TabIndex = 7;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(80, 90);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 20);
            this.email.TabIndex = 6;
            // 
            // cuit
            // 
            this.cuit.AutoSize = true;
            this.cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.Location = new System.Drawing.Point(74, 61);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(0, 20);
            this.cuit.TabIndex = 5;
            // 
            // lbl_condicion
            // 
            this.lbl_condicion.AutoSize = true;
            this.lbl_condicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condicion.Location = new System.Drawing.Point(13, 151);
            this.lbl_condicion.Name = "lbl_condicion";
            this.lbl_condicion.Size = new System.Drawing.Size(200, 20);
            this.lbl_condicion.TabIndex = 4;
            this.lbl_condicion.Text = "Condición frente al IVA:";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.Location = new System.Drawing.Point(13, 120);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(86, 20);
            this.lbl_domicilio.TabIndex = 3;
            this.lbl_domicilio.Text = "Domicilio:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(13, 90);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 20);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuit.Location = new System.Drawing.Point(13, 61);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(55, 20);
            this.lbl_cuit.TabIndex = 1;
            this.lbl_cuit.Text = "CUIT:";
            // 
            // razon
            // 
            this.razon.AutoSize = true;
            this.razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razon.Location = new System.Drawing.Point(6, 15);
            this.razon.Name = "razon";
            this.razon.Size = new System.Drawing.Size(153, 26);
            this.razon.TabIndex = 0;
            this.razon.Text = "Razón Social";
            // 
            // tab_venta
            // 
            this.tab_venta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_venta.Controls.Add(this.btn_presupuesto);
            this.tab_venta.Controls.Add(this.btn_no_factura);
            this.tab_venta.Controls.Add(this.panel_ventas_detalle);
            this.tab_venta.Controls.Add(this.panel_ventas_item);
            this.tab_venta.Location = new System.Drawing.Point(4, 22);
            this.tab_venta.Name = "tab_venta";
            this.tab_venta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_venta.Size = new System.Drawing.Size(1096, 502);
            this.tab_venta.TabIndex = 1;
            this.tab_venta.Text = "Venta";
            // 
            // btn_presupuesto
            // 
            this.btn_presupuesto.Location = new System.Drawing.Point(165, 429);
            this.btn_presupuesto.Name = "btn_presupuesto";
            this.btn_presupuesto.Size = new System.Drawing.Size(87, 23);
            this.btn_presupuesto.TabIndex = 3;
            this.btn_presupuesto.Text = "Presupuesto";
            this.btn_presupuesto.UseVisualStyleBackColor = true;
            this.btn_presupuesto.Click += new System.EventHandler(this.btn_presupuesto_Click);
            // 
            // btn_no_factura
            // 
            this.btn_no_factura.Location = new System.Drawing.Point(369, 429);
            this.btn_no_factura.Name = "btn_no_factura";
            this.btn_no_factura.Size = new System.Drawing.Size(75, 23);
            this.btn_no_factura.TabIndex = 2;
            this.btn_no_factura.Text = "No Facturar";
            this.btn_no_factura.UseVisualStyleBackColor = true;
            this.btn_no_factura.Visible = false;
            this.btn_no_factura.Click += new System.EventHandler(this.btn_no_factura_Click);
            // 
            // panel_ventas_detalle
            // 
            this.panel_ventas_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel_ventas_detalle.Controls.Add(this.dgv_tabla);
            this.panel_ventas_detalle.Location = new System.Drawing.Point(6, 100);
            this.panel_ventas_detalle.Name = "panel_ventas_detalle";
            this.panel_ventas_detalle.Size = new System.Drawing.Size(1082, 294);
            this.panel_ventas_detalle.TabIndex = 1;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.dg_iva,
            this.Subtotal,
            this.Lista,
            this.Borrar});
            this.dgv_tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 0);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.Size = new System.Drawing.Size(1082, 294);
            this.dgv_tabla.TabIndex = 0;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 74;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // dg_iva
            // 
            this.dg_iva.Frozen = true;
            this.dg_iva.HeaderText = "IVA";
            this.dg_iva.Name = "dg_iva";
            this.dg_iva.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.Frozen = true;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Lista
            // 
            this.Lista.Frozen = true;
            this.Lista.HeaderText = "Lista";
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.Visible = false;
            // 
            // Borrar
            // 
            this.Borrar.Frozen = true;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // panel_ventas_item
            // 
            this.panel_ventas_item.BackColor = System.Drawing.Color.White;
            this.panel_ventas_item.Controls.Add(this.combo_producto);
            this.panel_ventas_item.Controls.Add(this.button1);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_subtotal);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_iva);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_lista);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_precio);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_codigo);
            this.panel_ventas_item.Controls.Add(this.txt_ventas_cantidad);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_subtotal);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_iva);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_lista);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_precio);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_descripcion);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_codigo);
            this.panel_ventas_item.Controls.Add(this.lbl_venta_cantidad);
            this.panel_ventas_item.Location = new System.Drawing.Point(6, 19);
            this.panel_ventas_item.Name = "panel_ventas_item";
            this.panel_ventas_item.Size = new System.Drawing.Size(1082, 75);
            this.panel_ventas_item.TabIndex = 0;
            // 
            // combo_producto
            // 
            this.combo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Location = new System.Drawing.Point(252, 26);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(319, 24);
            this.combo_producto.TabIndex = 15;
            this.combo_producto.SelectedIndexChanged += new System.EventHandler(this.combo_producto_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // txt_ventas_subtotal
            // 
            this.txt_ventas_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_subtotal.Location = new System.Drawing.Point(865, 28);
            this.txt_ventas_subtotal.Name = "txt_ventas_subtotal";
            this.txt_ventas_subtotal.ReadOnly = true;
            this.txt_ventas_subtotal.Size = new System.Drawing.Size(141, 22);
            this.txt_ventas_subtotal.TabIndex = 13;
            this.txt_ventas_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ventas_iva
            // 
            this.txt_ventas_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_iva.Location = new System.Drawing.Point(781, 28);
            this.txt_ventas_iva.Name = "txt_ventas_iva";
            this.txt_ventas_iva.Size = new System.Drawing.Size(78, 22);
            this.txt_ventas_iva.TabIndex = 12;
            this.txt_ventas_iva.Text = "21";
            this.txt_ventas_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ventas_iva.Leave += new System.EventHandler(this.txt_ventas_iva_Leave);
            // 
            // txt_ventas_lista
            // 
            this.txt_ventas_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_lista.Location = new System.Drawing.Point(692, 28);
            this.txt_ventas_lista.Name = "txt_ventas_lista";
            this.txt_ventas_lista.Size = new System.Drawing.Size(83, 22);
            this.txt_ventas_lista.TabIndex = 11;
            this.txt_ventas_lista.Text = "10";
            this.txt_ventas_lista.TextChanged += new System.EventHandler(this.txt_ventas_lista_TextChanged);
            this.txt_ventas_lista.Enter += new System.EventHandler(this.txt_ventas_lista_Enter);
            this.txt_ventas_lista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ventas_lista_KeyPress);
            // 
            // txt_ventas_precio
            // 
            this.txt_ventas_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_precio.Location = new System.Drawing.Point(577, 28);
            this.txt_ventas_precio.Name = "txt_ventas_precio";
            this.txt_ventas_precio.ReadOnly = true;
            this.txt_ventas_precio.Size = new System.Drawing.Size(109, 22);
            this.txt_ventas_precio.TabIndex = 10;
            this.txt_ventas_precio.Text = "0.00";
            this.txt_ventas_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ventas_codigo
            // 
            this.txt_ventas_codigo.Enabled = false;
            this.txt_ventas_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_codigo.Location = new System.Drawing.Point(91, 28);
            this.txt_ventas_codigo.Name = "txt_ventas_codigo";
            this.txt_ventas_codigo.Size = new System.Drawing.Size(155, 22);
            this.txt_ventas_codigo.TabIndex = 8;
            this.txt_ventas_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ventas_codigo_KeyDown);
            // 
            // txt_ventas_cantidad
            // 
            this.txt_ventas_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventas_cantidad.Location = new System.Drawing.Point(6, 28);
            this.txt_ventas_cantidad.Name = "txt_ventas_cantidad";
            this.txt_ventas_cantidad.Size = new System.Drawing.Size(79, 22);
            this.txt_ventas_cantidad.TabIndex = 7;
            this.txt_ventas_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ventas_cantidad_KeyPress);
            this.txt_ventas_cantidad.Leave += new System.EventHandler(this.txt_ventas_cantidad_Leave);
            // 
            // lbl_venta_subtotal
            // 
            this.lbl_venta_subtotal.AutoSize = true;
            this.lbl_venta_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_subtotal.Location = new System.Drawing.Point(865, 6);
            this.lbl_venta_subtotal.Name = "lbl_venta_subtotal";
            this.lbl_venta_subtotal.Size = new System.Drawing.Size(77, 20);
            this.lbl_venta_subtotal.TabIndex = 6;
            this.lbl_venta_subtotal.Text = "Subtotal";
            // 
            // lbl_venta_iva
            // 
            this.lbl_venta_iva.AutoSize = true;
            this.lbl_venta_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_iva.Location = new System.Drawing.Point(788, 6);
            this.lbl_venta_iva.Name = "lbl_venta_iva";
            this.lbl_venta_iva.Size = new System.Drawing.Size(39, 20);
            this.lbl_venta_iva.TabIndex = 5;
            this.lbl_venta_iva.Text = "IVA";
            // 
            // lbl_venta_lista
            // 
            this.lbl_venta_lista.AutoSize = true;
            this.lbl_venta_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_lista.Location = new System.Drawing.Point(697, 6);
            this.lbl_venta_lista.Name = "lbl_venta_lista";
            this.lbl_venta_lista.Size = new System.Drawing.Size(56, 20);
            this.lbl_venta_lista.TabIndex = 4;
            this.lbl_venta_lista.Text = "Dscto";
            // 
            // lbl_venta_precio
            // 
            this.lbl_venta_precio.AutoSize = true;
            this.lbl_venta_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_precio.Location = new System.Drawing.Point(583, 6);
            this.lbl_venta_precio.Name = "lbl_venta_precio";
            this.lbl_venta_precio.Size = new System.Drawing.Size(59, 20);
            this.lbl_venta_precio.TabIndex = 3;
            this.lbl_venta_precio.Text = "Precio";
            // 
            // lbl_venta_descripcion
            // 
            this.lbl_venta_descripcion.AutoSize = true;
            this.lbl_venta_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_descripcion.Location = new System.Drawing.Point(248, 6);
            this.lbl_venta_descripcion.Name = "lbl_venta_descripcion";
            this.lbl_venta_descripcion.Size = new System.Drawing.Size(103, 20);
            this.lbl_venta_descripcion.TabIndex = 2;
            this.lbl_venta_descripcion.Text = "Descripción";
            // 
            // lbl_venta_codigo
            // 
            this.lbl_venta_codigo.AutoSize = true;
            this.lbl_venta_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_codigo.Location = new System.Drawing.Point(91, 6);
            this.lbl_venta_codigo.Name = "lbl_venta_codigo";
            this.lbl_venta_codigo.Size = new System.Drawing.Size(65, 20);
            this.lbl_venta_codigo.TabIndex = 1;
            this.lbl_venta_codigo.Text = "Código";
            // 
            // lbl_venta_cantidad
            // 
            this.lbl_venta_cantidad.AutoSize = true;
            this.lbl_venta_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta_cantidad.Location = new System.Drawing.Point(4, 6);
            this.lbl_venta_cantidad.Name = "lbl_venta_cantidad";
            this.lbl_venta_cantidad.Size = new System.Drawing.Size(81, 20);
            this.lbl_venta_cantidad.TabIndex = 0;
            this.lbl_venta_cantidad.Text = "Cantidad";
            // 
            // Venta_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1139, 542);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Venta_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venta_1";
            this.Load += new System.EventHandler(this.Venta_1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venta_1_KeyDown);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.panel_cliente.ResumeLayout(false);
            this.panel_cliente.PerformLayout();
            this.panel_principal.ResumeLayout(false);
            this.tab_cliente.ResumeLayout(false);
            this.tab_cliente.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.tab_venta.ResumeLayout(false);
            this.panel_ventas_detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel_ventas_item.ResumeLayout(false);
            this.panel_ventas_item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_pago;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel panel_cliente;
        private System.Windows.Forms.TextBox filtro_cuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ComboBox combo_cliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl panel_principal;
        private System.Windows.Forms.TabPage tab_cliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tab_venta;
        private System.Windows.Forms.Panel panel_ventas_item;
        private System.Windows.Forms.Panel panel_ventas_detalle;
        private System.Windows.Forms.TextBox txt_ventas_subtotal;
        private System.Windows.Forms.TextBox txt_ventas_iva;
        private System.Windows.Forms.TextBox txt_ventas_lista;
        private System.Windows.Forms.TextBox txt_ventas_precio;
        private System.Windows.Forms.TextBox txt_ventas_codigo;
        private System.Windows.Forms.TextBox txt_ventas_cantidad;
        private System.Windows.Forms.Label lbl_venta_subtotal;
        private System.Windows.Forms.Label lbl_venta_iva;
        private System.Windows.Forms.Label lbl_venta_lista;
        private System.Windows.Forms.Label lbl_venta_precio;
        private System.Windows.Forms.Label lbl_venta_descripcion;
        private System.Windows.Forms.Label lbl_venta_codigo;
        private System.Windows.Forms.Label lbl_venta_cantidad;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_no_factura;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Label iva;
        private System.Windows.Forms.Label domicilio;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label cuit;
        private System.Windows.Forms.Label lbl_condicion;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cuit;
        private System.Windows.Forms.Label razon;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.DateTimePicker fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_presupuesto;
    }
}