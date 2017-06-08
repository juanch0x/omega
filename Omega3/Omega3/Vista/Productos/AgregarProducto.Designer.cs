namespace Omega3.Vista.Productos
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
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio_costo = new System.Windows.Forms.TextBox();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(21, 23);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_producto.TabIndex = 0;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(24, 54);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_precio_costo
            // 
            this.lbl_precio_costo.AutoSize = true;
            this.lbl_precio_costo.Location = new System.Drawing.Point(24, 84);
            this.lbl_precio_costo.Name = "lbl_precio_costo";
            this.lbl_precio_costo.Size = new System.Drawing.Size(67, 13);
            this.lbl_precio_costo.TabIndex = 2;
            this.lbl_precio_costo.Text = "Precio Costo";
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(23, 110);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(68, 13);
            this.lbl_precio_venta.TabIndex = 3;
            this.lbl_precio_venta.Text = "Precio Venta";
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(23, 138);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(71, 13);
            this.lbl_stock_minimo.TabIndex = 4;
            this.lbl_stock_minimo.Text = "Stock Minimo";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(147, 23);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(163, 20);
            this.txt_producto.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(147, 51);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(163, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.Location = new System.Drawing.Point(147, 77);
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Size = new System.Drawing.Size(163, 20);
            this.txt_precio_costo.TabIndex = 7;
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Location = new System.Drawing.Point(147, 103);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(163, 20);
            this.txt_precio_venta.TabIndex = 8;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Location = new System.Drawing.Point(147, 131);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(163, 20);
            this.txt_stock_minimo.TabIndex = 9;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(89, 205);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(183, 205);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(24, 163);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(35, 13);
            this.lbl_cantidad.TabIndex = 13;
            this.lbl_cantidad.Text = "Stock";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(147, 156);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(163, 20);
            this.txt_cantidad.TabIndex = 10;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 257);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_stock_minimo);
            this.Controls.Add(this.txt_precio_venta);
            this.Controls.Add(this.txt_precio_costo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_stock_minimo);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_precio_costo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_producto);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_precio_costo;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_precio_costo;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
    }
}