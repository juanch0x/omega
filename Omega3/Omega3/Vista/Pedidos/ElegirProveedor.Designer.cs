namespace Omega3.Vista.Pedidos
{
    partial class ElegirProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabla_proveedores = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabla_proveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 300);
            this.panel1.TabIndex = 14;
            // 
            // tabla_proveedores
            // 
            this.tabla_proveedores.AllowUserToAddRows = false;
            this.tabla_proveedores.AllowUserToDeleteRows = false;
            this.tabla_proveedores.AllowUserToResizeColumns = false;
            this.tabla_proveedores.AllowUserToResizeRows = false;
            this.tabla_proveedores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_proveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_proveedores.GridColor = System.Drawing.SystemColors.MenuText;
            this.tabla_proveedores.Location = new System.Drawing.Point(0, 0);
            this.tabla_proveedores.MultiSelect = false;
            this.tabla_proveedores.Name = "tabla_proveedores";
            this.tabla_proveedores.ReadOnly = true;
            this.tabla_proveedores.RowHeadersVisible = false;
            this.tabla_proveedores.ShowEditingIcon = false;
            this.tabla_proveedores.Size = new System.Drawing.Size(745, 300);
            this.tabla_proveedores.TabIndex = 7;
            this.tabla_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_proveedores_CellClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Image = global::Omega3.Properties.Resources.tick_tabla;
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Elegir";
            this.dataGridViewImageColumn1.Image = global::Omega3.Properties.Resources.tick_tabla;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // ElegirProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirProveedor";
            this.Text = "ElegirProveedor";
            this.Load += new System.EventHandler(this.ElegirProveedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabla_proveedores;
        private System.Windows.Forms.DataGridViewImageColumn Elegir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}