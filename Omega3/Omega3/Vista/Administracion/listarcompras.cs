﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Administracion
{
    public partial class listarcompras : Form
    {
        public listarcompras()
        {
            InitializeComponent();

        }

        private void calcularTamanio()
        {


            panel_tabla.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);

            dgv_tabla.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tabla.Dock = DockStyle.Fill;

        }


        private void listarcompras_Load(object sender, EventArgs e)
        {
            Omega3.Controlador.ControlCompras.llenar_compras_realizadas(dgv_tabla);
            calcularTamanio();
        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_tabla.Columns[e.ColumnIndex].Name == "Modificar")
            {

                e.Value = Properties.Resources.btn_info_1616;
            }
        }
    }
}
