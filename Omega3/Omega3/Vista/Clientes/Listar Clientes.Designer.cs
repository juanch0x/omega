namespace Omega3.Vista.Clientes
{
    partial class Listar_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.lbl_filtro_razon_social = new System.Windows.Forms.Label();
            this.lbl_filtro_documento = new System.Windows.Forms.Label();
            this.txt_filtro_dni = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_filtro_dni);
            this.panel1.Controls.Add(this.lbl_filtro_documento);
            this.panel1.Controls.Add(this.lbl_filtro_razon_social);
            this.panel1.Controls.Add(this.txt_filtro_nombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_tabla);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 352);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omega3.Properties.Resources.lineafondo;
            this.pictureBox1.Location = new System.Drawing.Point(267, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Clientes ";
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowDrop = true;
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AllowUserToResizeColumns = false;
            this.dgv_tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_tabla.Location = new System.Drawing.Point(3, 102);
            this.dgv_tabla.Name = "dgv_tabla";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_tabla.RowHeadersVisible = false;
            this.dgv_tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_tabla.Size = new System.Drawing.Size(703, 207);
            this.dgv_tabla.TabIndex = 0;
            this.dgv_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Omega3.Properties.Resources.lupa2020;
            this.Editar.Name = "Editar";
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.Location = new System.Drawing.Point(140, 63);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_filtro_nombre.TabIndex = 3;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.filtro_nombre_TextChanged);
            this.txt_filtro_nombre.Enter += new System.EventHandler(this.txt_filtro_nombre_Enter);
            // 
            // lbl_filtro_razon_social
            // 
            this.lbl_filtro_razon_social.AutoSize = true;
            this.lbl_filtro_razon_social.Location = new System.Drawing.Point(18, 66);
            this.lbl_filtro_razon_social.Name = "lbl_filtro_razon_social";
            this.lbl_filtro_razon_social.Size = new System.Drawing.Size(116, 13);
            this.lbl_filtro_razon_social.TabIndex = 4;
            this.lbl_filtro_razon_social.Text = "Filtrar por Razón Social";
            // 
            // lbl_filtro_documento
            // 
            this.lbl_filtro_documento.AutoSize = true;
            this.lbl_filtro_documento.Location = new System.Drawing.Point(331, 66);
            this.lbl_filtro_documento.Name = "lbl_filtro_documento";
            this.lbl_filtro_documento.Size = new System.Drawing.Size(135, 13);
            this.lbl_filtro_documento.TabIndex = 5;
            this.lbl_filtro_documento.Text = "Filtro por CUIT/Documento";
            // 
            // txt_filtro_dni
            // 
            this.txt_filtro_dni.Location = new System.Drawing.Point(472, 63);
            this.txt_filtro_dni.Name = "txt_filtro_dni";
            this.txt_filtro_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_filtro_dni.TabIndex = 6;
            this.txt_filtro_dni.TextChanged += new System.EventHandler(this.filtro_dni_TextChanged);
            this.txt_filtro_dni.Enter += new System.EventHandler(this.txt_filtro_dni_Enter);
            // 
            // Listar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listar_Clientes";
            this.Text = "Listar Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.TextBox txt_filtro_dni;
        private System.Windows.Forms.Label lbl_filtro_documento;
        private System.Windows.Forms.Label lbl_filtro_razon_social;
    }
}