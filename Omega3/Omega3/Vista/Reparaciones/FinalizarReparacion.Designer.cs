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
            this.SuspendLayout();
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(35, 31);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(35, 60);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(35, 84);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(31, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "email";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(35, 112);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono";
            // 
            // combo_comprobante
            // 
            this.combo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_comprobante.FormattingEnabled = true;
            this.combo_comprobante.Location = new System.Drawing.Point(38, 163);
            this.combo_comprobante.Name = "combo_comprobante";
            this.combo_comprobante.Size = new System.Drawing.Size(121, 21);
            this.combo_comprobante.TabIndex = 4;
            // 
            // combo_medio_de_pago
            // 
            this.combo_medio_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medio_de_pago.FormattingEnabled = true;
            this.combo_medio_de_pago.Location = new System.Drawing.Point(38, 210);
            this.combo_medio_de_pago.Name = "combo_medio_de_pago";
            this.combo_medio_de_pago.Size = new System.Drawing.Size(121, 21);
            this.combo_medio_de_pago.TabIndex = 5;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(333, 25);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total";
            // 
            // btn_facturar
            // 
            this.btn_facturar.Location = new System.Drawing.Point(477, 60);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(86, 65);
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
            this.progressBar1.Location = new System.Drawing.Point(340, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lbl_cargando
            // 
            this.lbl_cargando.AutoSize = true;
            this.lbl_cargando.Location = new System.Drawing.Point(337, 254);
            this.lbl_cargando.Name = "lbl_cargando";
            this.lbl_cargando.Size = new System.Drawing.Size(53, 13);
            this.lbl_cargando.TabIndex = 9;
            this.lbl_cargando.Text = "Cargando";
            // 
            // FinalizarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 352);
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
            this.Name = "FinalizarReparacion";
            this.Text = "FinalizarReparacion";
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
    }
}