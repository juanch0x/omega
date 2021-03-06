﻿namespace Omega3.Vista.Productos
{
    partial class AgregarProducto
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
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_precio_costo = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio_costo = new System.Windows.Forms.TextBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.combo_moneda = new System.Windows.Forms.ComboBox();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(19, 30);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(80, 19);
            this.lbl_producto.TabIndex = 0;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(19, 59);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(65, 19);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_precio_costo
            // 
            this.lbl_precio_costo.AutoSize = true;
            this.lbl_precio_costo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_costo.Location = new System.Drawing.Point(19, 84);
            this.lbl_precio_costo.Name = "lbl_precio_costo";
            this.lbl_precio_costo.Size = new System.Drawing.Size(108, 19);
            this.lbl_precio_costo.TabIndex = 2;
            this.lbl_precio_costo.Text = "Precio Costo";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dolar.Location = new System.Drawing.Point(18, 110);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(70, 19);
            this.lbl_dolar.TabIndex = 3;
            this.lbl_dolar.Text = "Moneda";
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_minimo.Location = new System.Drawing.Point(18, 138);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(112, 19);
            this.lbl_stock_minimo.TabIndex = 4;
            this.lbl_stock_minimo.Text = "Stock Minimo";
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(202, 29);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(163, 22);
            this.txt_producto.TabIndex = 0;
            this.txt_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_producto_KeyDown);
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(202, 57);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(163, 22);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_costo.Location = new System.Drawing.Point(202, 83);
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Size = new System.Drawing.Size(163, 22);
            this.txt_precio_costo.TabIndex = 2;
            this.txt_precio_costo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_precio_costo_KeyDown);
            this.txt_precio_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_costo_KeyPress);
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.Location = new System.Drawing.Point(202, 137);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(163, 22);
            this.txt_stock_minimo.TabIndex = 4;
            this.txt_stock_minimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_stock_minimo_KeyDown);
            this.txt_stock_minimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_minimo_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(64, 242);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(83, 28);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(244, 242);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 28);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(19, 163);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(53, 19);
            this.lbl_cantidad.TabIndex = 13;
            this.lbl_cantidad.Text = "Stock";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(202, 162);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(163, 22);
            this.txt_cantidad.TabIndex = 5;
            this.txt_cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cantidad_KeyDown);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // combo_moneda
            // 
            this.combo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_moneda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_moneda.FormattingEnabled = true;
            this.combo_moneda.Items.AddRange(new object[] {
            "Pesos",
            "Dólares"});
            this.combo_moneda.Location = new System.Drawing.Point(202, 110);
            this.combo_moneda.Name = "combo_moneda";
            this.combo_moneda.Size = new System.Drawing.Size(163, 24);
            this.combo_moneda.TabIndex = 3;
            // 
            // combo_categoria
            // 
            this.combo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(202, 188);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(163, 24);
            this.combo_categoria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categoría";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_categoria);
            this.Controls.Add(this.combo_moneda);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_stock_minimo);
            this.Controls.Add(this.txt_precio_costo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_stock_minimo);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lbl_precio_costo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgregarProducto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_precio_costo;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_precio_costo;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox combo_moneda;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Label label1;
    }
}