namespace Omega3.Vista.Presupuesto
{
    partial class Informe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.EArticuloBindingSource;
            reportDataSource2.Name = "Cabecera";
            reportDataSource2.Value = this.EFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Omega3.Vista.Informes.Presupuesto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(491, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // EArticuloBindingSource
            // 
            this.EArticuloBindingSource.DataSource = typeof(Omega3.Modelo.EArticulo);
            // 
            // EFacturaBindingSource
            // 
            this.EFacturaBindingSource.DataSource = typeof(Omega3.Modelo.EFactura);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Informe";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Informe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EArticuloBindingSource;
        private System.Windows.Forms.BindingSource EFacturaBindingSource;
    }
}