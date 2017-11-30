namespace Omega3.Vista.Venta
{
    partial class Ventas_Realizadas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.filtro_estado_venta = new System.Windows.Forms.ComboBox();
            this.txt_filtro_factura = new System.Windows.Forms.TextBox();
            this.txt_filtro_razon = new System.Windows.Forms.TextBox();
            this.linkLabel_limpiar_filtro = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 64);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(999, 327);
            this.dgv_tabla.TabIndex = 3;
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
            this.filtro_estado_venta.Location = new System.Drawing.Point(578, 14);
            this.filtro_estado_venta.Name = "filtro_estado_venta";
            this.filtro_estado_venta.Size = new System.Drawing.Size(121, 24);
            this.filtro_estado_venta.TabIndex = 2;
            this.filtro_estado_venta.Tag = "Cobrado";
            this.filtro_estado_venta.SelectedIndexChanged += new System.EventHandler(this.filtro_estado_venta_SelectedIndexChanged);
            // 
            // txt_filtro_factura
            // 
            this.txt_filtro_factura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_factura.Location = new System.Drawing.Point(366, 15);
            this.txt_filtro_factura.Name = "txt_filtro_factura";
            this.txt_filtro_factura.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_factura.TabIndex = 1;
            this.txt_filtro_factura.TextChanged += new System.EventHandler(this.txt_filtro_factura_TextChanged);
            // 
            // txt_filtro_razon
            // 
            this.txt_filtro_razon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_razon.Location = new System.Drawing.Point(113, 15);
            this.txt_filtro_razon.Name = "txt_filtro_razon";
            this.txt_filtro_razon.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_razon.TabIndex = 0;
            this.txt_filtro_razon.TextChanged += new System.EventHandler(this.txt_filtro_razon_TextChanged);
            // 
            // linkLabel_limpiar_filtro
            // 
            this.linkLabel_limpiar_filtro.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_limpiar_filtro.AutoSize = true;
            this.linkLabel_limpiar_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_limpiar_filtro.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel_limpiar_filtro.Location = new System.Drawing.Point(910, 18);
            this.linkLabel_limpiar_filtro.Name = "linkLabel_limpiar_filtro";
            this.linkLabel_limpiar_filtro.Size = new System.Drawing.Size(101, 20);
            this.linkLabel_limpiar_filtro.TabIndex = 12;
            this.linkLabel_limpiar_filtro.TabStop = true;
            this.linkLabel_limpiar_filtro.Text = "Limpiar Filtros";
            this.linkLabel_limpiar_filtro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_limpiar_filtro_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Razón Social ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nro. Factura  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado";
            // 
            // Ventas_Realizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_limpiar_filtro);
            this.Controls.Add(this.txt_filtro_razon);
            this.Controls.Add(this.txt_filtro_factura);
            this.Controls.Add(this.filtro_estado_venta);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.button1);
            this.Name = "Ventas_Realizadas";
            this.Text = "Ventas_Realizadas";
            this.Load += new System.EventHandler(this.Ventas_Realizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.ComboBox filtro_estado_venta;
        private System.Windows.Forms.TextBox txt_filtro_factura;
        private System.Windows.Forms.TextBox txt_filtro_razon;
        private System.Windows.Forms.LinkLabel linkLabel_limpiar_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}