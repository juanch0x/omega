namespace Omega3.Vista.Productos
{
    partial class ModificarProductos
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.lbl_filtro_producto = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.filtro_codigo = new System.Windows.Forms.Label();
            this.txt_filtro_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(15, 61);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(769, 287);
            this.dgv_tabla.TabIndex = 0;
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.Location = new System.Drawing.Point(115, 19);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_filtro_nombre.TabIndex = 1;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            this.txt_filtro_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_nombre_KeyPress);
            // 
            // lbl_filtro_producto
            // 
            this.lbl_filtro_producto.AutoSize = true;
            this.lbl_filtro_producto.Location = new System.Drawing.Point(12, 22);
            this.lbl_filtro_producto.Name = "lbl_filtro_producto";
            this.lbl_filtro_producto.Size = new System.Drawing.Size(95, 13);
            this.lbl_filtro_producto.TabIndex = 2;
            this.lbl_filtro_producto.Text = "Filtrar por producto";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(50, 371);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(226, 371);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(444, 371);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // filtro_codigo
            // 
            this.filtro_codigo.AutoSize = true;
            this.filtro_codigo.Location = new System.Drawing.Point(276, 22);
            this.filtro_codigo.Name = "filtro_codigo";
            this.filtro_codigo.Size = new System.Drawing.Size(85, 13);
            this.filtro_codigo.TabIndex = 6;
            this.filtro_codigo.Text = "Filtrar por codigo";
            // 
            // txt_filtro_codigo
            // 
            this.txt_filtro_codigo.Location = new System.Drawing.Point(383, 22);
            this.txt_filtro_codigo.Name = "txt_filtro_codigo";
            this.txt_filtro_codigo.Size = new System.Drawing.Size(109, 20);
            this.txt_filtro_codigo.TabIndex = 7;
            this.txt_filtro_codigo.TextChanged += new System.EventHandler(this.txt_filtro_codigo_TextChanged);
            this.txt_filtro_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_codigo_KeyPress);
            // 
            // ModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 406);
            this.Controls.Add(this.txt_filtro_codigo);
            this.Controls.Add(this.filtro_codigo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_filtro_producto);
            this.Controls.Add(this.txt_filtro_nombre);
            this.Controls.Add(this.dgv_tabla);
            this.Name = "ModificarProductos";
            this.Text = "Modificar Productos";
            this.Load += new System.EventHandler(this.ModificarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.Label lbl_filtro_producto;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label filtro_codigo;
        private System.Windows.Forms.TextBox txt_filtro_codigo;
    }
}