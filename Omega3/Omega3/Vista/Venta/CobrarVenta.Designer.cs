﻿namespace Omega3.Vista.Venta
{
    partial class CobrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_remito = new System.Windows.Forms.TextBox();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.combo_cobrada = new System.Windows.Forms.ComboBox();
            this.btn_agregar_pago = new System.Windows.Forms.Button();
            this.panel_tabla = new System.Windows.Forms.Panel();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_deuda = new System.Windows.Forms.Panel();
            this.lbl_total_pagado = new System.Windows.Forms.Label();
            this.lbl_total_venta = new System.Windows.Forms.Label();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.panel_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_deuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(176, 229);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cobrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº de Factura";
            // 
            // txt_remito
            // 
            this.txt_remito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remito.Location = new System.Drawing.Point(131, 79);
            this.txt_remito.Name = "txt_remito";
            this.txt_remito.Size = new System.Drawing.Size(120, 22);
            this.txt_remito.TabIndex = 6;
            this.txt_remito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_remito_KeyPress);
            // 
            // txt_factura
            // 
            this.txt_factura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_factura.Location = new System.Drawing.Point(131, 105);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.ReadOnly = true;
            this.txt_factura.Size = new System.Drawing.Size(120, 22);
            this.txt_factura.TabIndex = 7;
            this.txt_factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_factura_KeyPress);
            // 
            // combo_cobrada
            // 
            this.combo_cobrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cobrada.Enabled = false;
            this.combo_cobrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cobrada.FormattingEnabled = true;
            this.combo_cobrada.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.combo_cobrada.Location = new System.Drawing.Point(131, 52);
            this.combo_cobrada.Name = "combo_cobrada";
            this.combo_cobrada.Size = new System.Drawing.Size(120, 24);
            this.combo_cobrada.TabIndex = 8;
            // 
            // btn_agregar_pago
            // 
            this.btn_agregar_pago.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_pago.Location = new System.Drawing.Point(65, 229);
            this.btn_agregar_pago.Name = "btn_agregar_pago";
            this.btn_agregar_pago.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_pago.TabIndex = 9;
            this.btn_agregar_pago.Text = "Agregar Pago";
            this.btn_agregar_pago.UseVisualStyleBackColor = true;
            this.btn_agregar_pago.Click += new System.EventHandler(this.btn_agregar_pago_Click);
            // 
            // panel_tabla
            // 
            this.panel_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tabla.Controls.Add(this.dgv_tabla);
            this.panel_tabla.Location = new System.Drawing.Point(299, 12);
            this.panel_tabla.Name = "panel_tabla";
            this.panel_tabla.Size = new System.Drawing.Size(587, 255);
            this.panel_tabla.TabIndex = 11;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(3, 3);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(517, 198);
            this.dgv_tabla.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_cobrada);
            this.panel1.Controls.Add(this.txt_remito);
            this.panel1.Controls.Add(this.btn_agregar_pago);
            this.panel1.Controls.Add(this.txt_factura);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 255);
            this.panel1.TabIndex = 12;
            // 
            // panel_deuda
            // 
            this.panel_deuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_deuda.Controls.Add(this.lbl_deuda);
            this.panel_deuda.Controls.Add(this.lbl_total_venta);
            this.panel_deuda.Controls.Add(this.lbl_total_pagado);
            this.panel_deuda.Location = new System.Drawing.Point(76, 273);
            this.panel_deuda.Name = "panel_deuda";
            this.panel_deuda.Size = new System.Drawing.Size(810, 38);
            this.panel_deuda.TabIndex = 13;
            // 
            // lbl_total_pagado
            // 
            this.lbl_total_pagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_pagado.AutoSize = true;
            this.lbl_total_pagado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pagado.Location = new System.Drawing.Point(677, 17);
            this.lbl_total_pagado.Name = "lbl_total_pagado";
            this.lbl_total_pagado.Size = new System.Drawing.Size(114, 16);
            this.lbl_total_pagado.TabIndex = 0;
            this.lbl_total_pagado.Text = "lbl_total_pagado";
            // 
            // lbl_total_venta
            // 
            this.lbl_total_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_venta.AutoSize = true;
            this.lbl_total_venta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_venta.Location = new System.Drawing.Point(499, 17);
            this.lbl_total_venta.Name = "lbl_total_venta";
            this.lbl_total_venta.Size = new System.Drawing.Size(79, 16);
            this.lbl_total_venta.TabIndex = 1;
            this.lbl_total_venta.Text = "Total Venta";
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda.Location = new System.Drawing.Point(347, 17);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(49, 16);
            this.lbl_deuda.TabIndex = 2;
            this.lbl_deuda.Text = "Deuda";
            // 
            // CobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 315);
            this.Controls.Add(this.panel_deuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_tabla);
            this.Name = "CobrarVenta";
            this.Text = "CobrarVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CobrarVenta_FormClosed);
            this.Load += new System.EventHandler(this.CobrarVenta_Load);
            this.panel_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_deuda.ResumeLayout(false);
            this.panel_deuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_remito;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.ComboBox combo_cobrada;
        private System.Windows.Forms.Button btn_agregar_pago;
        private System.Windows.Forms.Panel panel_tabla;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_deuda;
        private System.Windows.Forms.Label lbl_total_pagado;
        private System.Windows.Forms.Label lbl_total_venta;
        private System.Windows.Forms.Label lbl_deuda;
    }
}