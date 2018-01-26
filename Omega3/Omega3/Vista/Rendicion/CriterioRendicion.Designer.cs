namespace Omega3.Vista.Rendicion
{
    partial class CriterioRendicion
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
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Hasta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_desde
            // 
            this.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_desde.Location = new System.Drawing.Point(105, 97);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(85, 20);
            this.txt_desde.TabIndex = 2;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hasta.Location = new System.Drawing.Point(105, 137);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(85, 20);
            this.txt_hasta.TabIndex = 3;
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Location = new System.Drawing.Point(59, 46);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(121, 21);
            this.combo_usuarios.TabIndex = 1;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(82, 206);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Hasta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_hasta);
            this.panel1.Controls.Add(this.btn_generar);
            this.panel1.Controls.Add(this.txt_desde);
            this.panel1.Controls.Add(this.combo_usuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 254);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta.Location = new System.Drawing.Point(52, 137);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(35, 16);
            this.Hasta.TabIndex = 5;
            this.Hasta.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // CriterioRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 254);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CriterioRendicion";
            this.Text = "Criterios de Rendicion";
            this.Load += new System.EventHandler(this.CriterioRendicion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}