﻿namespace Omega3.Vista.PagosParciales
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
            this.txt_recibo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_cheque = new System.Windows.Forms.Panel();
            this.txt_retencion_suss = new System.Windows.Forms.TextBox();
            this.txt_retencion_iibb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_retencion_ig = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_retencion_iva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.txt_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel_boton = new System.Windows.Forms.Panel();
            this.panel_transferencia = new System.Windows.Forms.Panel();
            this.panel_carga.SuspendLayout();
            this.panel_cheque.SuspendLayout();
            this.panel_boton.SuspendLayout();
            this.panel_transferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_medio_de_pago
            // 
            this.combo_medio_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medio_de_pago.FormattingEnabled = true;
            this.combo_medio_de_pago.Location = new System.Drawing.Point(165, 26);
            this.combo_medio_de_pago.Name = "combo_medio_de_pago";
            this.combo_medio_de_pago.Size = new System.Drawing.Size(121, 21);
            this.combo_medio_de_pago.TabIndex = 0;
            this.combo_medio_de_pago.SelectedIndexChanged += new System.EventHandler(this.combo_medio_de_pago_SelectedIndexChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(165, 59);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(121, 20);
            this.txt_monto.TabIndex = 2;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // panel_carga
            // 
            this.panel_carga.Controls.Add(this.txt_recibo);
            this.panel_carga.Controls.Add(this.label7);
            this.panel_carga.Controls.Add(this.label2);
            this.panel_carga.Controls.Add(this.label1);
            this.panel_carga.Controls.Add(this.combo_medio_de_pago);
            this.panel_carga.Controls.Add(this.txt_monto);
            this.panel_carga.Location = new System.Drawing.Point(12, 3);
            this.panel_carga.Name = "panel_carga";
            this.panel_carga.Size = new System.Drawing.Size(306, 124);
            this.panel_carga.TabIndex = 3;
            // 
            // txt_recibo
            // 
            this.txt_recibo.Location = new System.Drawing.Point(165, 91);
            this.txt_recibo.Name = "txt_recibo";
            this.txt_recibo.Size = new System.Drawing.Size(121, 20);
            this.txt_recibo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medio de Pago";
            // 
            // panel_cheque
            // 
            this.panel_cheque.Controls.Add(this.txt_retencion_suss);
            this.panel_cheque.Controls.Add(this.txt_retencion_iibb);
            this.panel_cheque.Controls.Add(this.label11);
            this.panel_cheque.Controls.Add(this.label10);
            this.panel_cheque.Controls.Add(this.txt_retencion_ig);
            this.panel_cheque.Controls.Add(this.label9);
            this.panel_cheque.Controls.Add(this.txt_retencion_iva);
            this.panel_cheque.Controls.Add(this.label8);
            this.panel_cheque.Controls.Add(this.label6);
            this.panel_cheque.Controls.Add(this.label4);
            this.panel_cheque.Controls.Add(this.txt_razon);
            this.panel_cheque.Controls.Add(this.txt_vencimiento);
            this.panel_cheque.Location = new System.Drawing.Point(12, 215);
            this.panel_cheque.Name = "panel_cheque";
            this.panel_cheque.Size = new System.Drawing.Size(306, 207);
            this.panel_cheque.TabIndex = 4;
            // 
            // txt_retencion_suss
            // 
            this.txt_retencion_suss.Location = new System.Drawing.Point(166, 184);
            this.txt_retencion_suss.Name = "txt_retencion_suss";
            this.txt_retencion_suss.Size = new System.Drawing.Size(121, 20);
            this.txt_retencion_suss.TabIndex = 19;
            this.txt_retencion_suss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_retencion_suss_KeyPress);
            // 
            // txt_retencion_iibb
            // 
            this.txt_retencion_iibb.Location = new System.Drawing.Point(166, 154);
            this.txt_retencion_iibb.Name = "txt_retencion_iibb";
            this.txt_retencion_iibb.Size = new System.Drawing.Size(121, 20);
            this.txt_retencion_iibb.TabIndex = 18;
            this.txt_retencion_iibb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_retencion_iibb_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Retención SUSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Retención IIBB";
            // 
            // txt_retencion_ig
            // 
            this.txt_retencion_ig.Location = new System.Drawing.Point(166, 121);
            this.txt_retencion_ig.Name = "txt_retencion_ig";
            this.txt_retencion_ig.Size = new System.Drawing.Size(121, 20);
            this.txt_retencion_ig.TabIndex = 15;
            this.txt_retencion_ig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_retencion_ig_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Retención IG";
            // 
            // txt_retencion_iva
            // 
            this.txt_retencion_iva.Location = new System.Drawing.Point(166, 92);
            this.txt_retencion_iva.Name = "txt_retencion_iva";
            this.txt_retencion_iva.Size = new System.Drawing.Size(121, 20);
            this.txt_retencion_iva.TabIndex = 13;
            this.txt_retencion_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_retencion_iva_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Retención IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vencimiento";
            // 
            // txt_razon
            // 
            this.txt_razon.Location = new System.Drawing.Point(166, 56);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(121, 20);
            this.txt_razon.TabIndex = 8;
            // 
            // txt_vencimiento
            // 
            this.txt_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_vencimiento.Location = new System.Drawing.Point(165, 30);
            this.txt_vencimiento.MinDate = new System.DateTime(2017, 12, 13, 0, 0, 0, 0);
            this.txt_vencimiento.Name = "txt_vencimiento";
            this.txt_vencimiento.Size = new System.Drawing.Size(121, 20);
            this.txt_vencimiento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banco";
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(166, 45);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(121, 20);
            this.txt_banco.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº Comprobante";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Location = new System.Drawing.Point(166, 14);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(121, 20);
            this.txt_comprobante.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(108, 6);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(83, 32);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel_boton
            // 
            this.panel_boton.Controls.Add(this.btn_agregar);
            this.panel_boton.Location = new System.Drawing.Point(12, 428);
            this.panel_boton.Name = "panel_boton";
            this.panel_boton.Size = new System.Drawing.Size(306, 41);
            this.panel_boton.TabIndex = 13;
            // 
            // panel_transferencia
            // 
            this.panel_transferencia.Controls.Add(this.label3);
            this.panel_transferencia.Controls.Add(this.txt_comprobante);
            this.panel_transferencia.Controls.Add(this.txt_banco);
            this.panel_transferencia.Controls.Add(this.label5);
            this.panel_transferencia.Location = new System.Drawing.Point(12, 133);
            this.panel_transferencia.Name = "panel_transferencia";
            this.panel_transferencia.Size = new System.Drawing.Size(303, 76);
            this.panel_transferencia.TabIndex = 14;
            // 
            // agregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 481);
            this.Controls.Add(this.panel_transferencia);
            this.Controls.Add(this.panel_boton);
            this.Controls.Add(this.panel_cheque);
            this.Controls.Add(this.panel_carga);
            this.Name = "agregarPago";
            this.Text = "Agregar Pago";
            this.Load += new System.EventHandler(this.agregarPago_Load);
            this.panel_carga.ResumeLayout(false);
            this.panel_carga.PerformLayout();
            this.panel_cheque.ResumeLayout(false);
            this.panel_cheque.PerformLayout();
            this.panel_boton.ResumeLayout(false);
            this.panel_transferencia.ResumeLayout(false);
            this.panel_transferencia.PerformLayout();
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
        private System.Windows.Forms.Panel panel_boton;
        private System.Windows.Forms.TextBox txt_recibo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_retencion_ig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_retencion_iva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_retencion_suss;
        private System.Windows.Forms.TextBox txt_retencion_iibb;
        private System.Windows.Forms.Panel panel_transferencia;
    }
}