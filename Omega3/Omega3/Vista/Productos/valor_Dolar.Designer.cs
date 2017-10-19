namespace Omega3.Vista.Productos
{
    partial class valor_Dolar
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
            this.txt_sugerido = new System.Windows.Forms.Label();
            this.txt_actual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nuevo = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Sugerido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Guardado\r\n";
            // 
            // txt_sugerido
            // 
            this.txt_sugerido.AutoSize = true;
            this.txt_sugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sugerido.Location = new System.Drawing.Point(195, 49);
            this.txt_sugerido.Name = "txt_sugerido";
            this.txt_sugerido.Size = new System.Drawing.Size(108, 20);
            this.txt_sugerido.TabIndex = 2;
            this.txt_sugerido.Text = "txt_sugerido";
            // 
            // txt_actual
            // 
            this.txt_actual.AutoSize = true;
            this.txt_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_actual.Location = new System.Drawing.Point(195, 91);
            this.txt_actual.Name = "txt_actual";
            this.txt_actual.Size = new System.Drawing.Size(88, 20);
            this.txt_actual.TabIndex = 3;
            this.txt_actual.Text = "txt_actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nuevo valor";
            // 
            // txt_nuevo
            // 
            this.txt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevo.Location = new System.Drawing.Point(199, 122);
            this.txt_nuevo.Name = "txt_nuevo";
            this.txt_nuevo.Size = new System.Drawing.Size(100, 26);
            this.txt_nuevo.TabIndex = 5;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.Location = new System.Drawing.Point(98, 201);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(120, 29);
            this.btn_cambiar.TabIndex = 6;
            this.btn_cambiar.Text = "Almacenar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // valor_Dolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 278);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.txt_nuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_actual);
            this.Controls.Add(this.txt_sugerido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "valor_Dolar";
            this.Text = "Valor Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_sugerido;
        private System.Windows.Forms.Label txt_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nuevo;
        private System.Windows.Forms.Button btn_cambiar;
    }
}