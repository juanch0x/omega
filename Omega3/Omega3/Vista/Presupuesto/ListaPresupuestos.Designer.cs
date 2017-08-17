namespace Omega3.Vista.Presupuesto
{
    partial class ListaPresupuestos
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
            this.dgv_presupuestos = new System.Windows.Forms.DataGridView();
            this.btn_llenar = new System.Windows.Forms.Button();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_presupuestos
            // 
            this.dgv_presupuestos.AllowUserToAddRows = false;
            this.dgv_presupuestos.AllowUserToDeleteRows = false;
            this.dgv_presupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_presupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver});
            this.dgv_presupuestos.Location = new System.Drawing.Point(12, 72);
            this.dgv_presupuestos.Name = "dgv_presupuestos";
            this.dgv_presupuestos.ReadOnly = true;
            this.dgv_presupuestos.Size = new System.Drawing.Size(679, 242);
            this.dgv_presupuestos.TabIndex = 0;
            this.dgv_presupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_llenar
            // 
            this.btn_llenar.Location = new System.Drawing.Point(606, 29);
            this.btn_llenar.Name = "btn_llenar";
            this.btn_llenar.Size = new System.Drawing.Size(75, 23);
            this.btn_llenar.TabIndex = 1;
            this.btn_llenar.Text = "button1";
            this.btn_llenar.UseVisualStyleBackColor = true;
            this.btn_llenar.Click += new System.EventHandler(this.btn_llenar_Click);
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Image = global::Omega3.Properties.Resources.lupa2020;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // ListaPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 356);
            this.Controls.Add(this.btn_llenar);
            this.Controls.Add(this.dgv_presupuestos);
            this.Name = "ListaPresupuestos";
            this.Text = "ListaPresupuestos";
            this.Load += new System.EventHandler(this.ListaPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_presupuestos;
        private System.Windows.Forms.Button btn_llenar;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
    }
}