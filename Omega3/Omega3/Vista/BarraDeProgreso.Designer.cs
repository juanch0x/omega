namespace Omega3.Vista
{
    partial class BarraDeProgreso
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_accion = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(51, 46);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(159, 23);
            this.progress.TabIndex = 0;
            // 
            // lbl_accion
            // 
            this.lbl_accion.AutoSize = true;
            this.lbl_accion.Location = new System.Drawing.Point(108, 90);
            this.lbl_accion.Name = "lbl_accion";
            this.lbl_accion.Size = new System.Drawing.Size(40, 13);
            this.lbl_accion.TabIndex = 1;
            this.lbl_accion.Text = "Accion";
            // 
            // Contador
            // 
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BarraDeProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_accion);
            this.Controls.Add(this.progress);
            this.Name = "BarraDeProgreso";
            this.Text = "BarraDeProgreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_accion;
        private System.Windows.Forms.Timer Contador;
        private System.Windows.Forms.Button button1;
    }
}