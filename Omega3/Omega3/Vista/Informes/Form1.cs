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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();


            //cryRpt.Load("C:\\Users\\Juancho\\Source\\Repos\\omega3\\Omega3\\Omega3\\Vista\\Informes\\CrystalReport2.rpt");
            cryRpt.Load("C:\\Users\\Juancho\\Source\\Repos\\omega3\\Omega3\\Omega3\\Vista\\Informes\\Presupuesto_Venta.rpt");
            cryRpt.SetParameterValue("parametro_venta", 64);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
