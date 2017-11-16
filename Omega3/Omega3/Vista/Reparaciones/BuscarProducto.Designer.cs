namespace Omega3.Vista.Reparaciones
{
    partial class BuscarProducto
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(-2, 33);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(625, 144);
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
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(85, 7);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(170, 20);
            this.txt_producto.TabIndex = 11;
            this.txt_producto.TextChanged += new System.EventHandler(this.txt_producto_TextChanged);
            this.txt_producto.Enter += new System.EventHandler(this.txt_producto_Enter);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(409, 7);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(185, 20);
            this.txt_cod.TabIndex = 12;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            this.txt_cod.Enter += new System.EventHandler(this.txt_cod_Enter);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 176);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.dgv_tabla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewImageColumn Seleccionar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_cod;
    }
}