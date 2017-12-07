using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Informes
{
    public partial class Comprobante_Reparacion : Form
    {
        long id;
        public Comprobante_Reparacion(long reparacion_id)
        {
            InitializeComponent();
            this.id = reparacion_id;
        }

        private void Comprobante_Reparacion_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ShowLogo = false;
            ReportDocument cryRpt = new ReportDocument();

            string path = Application.StartupPath + "\\Vista\\Informes\\Reparacion_Negro.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("parametro", id);



            crystalReportViewer1.ReportSource = cryRpt;

            crystalReportViewer1.Refresh();
        }
    }
}
