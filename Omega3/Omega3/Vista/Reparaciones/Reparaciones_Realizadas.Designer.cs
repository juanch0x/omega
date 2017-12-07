namespace Omega3.Vista.Reparaciones
{
    partial class Reparaciones_Realizadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.filtro_estado_venta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtro_factura = new System.Windows.Forms.TextBox();
            this.txt_filtro_razon = new System.Windows.Forms.TextBox();
            this.linkLabel_limpiar_filtro = new System.Windows.Forms.LinkLabel();
            this.txt_maquina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_tabla);
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 375);
            this.panel1.TabIndex = 0;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 3);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(1228, 422);
            this.dgv_tabla.TabIndex = 4;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            this.dgv_tabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tabla_CellFormatting);
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.label6);
            this.panel_filtros.Controls.Add(this.txt_maquina);
            this.panel_filtros.Controls.Add(this.linkLabel_limpiar_filtro);
            this.panel_filtros.Controls.Add(this.label5);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Controls.Add(this.txt_hasta);
            this.panel_filtros.Controls.Add(this.txt_desde);
            this.panel_filtros.Controls.Add(this.label3);
            this.panel_filtros.Controls.Add(this.filtro_estado_venta);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.txt_filtro_factura);
            this.panel_filtros.Controls.Add(this.txt_filtro_razon);
            this.panel_filtros.Location = new System.Drawing.Point(0, 1);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(1230, 103);
            this.panel_filtros.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hasta";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hasta.Location = new System.Drawing.Point(228, 65);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(87, 20);
            this.txt_hasta.TabIndex = 33;
            this.txt_hasta.ValueChanged += new System.EventHandler(this.txt_hasta_ValueChanged);
            // 
            // txt_desde
            // 
            this.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_desde.Location = new System.Drawing.Point(55, 67);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(96, 20);
            this.txt_desde.TabIndex = 32;
            this.txt_desde.ValueChanged += new System.EventHandler(this.txt_desde_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 31;
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
            this.filtro_estado_venta.Location = new System.Drawing.Point(670, 11);
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
            this.label2.Location = new System.Drawing.Point(346, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nro. Factura  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Razón Social ";
            // 
            // txt_filtro_factura
            // 
            this.txt_filtro_factura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_factura.Location = new System.Drawing.Point(445, 11);
            this.txt_filtro_factura.Name = "txt_filtro_factura";
            this.txt_filtro_factura.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_factura.TabIndex = 27;
            this.txt_filtro_factura.TextChanged += new System.EventHandler(this.txt_filtro_factura_TextChanged);
            // 
            // txt_filtro_razon
            // 
            this.txt_filtro_razon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_razon.Location = new System.Drawing.Point(108, 11);
            this.txt_filtro_razon.Name = "txt_filtro_razon";
            this.txt_filtro_razon.Size = new System.Drawing.Size(145, 22);
            this.txt_filtro_razon.TabIndex = 26;
            this.txt_filtro_razon.TextChanged += new System.EventHandler(this.txt_filtro_razon_TextChanged);
            // 
            // linkLabel_limpiar_filtro
            // 
            this.linkLabel_limpiar_filtro.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_limpiar_filtro.AutoSize = true;
            this.linkLabel_limpiar_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_limpiar_filtro.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_limpiar_filtro.Location = new System.Drawing.Point(1120, 11);
            this.linkLabel_limpiar_filtro.Name = "linkLabel_limpiar_filtro";
            this.linkLabel_limpiar_filtro.Size = new System.Drawing.Size(101, 20);
            this.linkLabel_limpiar_filtro.TabIndex = 36;
            this.linkLabel_limpiar_filtro.TabStop = true;
            this.linkLabel_limpiar_filtro.Text = "Limpiar Filtros";
            this.linkLabel_limpiar_filtro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_limpiar_filtro_LinkClicked);
            // 
            // txt_maquina
            // 
            this.txt_maquina.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txt_maquina.Location = new System.Drawing.Point(911, 17);
            this.txt_maquina.Name = "txt_maquina";
            this.txt_maquina.Size = new System.Drawing.Size(129, 22);
            this.txt_maquina.TabIndex = 37;
            this.txt_maquina.TextChanged += new System.EventHandler(this.txt_maquina_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(843, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Máquina";
            // 
            // Reparaciones_Realizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 482);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Reparaciones_Realizadas";
            this.Text = "Reparaciones Realizadas";
            this.Load += new System.EventHandler(this.Reparaciones_Realizadas_Load);
            this.Resize += new System.EventHandler(this.Reparaciones_Realizadas_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filtro_estado_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtro_factura;
        private System.Windows.Forms.TextBox txt_filtro_razon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maquina;
        private System.Windows.Forms.LinkLabel linkLabel_limpiar_filtro;
    }
}