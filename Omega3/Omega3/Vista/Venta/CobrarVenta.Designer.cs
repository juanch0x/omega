namespace Omega3.Vista.Venta
{
    partial class CobrarVenta
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remito = new System.Windows.Forms.TextBox();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.combo_cobrada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(112, 150);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cobrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº de Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // txt_remito
            // 
            this.txt_remito.Location = new System.Drawing.Point(103, 65);
            this.txt_remito.Name = "txt_remito";
            this.txt_remito.Size = new System.Drawing.Size(120, 20);
            this.txt_remito.TabIndex = 6;
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(103, 91);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(120, 20);
            this.txt_factura.TabIndex = 7;
            // 
            // combo_cobrada
            // 
            this.combo_cobrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cobrada.FormattingEnabled = true;
            this.combo_cobrada.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.combo_cobrada.Location = new System.Drawing.Point(103, 38);
            this.combo_cobrada.Name = "combo_cobrada";
            this.combo_cobrada.Size = new System.Drawing.Size(120, 21);
            this.combo_cobrada.TabIndex = 8;
            // 
            // CobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 210);
            this.Controls.Add(this.combo_cobrada);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.txt_remito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificar);
            this.Name = "CobrarVenta";
            this.Text = "CobrarVenta";
            this.Load += new System.EventHandler(this.CobrarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remito;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.ComboBox combo_cobrada;
    }
}