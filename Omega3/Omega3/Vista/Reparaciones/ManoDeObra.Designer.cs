namespace Omega3.Vista.Reparaciones
{
    partial class ManoDeObra
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
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.combo_iva = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(93, 35);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(121, 20);
            this.txt_precio.TabIndex = 0;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(22, 35);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(22, 65);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(24, 13);
            this.lbl_iva.TabIndex = 2;
            this.lbl_iva.Text = "IVA";
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Location = new System.Drawing.Point(22, 94);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(59, 13);
            this.lbl_descuento.TabIndex = 3;
            this.lbl_descuento.Text = "Descuento";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(93, 92);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(121, 20);
            this.txt_descuento.TabIndex = 4;
            this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
            // 
            // combo_iva
            // 
            this.combo_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_iva.FormattingEnabled = true;
            this.combo_iva.Items.AddRange(new object[] {
            "10.5",
            "21",
            "27",
            "2.5",
            "5",
            "0"});
            this.combo_iva.Location = new System.Drawing.Point(93, 62);
            this.combo_iva.Name = "combo_iva";
            this.combo_iva.Size = new System.Drawing.Size(121, 21);
            this.combo_iva.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(75, 128);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // ManoDeObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 163);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.combo_iva);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.lbl_descuento);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txt_precio);
            this.Name = "ManoDeObra";
            this.Text = "mano_de_obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.ComboBox combo_iva;
        private System.Windows.Forms.Button btn_aceptar;
    }
}