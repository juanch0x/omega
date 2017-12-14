namespace Omega3.Vista.PagosParciales
{
    partial class agregarPago
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
            this.combo_medio_de_pago = new System.Windows.Forms.ComboBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.panel_carga = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_cheque = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.txt_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel_carga.SuspendLayout();
            this.panel_cheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_medio_de_pago
            // 
            this.combo_medio_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medio_de_pago.FormattingEnabled = true;
            this.combo_medio_de_pago.Location = new System.Drawing.Point(97, 28);
            this.combo_medio_de_pago.Name = "combo_medio_de_pago";
            this.combo_medio_de_pago.Size = new System.Drawing.Size(121, 21);
            this.combo_medio_de_pago.TabIndex = 0;
            this.combo_medio_de_pago.SelectedIndexChanged += new System.EventHandler(this.combo_medio_de_pago_SelectedIndexChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(97, 58);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(121, 20);
            this.txt_monto.TabIndex = 2;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // panel_carga
            // 
            this.panel_carga.Controls.Add(this.label2);
            this.panel_carga.Controls.Add(this.label1);
            this.panel_carga.Controls.Add(this.combo_medio_de_pago);
            this.panel_carga.Controls.Add(this.txt_monto);
            this.panel_carga.Location = new System.Drawing.Point(12, 12);
            this.panel_carga.Name = "panel_carga";
            this.panel_carga.Size = new System.Drawing.Size(306, 99);
            this.panel_carga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medio de Pago";
            // 
            // panel_cheque
            // 
            this.panel_cheque.Controls.Add(this.label6);
            this.panel_cheque.Controls.Add(this.label5);
            this.panel_cheque.Controls.Add(this.label4);
            this.panel_cheque.Controls.Add(this.txt_razon);
            this.panel_cheque.Controls.Add(this.txt_banco);
            this.panel_cheque.Controls.Add(this.txt_vencimiento);
            this.panel_cheque.Controls.Add(this.label3);
            this.panel_cheque.Controls.Add(this.txt_comprobante);
            this.panel_cheque.Location = new System.Drawing.Point(12, 117);
            this.panel_cheque.Name = "panel_cheque";
            this.panel_cheque.Size = new System.Drawing.Size(306, 184);
            this.panel_cheque.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Razon Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vencimiento";
            // 
            // txt_razon
            // 
            this.txt_razon.Location = new System.Drawing.Point(118, 136);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(100, 20);
            this.txt_razon.TabIndex = 8;
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(118, 97);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_banco.TabIndex = 7;
            // 
            // txt_vencimiento
            // 
            this.txt_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_vencimiento.Location = new System.Drawing.Point(118, 60);
            this.txt_vencimiento.MinDate = new System.DateTime(2017, 12, 13, 0, 0, 0, 0);
            this.txt_vencimiento.Name = "txt_vencimiento";
            this.txt_vencimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_vencimiento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº Comprobante";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Location = new System.Drawing.Point(118, 18);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(100, 20);
            this.txt_comprobante.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(109, 307);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // agregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 342);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.panel_cheque);
            this.Controls.Add(this.panel_carga);
            this.Name = "agregarPago";
            this.Text = "Agregar Pago";
            this.Load += new System.EventHandler(this.agregarPago_Load);
            this.panel_carga.ResumeLayout(false);
            this.panel_carga.PerformLayout();
            this.panel_cheque.ResumeLayout(false);
            this.panel_cheque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_medio_de_pago;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Panel panel_carga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cheque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_razon;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.DateTimePicker txt_vencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Button btn_agregar;
    }
}