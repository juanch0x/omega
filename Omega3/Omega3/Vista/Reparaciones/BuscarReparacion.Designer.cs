namespace Omega3.Vista.Reparaciones
{
    partial class BuscarReparacion
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Seleccionar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 40);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(804, 133);
            this.dgv_tabla.TabIndex = 10;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Image = global::Omega3.Properties.Resources.Valid_icon;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Seleccionar";
            this.dataGridViewImageColumn1.Image = global::Omega3.Properties.Resources.Valid_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(127, 10);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(100, 20);
            this.txt_filtro.TabIndex = 11;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtrar por cliente";
            // 
            // BuscarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dgv_tabla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarReparacion";
            this.Text = "Buscar Reparaciones";
            this.Load += new System.EventHandler(this.BuscarReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Label label1;
    }
}