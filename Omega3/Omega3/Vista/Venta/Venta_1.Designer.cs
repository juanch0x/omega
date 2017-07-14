namespace Omega3.Vista.Venta
{
    partial class Venta_1
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
            this.combo_condicion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_tipo_factura = new System.Windows.Forms.ComboBox();
            this.combo_pago = new System.Windows.Forms.ComboBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración Impositiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tratamiento Impositivo";
            // 
            // combo_condicion
            // 
            this.combo_condicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_condicion.FormattingEnabled = true;
            this.combo_condicion.Location = new System.Drawing.Point(39, 76);
            this.combo_condicion.Name = "combo_condicion";
            this.combo_condicion.Size = new System.Drawing.Size(121, 21);
            this.combo_condicion.TabIndex = 2;
            this.combo_condicion.SelectedIndexChanged += new System.EventHandler(this.combo_condicion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Facturación";
            // 
            // combo_tipo_factura
            // 
            this.combo_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_factura.FormattingEnabled = true;
            this.combo_tipo_factura.Location = new System.Drawing.Point(434, 46);
            this.combo_tipo_factura.Name = "combo_tipo_factura";
            this.combo_tipo_factura.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_factura.TabIndex = 4;
            // 
            // combo_pago
            // 
            this.combo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pago.FormattingEnabled = true;
            this.combo_pago.Location = new System.Drawing.Point(434, 76);
            this.combo_pago.Name = "combo_pago";
            this.combo_pago.Size = new System.Drawing.Size(121, 21);
            this.combo_pago.TabIndex = 5;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.combo_pago);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.combo_tipo_factura);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.combo_condicion);
            this.Panel.Location = new System.Drawing.Point(1, 274);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(608, 111);
            this.Panel.TabIndex = 6;
            this.Panel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 111);
            this.panel1.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Venta_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(612, 439);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel);
            this.Name = "Venta_1";
            this.Text = "Venta_1";
            this.Load += new System.EventHandler(this.Venta_1_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_condicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_tipo_factura;
        private System.Windows.Forms.ComboBox combo_pago;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}