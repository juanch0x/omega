using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace Omega3.Vista.Informes
{
    public partial class Presupuesto : Form
    {
        long presupuesto = 0;
        public Presupuesto(long presupuesto)
        {
            InitializeComponent();
            this.presupuesto = presupuesto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            crystalReportViewer1.ShowLogo = false;
            ReportDocument cryRpt = new ReportDocument();
            
            string path = Application.StartupPath+"\\Vista\\Informes\\Presupuesto_Venta.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("parametro_venta", presupuesto);

            

            crystalReportViewer1.ReportSource = cryRpt;
            
            crystalReportViewer1.Refresh();



        }
    }
}
