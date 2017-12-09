namespace Omega3.Vista.Venta
{
    partial class ListarPresupuestos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_limpiar_filtro = new System.Windows.Forms.LinkLabel();
            this.txt_filtro_razon = new System.Windows.Forms.TextBox();
            this.txt_filtro_npresupuesto = new System.Windows.Forms.TextBox();
            this.panel_tabla = new System.Windows.Forms.Panel();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_filtros.SuspendLayout();
            this.panel_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.label5);
            this.panel_filtros.Controls.Add(this.txt_hasta);
            this.panel_filtros.Controls.Add(this.label4);
            this.panel_filtros.Controls.Add(this.txt_desde);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.linkLabel_limpiar_filtro);
            this.panel_filtros.Controls.Add(this.txt_filtro_razon);
            this.panel_filtros.Controls.Add(this.txt_filtro_npresupuesto);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filtros.Location = new System.Drawing.Point(0, 0);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(1048, 75);
            this.panel_filtros.TabIndex = 5;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hasta.Location = new System.Drawing.Point(668, 23);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(87, 20);
            this.txt_hasta.TabIndex = 21;
            this.txt_hasta.ValueChanged += new System.EventHandler(this.txt_hasta_ValueChanged);
            // 
            // txt_desde
            // 
            this.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_desde.Location = new System.Drawing.Point(497, 23);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(96, 20);
            this.txt_desde.TabIndex = 20;
            this.txt_desde.ValueChanged += new System.EventHandler(this.txt_desde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nro. Presupuesto ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Razón Social ";
            // 
            // linkLabel_limpiar_filtro
            // 
            this.linkLabel_limpiar_filtro.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_limpiar_filtro.AutoSize = true;
            this.linkLabel_limpiar_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_limpiar_filtro.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_limpiar_filtro.Location = new System.Drawing.Point(935, 21);
            this.linkLabel_limpiar_filtro.Name = "linkLabel_limpiar_filtro";
            this.linkLabel_limpiar_filtro.Size = new System.Drawing.Size(101, 20);
            this.linkLabel_limpiar_filtro.TabIndex = 17;
            this.linkLabel_limpiar_filtro.TabStop = true;
            this.linkLabel_limpiar_filtro.Text = "Limpiar Filtros";
            this.linkLabel_limpiar_filtro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_limpiar_filtro_LinkClicked);
            // 
            // txt_filtro_razon
            // 
            this.txt_filtro_razon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_razon.Location = new System.Drawing.Point(104, 21);
            this.txt_filtro_razon.Name = "txt_filtro_razon";
            this.txt_filtro_razon.Size = new System.Drawing.Size(96, 22);
            this.txt_filtro_razon.TabIndex = 15;
            this.txt_filtro_razon.TextChanged += new System.EventHandler(this.txt_filtro_razon_TextChanged);
            // 
            // txt_filtro_npresupuesto
            // 
            this.txt_filtro_npresupuesto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_npresupuesto.Location = new System.Drawing.Point(350, 23);
            this.txt_filtro_npresupuesto.Name = "txt_filtro_npresupuesto";
            this.txt_filtro_npresupuesto.Size = new System.Drawing.Size(51, 22);
            this.txt_filtro_npresupuesto.TabIndex = 16;
            this.txt_filtro_npresupuesto.TextChanged += new System.EventHandler(this.txt_filtro_npresupuesto_TextChanged);
            // 
            // panel_tabla
            // 
            this.panel_tabla.Controls.Add(this.dgv_tabla);
            this.panel_tabla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tabla.Location = new System.Drawing.Point(0, 81);
            this.panel_tabla.Name = "panel_tabla";
            this.panel_tabla.Size = new System.Drawing.Size(1048, 418);
            this.panel_tabla.TabIndex = 6;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 0);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(1048, 418);
            this.dgv_tabla.TabIndex = 5;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            this.dgv_tabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tabla_CellFormatting);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hasta";
            // 
            // ListarPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 499);
            this.Controls.Add(this.panel_tabla);
            this.Controls.Add(this.panel_filtros);
            this.Name = "ListarPresupuestos";
            this.Text = "ListarPresupuestos";
            this.Resize += new System.EventHandler(this.ListarPresupuestos_Resize);
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.panel_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Panel panel_tabla;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_limpiar_filtro;
        private System.Windows.Forms.TextBox txt_filtro_razon;
        private System.Windows.Forms.TextBox txt_filtro_npresupuesto;
        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}