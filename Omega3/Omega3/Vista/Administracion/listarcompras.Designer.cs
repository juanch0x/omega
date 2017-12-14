namespace Omega3.Vista.Administracion
{
    partial class listarcompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.panel_tabla = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.linkLabel_limpiar_filtro = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.filtro_estado_venta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtro_factura = new System.Windows.Forms.TextBox();
            this.txt_filtro_razon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel_tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 0);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(1104, 241);
            this.dgv_tabla.TabIndex = 4;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            this.dgv_tabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tabla_CellFormatting);
            // 
            // panel_tabla
            // 
            this.panel_tabla.Controls.Add(this.dgv_tabla);
            this.panel_tabla.Location = new System.Drawing.Point(3, 115);
            this.panel_tabla.Name = "panel_tabla";
            this.panel_tabla.Size = new System.Drawing.Size(1104, 241);
            this.panel_tabla.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hasta";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hasta.Location = new System.Drawing.Point(338, 68);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(87, 20);
            this.txt_hasta.TabIndex = 34;
            this.txt_hasta.ValueChanged += new System.EventHandler(this.txt_hasta_ValueChanged);
            // 
            // txt_desde
            // 
            this.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_desde.Location = new System.Drawing.Point(84, 67);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(96, 20);
            this.txt_desde.TabIndex = 33;
            this.txt_desde.ValueChanged += new System.EventHandler(this.txt_desde_ValueChanged);
            // 
            // linkLabel_limpiar_filtro
            // 
            this.linkLabel_limpiar_filtro.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_limpiar_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_limpiar_filtro.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_limpiar_filtro.Location = new System.Drawing.Point(996, 12);
            this.linkLabel_limpiar_filtro.Name = "linkLabel_limpiar_filtro";
            this.linkLabel_limpiar_filtro.Size = new System.Drawing.Size(101, 20);
            this.linkLabel_limpiar_filtro.TabIndex = 29;
            this.linkLabel_limpiar_filtro.TabStop = true;
            this.linkLabel_limpiar_filtro.Text = "Limpiar Filtros";
            this.linkLabel_limpiar_filtro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_limpiar_filtro_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estado";
            // 
            // filtro_estado_venta
            // 
            this.filtro_estado_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtro_estado_venta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_estado_venta.FormattingEnabled = true;
            this.filtro_estado_venta.Items.AddRange(new object[] {
            "Todos",
            "Cobrado",
            "Pendiente"});
            this.filtro_estado_venta.Location = new System.Drawing.Point(567, 8);
            this.filtro_estado_venta.Name = "filtro_estado_venta";
            this.filtro_estado_venta.Size = new System.Drawing.Size(121, 24);
            this.filtro_estado_venta.TabIndex = 28;
            this.filtro_estado_venta.Tag = "Cobrado";
            this.filtro_estado_venta.SelectedIndexChanged += new System.EventHandler(this.filtro_estado_venta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nro. Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Proveedor ";
            // 
            // txt_filtro_factura
            // 
            this.txt_filtro_factura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_factura.Location = new System.Drawing.Point(380, 10);
            this.txt_filtro_factura.Name = "txt_filtro_factura";
            this.txt_filtro_factura.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_factura.TabIndex = 27;
            this.txt_filtro_factura.TextChanged += new System.EventHandler(this.txt_filtro_factura_TextChanged);
            // 
            // txt_filtro_razon
            // 
            this.txt_filtro_razon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_razon.Location = new System.Drawing.Point(84, 10);
            this.txt_filtro_razon.Name = "txt_filtro_razon";
            this.txt_filtro_razon.Size = new System.Drawing.Size(145, 22);
            this.txt_filtro_razon.TabIndex = 5;
            this.txt_filtro_razon.TextChanged += new System.EventHandler(this.txt_filtro_razon_TextChanged_1);
            // 
            // listarcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 387);
            this.Controls.Add(this.txt_filtro_razon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.linkLabel_limpiar_filtro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filtro_estado_venta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filtro_factura);
            this.Controls.Add(this.panel_tabla);
            this.Name = "listarcompras";
            this.Text = "listarcompras";
            this.Load += new System.EventHandler(this.listarcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel_tabla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Panel panel_tabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.LinkLabel linkLabel_limpiar_filtro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filtro_estado_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtro_factura;
        private System.Windows.Forms.TextBox txt_filtro_razon;
    }
}