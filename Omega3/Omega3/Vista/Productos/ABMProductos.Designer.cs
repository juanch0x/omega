namespace Omega3.Vista.Productos
{
    partial class ABMProductos
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
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.lbl_filtro_producto = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.filtro_codigo = new System.Windows.Forms.Label();
            this.txt_filtro_codigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgv_tabla.Location = new System.Drawing.Point(20, 63);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.ShowEditingIcon = false;
            this.dgv_tabla.Size = new System.Drawing.Size(753, 275);
            this.dgv_tabla.TabIndex = 6;
            this.dgv_tabla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_tabla_CellFormatting);
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(238, 26);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_filtro_nombre.TabIndex = 1;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            this.txt_filtro_nombre.Enter += new System.EventHandler(this.txt_filtro_nombre_Enter);
            this.txt_filtro_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_nombre_KeyPress);
            // 
            // lbl_filtro_producto
            // 
            this.lbl_filtro_producto.AutoSize = true;
            this.lbl_filtro_producto.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_producto.Location = new System.Drawing.Point(63, 27);
            this.lbl_filtro_producto.Name = "lbl_filtro_producto";
            this.lbl_filtro_producto.Size = new System.Drawing.Size(165, 19);
            this.lbl_filtro_producto.TabIndex = 2;
            this.lbl_filtro_producto.Text = "Filtrar por producto";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(223, 358);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 29);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(484, 357);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 29);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // filtro_codigo
            // 
            this.filtro_codigo.AutoSize = true;
            this.filtro_codigo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_codigo.Location = new System.Drawing.Point(428, 27);
            this.filtro_codigo.Name = "filtro_codigo";
            this.filtro_codigo.Size = new System.Drawing.Size(146, 19);
            this.filtro_codigo.TabIndex = 6;
            this.filtro_codigo.Text = "Filtrar por codigo";
            // 
            // txt_filtro_codigo
            // 
            this.txt_filtro_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_codigo.Location = new System.Drawing.Point(584, 26);
            this.txt_filtro_codigo.Name = "txt_filtro_codigo";
            this.txt_filtro_codigo.Size = new System.Drawing.Size(109, 22);
            this.txt_filtro_codigo.TabIndex = 2;
            this.txt_filtro_codigo.TextChanged += new System.EventHandler(this.txt_filtro_codigo_TextChanged);
            this.txt_filtro_codigo.Enter += new System.EventHandler(this.txt_filtro_codigo_Enter);
            this.txt_filtro_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtro_codigo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_filtro_codigo);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.filtro_codigo);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.txt_filtro_nombre);
            this.panel1.Controls.Add(this.lbl_filtro_producto);
            this.panel1.Controls.Add(this.dgv_tabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 426);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABMProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(796, 426);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMProductos";
            this.Text = "Modificar Productos";
            this.Load += new System.EventHandler(this.ModificarProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ABMProductos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABMProductos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.Label lbl_filtro_producto;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label filtro_codigo;
        private System.Windows.Forms.TextBox txt_filtro_codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}