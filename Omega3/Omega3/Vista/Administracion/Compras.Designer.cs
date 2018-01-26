namespace Omega3.Vista.Administracion
{
    partial class Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Iva = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radio_no_pagado = new System.Windows.Forms.RadioButton();
            this.radio_pagado = new System.Windows.Forms.RadioButton();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.iva10 = new System.Windows.Forms.TextBox();
            this.nogravado = new System.Windows.Forms.TextBox();
            this.percepcioniva = new System.Windows.Forms.TextBox();
            this.percepcioniibb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras a Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pagada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vencimiento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.percepcioniibb);
            this.panel1.Controls.Add(this.percepcioniva);
            this.panel1.Controls.Add(this.nogravado);
            this.panel1.Controls.Add(this.iva10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_razon);
            this.panel1.Controls.Add(this.txt_iva);
            this.panel1.Controls.Add(this.txt_comprobante);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Iva);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radio_no_pagado);
            this.panel1.Controls.Add(this.radio_pagado);
            this.panel1.Controls.Add(this.btn_crear);
            this.panel1.Controls.Add(this.txt_detalle);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.txt_proveedor);
            this.panel1.Controls.Add(this.txt_monto);
            this.panel1.Controls.Add(this.txt_motivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 596);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omega3.Properties.Resources.lineafondo;
            this.pictureBox1.Location = new System.Drawing.Point(175, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txt_razon
            // 
            this.txt_razon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon.Location = new System.Drawing.Point(252, 390);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(305, 26);
            this.txt_razon.TabIndex = 6;
            this.txt_razon.Tag = "Razon Social";
            // 
            // txt_iva
            // 
            this.txt_iva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iva.Location = new System.Drawing.Point(252, 230);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(305, 26);
            this.txt_iva.TabIndex = 5;
            this.txt_iva.Tag = "Iva";
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comprobante.Location = new System.Drawing.Point(252, 166);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(305, 26);
            this.txt_comprobante.TabIndex = 4;
            this.txt_comprobante.Tag = "Comprobante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Razon Social";
            // 
            // Iva
            // 
            this.Iva.AutoSize = true;
            this.Iva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iva.Location = new System.Drawing.Point(24, 237);
            this.Iva.Name = "Iva";
            this.Iva.Size = new System.Drawing.Size(69, 19);
            this.Iva.TabIndex = 18;
            this.Iva.Text = "Iva 21%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comprobante";
            // 
            // radio_no_pagado
            // 
            this.radio_no_pagado.AutoSize = true;
            this.radio_no_pagado.Location = new System.Drawing.Point(444, 422);
            this.radio_no_pagado.Name = "radio_no_pagado";
            this.radio_no_pagado.Size = new System.Drawing.Size(113, 23);
            this.radio_no_pagado.TabIndex = 8;
            this.radio_no_pagado.Text = "No Pagado";
            this.radio_no_pagado.UseVisualStyleBackColor = true;
            // 
            // radio_pagado
            // 
            this.radio_pagado.AutoSize = true;
            this.radio_pagado.Checked = true;
            this.radio_pagado.Location = new System.Drawing.Point(252, 422);
            this.radio_pagado.Name = "radio_pagado";
            this.radio_pagado.Size = new System.Drawing.Size(86, 23);
            this.radio_pagado.TabIndex = 7;
            this.radio_pagado.TabStop = true;
            this.radio_pagado.Text = "Pagado";
            this.radio_pagado.UseVisualStyleBackColor = true;
            // 
            // btn_crear
            // 
            this.btn_crear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(252, 559);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(97, 28);
            this.btn_crear.TabIndex = 10;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_detalle
            // 
            this.txt_detalle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle.Location = new System.Drawing.Point(252, 458);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(305, 76);
            this.txt_detalle.TabIndex = 9;
            this.txt_detalle.Tag = "Detalle";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(252, 134);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(305, 26);
            this.txt_fecha.TabIndex = 2;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(252, 70);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(305, 26);
            this.txt_proveedor.TabIndex = 0;
            this.txt_proveedor.Tag = "Proveedor";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(252, 198);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(305, 26);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.Tag = "Monto";
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // txt_motivo
            // 
            this.txt_motivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo.Location = new System.Drawing.Point(252, 102);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(305, 26);
            this.txt_motivo.TabIndex = 1;
            this.txt_motivo.Tag = "Motivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Iva 10.5%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Concepto no Gravado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Percepcion IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Percepcion IIBB";
            // 
            // iva10
            // 
            this.iva10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iva10.Location = new System.Drawing.Point(252, 262);
            this.iva10.Name = "iva10";
            this.iva10.Size = new System.Drawing.Size(305, 26);
            this.iva10.TabIndex = 28;
            this.iva10.Tag = "Iva";
            // 
            // nogravado
            // 
            this.nogravado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nogravado.Location = new System.Drawing.Point(252, 294);
            this.nogravado.Name = "nogravado";
            this.nogravado.Size = new System.Drawing.Size(305, 26);
            this.nogravado.TabIndex = 29;
            this.nogravado.Tag = "Iva";
            // 
            // percepcioniva
            // 
            this.percepcioniva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percepcioniva.Location = new System.Drawing.Point(252, 326);
            this.percepcioniva.Name = "percepcioniva";
            this.percepcioniva.Size = new System.Drawing.Size(305, 26);
            this.percepcioniva.TabIndex = 30;
            this.percepcioniva.Tag = "Iva";
            // 
            // percepcioniibb
            // 
            this.percepcioniibb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percepcioniibb.Location = new System.Drawing.Point(252, 358);
            this.percepcioniibb.Name = "percepcioniibb";
            this.percepcioniibb.Size = new System.Drawing.Size(305, 26);
            this.percepcioniibb.TabIndex = 31;
            this.percepcioniibb.Tag = "Iva";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 596);
            this.Controls.Add(this.panel1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.RadioButton radio_no_pagado;
        private System.Windows.Forms.RadioButton radio_pagado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_razon;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Iva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox percepcioniibb;
        private System.Windows.Forms.TextBox percepcioniva;
        private System.Windows.Forms.TextBox nogravado;
        private System.Windows.Forms.TextBox iva10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}