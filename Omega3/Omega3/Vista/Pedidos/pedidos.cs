﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Controlador;

namespace Omega3.Vista.Pedidos
{
    public partial class pedidos : Form
    {
        BindingSource bd;
        DataTable dt;
        public pedidos()
        {
            InitializeComponent();
            //LLeno la tabla y adapto los valores
            ControlPedidos.llenarTabla(dgv_tabla);
            
            //Genero un datatable para poder filtrar con los checkbox abajo..
            bd = (BindingSource)dgv_tabla.DataSource;
            dt = (DataTable)bd.DataSource;
            combo_filtro.SelectedIndex = 0;
           
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
           
                //Hago que solo se pueda seleccionar la fila completa
                dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Acomodo el tamaño de las cabaceras al tamaño del datagridview

            //Pongo el boton al fondo 
                dgv_tabla.Columns[0].DisplayIndex = 9; // or 1, 2, 3 etc
            ControlPedidos.ModificarValoresTabla(dgv_tabla);
            ControlPedidos.administrarImagendgv(dgv_tabla);

        }

        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            foreach (DataGridViewRow Myrow in dgv_tabla.Rows)
            {
                
                if (Convert.ToString (Myrow.Cells["Usuario_Compra"].Value) == "Pendiente")
                {

                     Myrow.DefaultCellStyle.ForeColor = Color.Black;
                    //Myrow.DefaultCellStyle.BackColor = Color.Red;
                    


                }
                else
                {

                    Myrow.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#C5F6B4");

                }

            }
            
            

        }

        private void combo_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rowfilter = String.Empty;

            if(Convert.ToString(combo_filtro.SelectedItem) == "Pendientes") {
                rowfilter = "Usuario_Compra = 'Pendiente'";
                try
                {
                    
                    DataView dv = new DataView(dt);
                    dv.RowFilter = rowfilter;
                    
                    dgv_tabla.DataSource = dv;
                    ControlPedidos.administrarImagendgv(dgv_tabla);
                }
                catch (Exception)
                {
                    MessageBox.Show("Can’t find the column", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(Convert.ToString(combo_filtro.SelectedItem) == "Todos")
            {
                rowfilter = "";

                DataView dv = new DataView(dt);
                dv.RowFilter = rowfilter;
                dgv_tabla.DataSource = dv;
                ControlPedidos.administrarImagendgv(dgv_tabla);
            }
            else if(Convert.ToString(combo_filtro.SelectedItem) == "Finalizados")
            {
                rowfilter = "Usuario_Compra <> 'Pendiente'";
                try
                {

                    DataView dv = new DataView(dt);
                    dv.RowFilter = rowfilter;
                    dgv_tabla.DataSource = dv;
                }
                catch (Exception)
                {
                    MessageBox.Show("Can’t find the column", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
