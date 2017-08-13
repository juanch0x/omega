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
using Microsoft.Reporting.WinForms;

namespace Omega3.Vista.Venta
{
    public partial class Comprobante_Oscuro : Form
    {

        public List<Factura_Negro> Cabecera = new List<Factura_Negro>();
        public List<Detalle_Negro> Detalle = new List<Detalle_Negro>();



        public Comprobante_Oscuro()
        {
            InitializeComponent();
        }

        private void Comprobante_Oscuro_Load(object sender, EventArgs e)
        {

            this.Informe_Comprobante.RefreshReport();

            Informe_Comprobante.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //

            //
            //Establezcamos la lista como Datasource del informe
            //
            Informe_Comprobante.LocalReport.DataSources.Add(new ReportDataSource("Cabecera", Cabecera));
            Informe_Comprobante.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            //
            //
            //Hagamos un refresh al reportViewer
            //
            Informe_Comprobante.RefreshReport();

        }
    }
}
