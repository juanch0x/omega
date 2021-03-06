﻿namespace Omega3.Vista.Pedidos
{
    partial class pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.combo_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_tabla);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 355);
            this.panel1.TabIndex = 0;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 0);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(1086, 355);
            this.dgv_tabla.TabIndex = 8;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            this.dgv_tabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tabla_CellFormatting);
            this.dgv_tabla.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tabla_ColumnHeaderMouseClick);
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Image = global::Omega3.Properties.Resources.Valid_icon;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // combo_filtro
            // 
            this.combo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_filtro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro.FormattingEnabled = true;
            this.combo_filtro.Items.AddRange(new object[] {
            "Todos",
            "Finalizados",
            "Pendientes"});
            this.combo_filtro.Location = new System.Drawing.Point(107, 21);
            this.combo_filtro.Name = "combo_filtro";
            this.combo_filtro.Size = new System.Drawing.Size(121, 24);
            this.combo_filtro.TabIndex = 2;
            this.combo_filtro.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_SelectedIndexChanged);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(12, 23);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(48, 19);
            this.lbl_filtro.TabIndex = 3;
            this.lbl_filtro.Text = "Filtro";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Estado";
            this.dataGridViewImageColumn1.Image = global::Omega3.Properties.Resources.Valid_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 459);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.combo_filtro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.pedidos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.ComboBox combo_filtro;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}