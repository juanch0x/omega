namespace Omega3.Vista.Venta
{
    partial class Comprobante_Oscuro
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
            this.Informe_Comprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalle_NegroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Factura_NegroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_NegroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_NegroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Informe_Comprobante
            // 
            this.Informe_Comprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.Detalle_NegroBindingSource;
            reportDataSource2.Name = "Cabecera";
            reportDataSource2.Value = this.Factura_NegroBindingSource;
            this.Informe_Comprobante.LocalReport.DataSources.Add(reportDataSource1);
            this.Informe_Comprobante.LocalReport.DataSources.Add(reportDataSource2);
            this.Informe_Comprobante.LocalReport.ReportEmbeddedResource = "Omega3.Vista.Informes.Venta_Negra.rdlc";
            this.Informe_Comprobante.Location = new System.Drawing.Point(0, 0);
            this.Informe_Comprobante.Name = "Informe_Comprobante";
            this.Informe_Comprobante.ServerReport.BearerToken = null;
            this.Informe_Comprobante.Size = new System.Drawing.Size(495, 343);
            this.Informe_Comprobante.TabIndex = 0;
            // 
            // Detalle_NegroBindingSource
            // 
            this.Detalle_NegroBindingSource.DataSource = typeof(Omega3.Modelo.Detalle_Negro);
            // 
            // Factura_NegroBindingSource
            // 
            this.Factura_NegroBindingSource.DataSource = typeof(Omega3.Modelo.Factura_Negro);
            // 
            // Comprobante_Oscuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 343);
            this.Controls.Add(this.Informe_Comprobante);
            this.Name = "Comprobante_Oscuro";
            this.Text = "Comprobante_Oscuro";
            this.Load += new System.EventHandler(this.Comprobante_Oscuro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_NegroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_NegroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Informe_Comprobante;
        private System.Windows.Forms.BindingSource Detalle_NegroBindingSource;
        private System.Windows.Forms.BindingSource Factura_NegroBindingSource;
    }
}