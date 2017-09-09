namespace Omega3.Vista.Proveedores
{
    partial class ModificarProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.id_proveedor = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_codigo_postal = new System.Windows.Forms.Label();
            this.txt_codigo_postal = new System.Windows.Forms.TextBox();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id_proveedor);
            this.panel1.Controls.Add(this.id_proveedor);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_codigo_postal);
            this.panel1.Controls.Add(this.txt_codigo_postal);
            this.panel1.Controls.Add(this.txt_provincia);
            this.panel1.Controls.Add(this.lbl_provincia);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.lbl_direccion);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.lbl_telefono);
            this.panel1.Controls.Add(this.txt_proveedor);
            this.panel1.Controls.Add(this.lbl_proveedor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 199);
            this.panel1.TabIndex = 0;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Location = new System.Drawing.Point(209, 17);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.ReadOnly = true;
            this.txt_id_proveedor.Size = new System.Drawing.Size(160, 20);
            this.txt_id_proveedor.TabIndex = 28;
            // 
            // id_proveedor
            // 
            this.id_proveedor.AutoSize = true;
            this.id_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_proveedor.Location = new System.Drawing.Point(16, 17);
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Size = new System.Drawing.Size(114, 20);
            this.id_proveedor.TabIndex = 27;
            this.id_proveedor.Text = "ID Proveedor";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(209, 171);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(160, 20);
            this.txt_email.TabIndex = 26;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(19, 171);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 20);
            this.lbl_email.TabIndex = 25;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_codigo_postal
            // 
            this.lbl_codigo_postal.AutoSize = true;
            this.lbl_codigo_postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_postal.Location = new System.Drawing.Point(19, 145);
            this.lbl_codigo_postal.Name = "lbl_codigo_postal";
            this.lbl_codigo_postal.Size = new System.Drawing.Size(120, 20);
            this.lbl_codigo_postal.TabIndex = 24;
            this.lbl_codigo_postal.Text = "Codigo Postal";
            // 
            // txt_codigo_postal
            // 
            this.txt_codigo_postal.Location = new System.Drawing.Point(209, 145);
            this.txt_codigo_postal.Name = "txt_codigo_postal";
            this.txt_codigo_postal.Size = new System.Drawing.Size(160, 20);
            this.txt_codigo_postal.TabIndex = 23;
            this.txt_codigo_postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_postal_KeyPress);
            // 
            // txt_provincia
            // 
            this.txt_provincia.Location = new System.Drawing.Point(209, 119);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(160, 20);
            this.txt_provincia.TabIndex = 22;
            this.txt_provincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_provincia_KeyPress);
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provincia.Location = new System.Drawing.Point(19, 119);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(81, 20);
            this.lbl_provincia.TabIndex = 21;
            this.lbl_provincia.Text = "Provincia";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(209, 93);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(160, 20);
            this.txt_direccion.TabIndex = 20;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(19, 93);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.lbl_direccion.TabIndex = 19;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(209, 67);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(160, 20);
            this.txt_telefono.TabIndex = 18;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(16, 67);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(79, 20);
            this.lbl_telefono.TabIndex = 17;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(209, 41);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(160, 20);
            this.txt_proveedor.TabIndex = 16;
            this.txt_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_proveedor_KeyPress);
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(16, 45);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(90, 20);
            this.lbl_proveedor.TabIndex = 15;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(272, 18);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(46, 18);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_salir);
            this.panel2.Controls.Add(this.btn_modificar);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 61);
            this.panel2.TabIndex = 1;
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarProveedor";
            this.Text = "ModificarProveedor";
            this.Load += new System.EventHandler(this.ModificarProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        private System.Windows.Forms.Label id_proveedor;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_codigo_postal;
        private System.Windows.Forms.TextBox txt_codigo_postal;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Panel panel2;
    }
}