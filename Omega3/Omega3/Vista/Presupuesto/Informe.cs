using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;

namespace Omega3.Vista.Presupuesto
{
    public partial class Informe : Form
    {

        public List<EFactura> Cabecera = new List<EFactura>();
        public List<EArticulo> Detalle = new List<EArticulo>();
        //

        public Informe()
        {
            InitializeComponent();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //

            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Cabecera", Cabecera));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            //
            //
            //Hagamos un refresh al reportViewer
            //
            reportViewer1.RefreshReport();
        }
    }
}
