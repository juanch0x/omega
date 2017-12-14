using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Omega3.Controlador
{
    class ControlAdministracion
    {

    public static int insertarerogacion (erogaciones erogacion)
        {
            int retorno;
           
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into erogaciones (id_usuario, destino, motivo, monto,tipo,fecha) values ('{0}','{1}','{2}', '{3}', '{4}',CURRENT_DATE)",
                    erogacion.Id_usuario, erogacion.Destino, erogacion.Motivo, erogacion.Monto, erogacion.Tipogasto), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }
            return 0;
        }

        public static void construirTablaPagos(DataGridView dgv_tabla,string query)
        {

            var titulo = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
    
            

            titulo.HeaderText = "Titulo";
            titulo.Name = "Titulo";
            titulo.DataPropertyName = "Titulo";
            titulo.ReadOnly = true;
            

            monto.Name = "Monto";
            monto.HeaderText = "Monto";
            monto.DataPropertyName = "Monto";
            monto.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { titulo,monto });


            dgv_tabla.AutoGenerateColumns = false;

            llenarPagos(dgv_tabla,query);


        }
        public static void llenarPagos(DataGridView dgv_tabla,string query) {
            string sqlSelectAll = query;
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;
            }
            catch (MySqlException ex) { MessageBox.Show("Hubo un problema "+ex.ToString());}
            {

            }
         }


    }
}
