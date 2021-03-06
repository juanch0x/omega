﻿namespace Omega3.Vista.Pedidos
{
    partial class Solicitar_stock
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
            this.txt_filtro_codigo = new System.Windows.Forms.TextBox();
            this.filtro_codigo = new System.Windows.Forms.Label();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.lbl_filtro_producto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_solicitar = new System.Windows.Forms.Button();
            this.txt_cantidad_solicitada = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_solicitada = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgv_tabla.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv_tabla.Location = new System.Drawing.Point(0, 0);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(668, 234);
            this.dgv_tabla.TabIndex = 7;
            this.dgv_tabla.SelectionChanged += new System.EventHandler(this.dgv_tabla_SelectionChanged);
            // 
            // txt_filtro_codigo
            // 
            this.txt_filtro_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_codigo.Location = new System.Drawing.Point(535, 8);
            this.txt_filtro_codigo.Name = "txt_filtro_codigo";
            this.txt_filtro_codigo.Size = new System.Drawing.Size(109, 22);
            this.txt_filtro_codigo.TabIndex = 9;
            this.txt_filtro_codigo.TextChanged += new System.EventHandler(this.txt_filtro_codigo_TextChanged);
            this.txt_filtro_codigo.Enter += new System.EventHandler(this.txt_filtro_codigo_Enter);
            // 
            // filtro_codigo
            // 
            this.filtro_codigo.AutoSize = true;
            this.filtro_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_codigo.Location = new System.Drawing.Point(377, 11);
            this.filtro_codigo.Name = "filtro_codigo";
            this.filtro_codigo.Size = new System.Drawing.Size(140, 19);
            this.filtro_codigo.TabIndex = 11;
            this.filtro_codigo.Text = "Filtrar por codigo";
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(211, 8);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_nombre.TabIndex = 8;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.txt_filtro_nombre_TextChanged);
            this.txt_filtro_nombre.Enter += new System.EventHandler(this.txt_filtro_nombre_Enter);
            // 
            // lbl_filtro_producto
            // 
            this.lbl_filtro_producto.AutoSize = true;
            this.lbl_filtro_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_producto.Location = new System.Drawing.Point(31, 11);
            this.lbl_filtro_producto.Name = "lbl_filtro_producto";
            this.lbl_filtro_producto.Size = new System.Drawing.Size(157, 19);
            this.lbl_filtro_producto.TabIndex = 10;
            this.lbl_filtro_producto.Text = "Filtrar por producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_tabla);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 240);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_filtro_codigo);
            this.panel2.Controls.Add(this.lbl_filtro_producto);
            this.panel2.Controls.Add(this.txt_filtro_nombre);
            this.panel2.Controls.Add(this.filtro_codigo);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 46);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_solicitar);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_cantidad_solicitada);
            this.panel3.Controls.Add(this.lbl_proveedor);
            this.panel3.Controls.Add(this.lbl_cantidad_solicitada);
            this.panel3.Controls.Add(this.txt_proveedor);
            this.panel3.Controls.Add(this.txt_producto);
            this.panel3.Controls.Add(this.txt_nombre);
            this.panel3.Controls.Add(this.txt_stock);
            this.panel3.Controls.Add(this.lbl_stock);
            this.panel3.Controls.Add(this.txt_codigo);
            this.panel3.Controls.Add(this.lbl_codigo);
            this.panel3.Location = new System.Drawing.Point(12, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 153);
            this.panel3.TabIndex = 14;
            // 
            // btn_solicitar
            // 
            this.btn_solicitar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_solicitar.Location = new System.Drawing.Point(500, 119);
            this.btn_solicitar.Name = "btn_solicitar";
            this.btn_solicitar.Size = new System.Drawing.Size(105, 31);
            this.btn_solicitar.TabIndex = 12;
            this.btn_solicitar.Text = "Solicitar";
            this.btn_solicitar.UseVisualStyleBackColor = true;
            this.btn_solicitar.Click += new System.EventHandler(this.btn_solicitar_Click);
            // 
            // txt_cantidad_solicitada
            // 
            this.txt_cantidad_solicitada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_solicitada.Location = new System.Drawing.Point(478, 63);
            this.txt_cantidad_solicitada.Name = "txt_cantidad_solicitada";
            this.txt_cantidad_solicitada.Size = new System.Drawing.Size(75, 22);
            this.txt_cantidad_solicitada.TabIndex = 7;
            this.txt_cantidad_solicitada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_solicitada_KeyPress);
            // 
            // lbl_cantidad_solicitada
            // 
            this.lbl_cantidad_solicitada.AutoSize = true;
            this.lbl_cantidad_solicitada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_solicitada.Location = new System.Drawing.Point(308, 64);
            this.lbl_cantidad_solicitada.Name = "lbl_cantidad_solicitada";
            this.lbl_cantidad_solicitada.Size = new System.Drawing.Size(157, 19);
            this.lbl_cantidad_solicitada.TabIndex = 6;
            this.lbl_cantidad_solicitada.Text = "Cantidad Solicitada";
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(478, 24);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(179, 22);
            this.txt_producto.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(308, 24);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(80, 19);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.Text = "Producto";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(136, 61);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(127, 22);
            this.txt_stock.TabIndex = 3;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(19, 64);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(104, 19);
            this.lbl_stock.TabIndex = 2;
            this.lbl_stock.Text = "Stock Actual";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(136, 24);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(127, 22);
            this.txt_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(19, 24);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(65, 19);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Omega3.Properties.Resources.lupa2020;
            this.pictureBox1.Location = new System.Drawing.Point(339, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(188, 118);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.ReadOnly = true;
            this.txt_proveedor.Size = new System.Drawing.Size(145, 22);
            this.txt_proveedor.TabIndex = 9;
            this.txt_proveedor.Visible = false;
            this.txt_proveedor.TextChanged += new System.EventHandler(this.txt_proveedor_TextChanged);
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(19, 119);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(163, 19);
            this.lbl_proveedor.TabIndex = 8;
            this.lbl_proveedor.Text = "Proveedor Sugerido";
            this.lbl_proveedor.Visible = false;
            // 
            // Solicitar_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Solicitar_stock";
            this.Text = "Solicitar Stock";
            this.Load += new System.EventHandler(this.Solicitar_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_filtro_codigo;
        private System.Windows.Forms.Label filtro_codigo;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.Label lbl_filtro_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TextBox txt_cantidad_solicitada;
        private System.Windows.Forms.Label lbl_cantidad_solicitada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_solicitar;
    }
}