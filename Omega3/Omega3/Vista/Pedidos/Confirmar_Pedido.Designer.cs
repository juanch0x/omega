﻿namespace Omega3.Vista.Pedidos
{
    partial class Confirmar_Pedido
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
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(25, 22);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 0;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Comprada";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(25, 48);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(61, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(92, 48);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(33, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.btn_Aceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 79);
            this.panel1.TabIndex = 4;
            // 
            // Confirmar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 79);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmar_Pedido";
            this.Text = "Confirmar_Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Confirmar_Pedido_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel1;
    }
}