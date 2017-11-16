namespace Omega3.Vista.Reparaciones
{
    partial class BuscarCliente
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
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 81);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(541, 135);
            this.dgv_tabla.TabIndex = 9;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Image = global::Omega3.Properties.Resources.Valid_icon;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // txt_razon
            // 
            this.txt_razon.Location = new System.Drawing.Point(378, 36);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(100, 20);
            this.txt_razon.TabIndex = 10;
            this.txt_razon.TextChanged += new System.EventHandler(this.txt_razon_TextChanged);
            this.txt_razon.Enter += new System.EventHandler(this.txt_razon_Enter);
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(90, 36);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 11;
            this.txt_documento.TextChanged += new System.EventHandler(this.txt_documento_TextChanged);
            this.txt_documento.Enter += new System.EventHandler(this.txt_documento_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DNI/C.U.I.T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filtros";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.txt_razon);
            this.Controls.Add(this.dgv_tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarCliente";
            this.ShowIcon = false;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscarCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.TextBox txt_razon;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}