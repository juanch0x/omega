namespace Omega3.Vista.Administracion
{
    partial class CuentaCorriente
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
            this.combo_cliente = new System.Windows.Forms.ComboBox();
            this.buscar_cuit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar_cuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_comprado = new System.Windows.Forms.Label();
            this.lbl_pagado = new System.Windows.Forms.Label();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_cliente
            // 
            this.combo_cliente.Font = new System.Drawing.Font("Arial", 9F);
            this.combo_cliente.FormattingEnabled = true;
            this.combo_cliente.Location = new System.Drawing.Point(30, 38);
            this.combo_cliente.Name = "combo_cliente";
            this.combo_cliente.Size = new System.Drawing.Size(217, 23);
            this.combo_cliente.TabIndex = 16;
            // 
            // buscar_cuit
            // 
            this.buscar_cuit.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_cuit.Location = new System.Drawing.Point(30, 88);
            this.buscar_cuit.Name = "buscar_cuit";
            this.buscar_cuit.Size = new System.Drawing.Size(217, 21);
            this.buscar_cuit.TabIndex = 17;
            this.buscar_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_cuit_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(38, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Comprado";
            // 
            // btn_buscar_cuit
            // 
            this.btn_buscar_cuit.Location = new System.Drawing.Point(253, 88);
            this.btn_buscar_cuit.Name = "btn_buscar_cuit";
            this.btn_buscar_cuit.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_cuit.TabIndex = 20;
            this.btn_buscar_cuit.Text = "Buscar";
            this.btn_buscar_cuit.UseVisualStyleBackColor = true;
            this.btn_buscar_cuit.Click += new System.EventHandler(this.btn_buscar_cuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(38, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Pagado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(38, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Deuda";
            // 
            // lbl_comprado
            // 
            this.lbl_comprado.AutoSize = true;
            this.lbl_comprado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comprado.Location = new System.Drawing.Point(199, 222);
            this.lbl_comprado.Name = "lbl_comprado";
            this.lbl_comprado.Size = new System.Drawing.Size(50, 18);
            this.lbl_comprado.TabIndex = 23;
            this.lbl_comprado.Text = "label4";
            // 
            // lbl_pagado
            // 
            this.lbl_pagado.AutoSize = true;
            this.lbl_pagado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagado.Location = new System.Drawing.Point(199, 257);
            this.lbl_pagado.Name = "lbl_pagado";
            this.lbl_pagado.Size = new System.Drawing.Size(50, 18);
            this.lbl_pagado.TabIndex = 24;
            this.lbl_pagado.Text = "label5";
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda.Location = new System.Drawing.Point(199, 293);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(50, 18);
            this.lbl_deuda.TabIndex = 25;
            this.lbl_deuda.Text = "label6";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(38, 161);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(56, 23);
            this.lbl_dni.TabIndex = 26;
            this.lbl_dni.Text = "Titulo";
            // 
            // CuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 369);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_deuda);
            this.Controls.Add(this.lbl_pagado);
            this.Controls.Add(this.lbl_comprado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar_cuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_cuit);
            this.Controls.Add(this.combo_cliente);
            this.Name = "CuentaCorriente";
            this.Text = "CuentaCorriente";
            this.Load += new System.EventHandler(this.CuentaCorriente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_cliente;
        private System.Windows.Forms.TextBox buscar_cuit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar_cuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_comprado;
        private System.Windows.Forms.Label lbl_pagado;
        private System.Windows.Forms.Label lbl_deuda;
        private System.Windows.Forms.Label lbl_dni;
    }
}