namespace Omega3.Vista.Reparaciones
{
    partial class FinalizarReparacion
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
            this.components = new System.ComponentModel.Container();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.combo_comprobante = new System.Windows.Forms.ComboBox();
            this.combo_medio_de_pago = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_cargando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(107, 25);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(57, 18);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(107, 53);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(34, 18);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(107, 81);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 18);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "email";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(107, 109);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono";
            // 
            // combo_comprobante
            // 
            this.combo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_comprobante.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_comprobante.FormattingEnabled = true;
            this.combo_comprobante.Location = new System.Drawing.Point(193, 165);
            this.combo_comprobante.Name = "combo_comprobante";
            this.combo_comprobante.Size = new System.Drawing.Size(140, 24);
            this.combo_comprobante.TabIndex = 4;
            // 
            // combo_medio_de_pago
            // 
            this.combo_medio_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medio_de_pago.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_medio_de_pago.FormattingEnabled = true;
            this.combo_medio_de_pago.Location = new System.Drawing.Point(193, 210);
            this.combo_medio_de_pago.Name = "combo_medio_de_pago";
            this.combo_medio_de_pago.Size = new System.Drawing.Size(140, 24);
            this.combo_medio_de_pago.TabIndex = 5;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(132, 291);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(39, 16);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total";
            // 
            // btn_facturar
            // 
            this.btn_facturar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.Location = new System.Drawing.Point(424, 291);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(149, 32);
            this.btn_facturar.TabIndex = 7;
            this.btn_facturar.Text = "Realizar Factura";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(424, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // lbl_cargando
            // 
            this.lbl_cargando.AutoSize = true;
            this.lbl_cargando.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargando.Location = new System.Drawing.Point(421, 51);
            this.lbl_cargando.Name = "lbl_cargando";
            this.lbl_cargando.Size = new System.Drawing.Size(63, 16);
            this.lbl_cargando.TabIndex = 9;
            this.lbl_cargando.Text = "Cargando";
            this.lbl_cargando.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Comprobante: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Condición de Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Venta: ";
            // 
            // FinalizarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 352);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cargando);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.combo_medio_de_pago);
            this.Controls.Add(this.combo_comprobante);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_cliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizarReparacion";
            this.Text = "Facturar Reparacion";
            this.Load += new System.EventHandler(this.FinalizarReparacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.ComboBox combo_comprobante;
        private System.Windows.Forms.ComboBox combo_medio_de_pago;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_cargando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}