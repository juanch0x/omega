using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
namespace Omega3.Controlador
{
    class ControladorPagoParcial
    {
        public static void llenarMedioDePago (ComboBox combo){
        string query = "SELECT id, descripcion from medio_de_pago WHERE descripcion <> 'Cuenta Corriente' AND descripcion <> 'Tarjeta de Credito' AND descripcion <> 'Tarjeta de Debito'";

        MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da1.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "descripcion";
            combo.DataSource = dt;
            }


        public static int agregarPagoParcial(PagoParcial a)
        {

                        
            int retorno = 0;
            string query = string.Empty;
            string fecha = ControladorFuncVariadas.convertirFecha(a.fecha);
            string vencimiento = ControladorFuncVariadas.convertirFecha(a.vencimiento);

                try
                {
                if (a.medio_de_pago == 1)
                {
                    query = string.Format("Insert into pagosparciales (id_venta,monto,medio_de_pago,fecha) values ({0},{1},{2},'{3}')",
                            a.id_venta, a.monto, a.medio_de_pago, fecha);
                }
                else
                {
                    query = string.Format("Insert into pagosparciales (id_venta,monto,medio_de_pago,fecha,comprobante,vencimiento,razon_social,banco) values ({0},{1},{2},'{3}','{4}','{5}','{6}','{7}')",
                            a.id_venta, a.monto, a.medio_de_pago, fecha,a.comprobante,vencimiento,a.razon_social,a.banco);
                }

                    MySqlCommand comando = new MySqlCommand(query, Conexion.ObtenerConexion());
                    retorno = comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en agregar pago parcial. ->" + e);
                
                }

            

            return retorno;
        }

        public static void llenarTablaPagosParciales(DataGridView dgv_tabla,long id_venta)
        {

            var medio_de_pago = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
            var comprobante = new DataGridViewTextBoxColumn();
            var fecha = new DataGridViewTextBoxColumn();
            var vencimiento = new DataGridViewTextBoxColumn();
            var razon_social = new DataGridViewTextBoxColumn();
            var banco = new DataGridViewTextBoxColumn();

            medio_de_pago.HeaderText = "Medio de Pago";
            medio_de_pago.DataPropertyName = "Medio de Pago";
            medio_de_pago.Name = "Medio de Pago";
            medio_de_pago.ReadOnly = true;

            monto.HeaderText = "Monto";
            monto.DataPropertyName = "Monto";
            monto.Name = "Monto";
            monto.ReadOnly = true;

            comprobante.HeaderText = "Comprobante";
            comprobante.DataPropertyName = "Comprobante";
            comprobante.Name = "Comprobante";
            comprobante.ReadOnly = true;

            fecha.HeaderText = "Fecha";
            fecha.DataPropertyName = "Fecha";
            fecha.Name = "Fecha";
            fecha.ReadOnly = true;

            vencimiento.HeaderText = "Vencimiento";
            vencimiento.DataPropertyName = "Vencimiento";
            vencimiento.Name = "Vencimiento";
            vencimiento.ReadOnly = true;

            razon_social.HeaderText = "Razon Social";
            razon_social.DataPropertyName = "Razon Social";
            razon_social.Name = "Razon Social";
            razon_social.ReadOnly = true;

            banco.HeaderText = "Banco";
            banco.DataPropertyName = "Banco";
            banco.Name = "Banco";
            banco.ReadOnly = true;





            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { medio_de_pago,monto,comprobante,fecha,vencimiento,razon_social,banco  });


            dgv_tabla.AutoGenerateColumns = false;

            llenar_pagosparciales(dgv_tabla,id_venta);
        }

        public static void llenar_pagosparciales(DataGridView dgv_tabla, long id_venta)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            
            string sqlSelectAll = "SELECT m.descripcion as 'Medio de Pago', monto as 'Monto', comprobante as 'Comprobante', fecha as 'Fecha', vencimiento as 'Vencimiento', razon_social as 'Razon Social', banco as 'Banco' FROM pagosparciales p INNER JOIN medio_de_pago m on p.medio_de_pago = m.id WHERE id_venta = "+id_venta;
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;

                // dgv_tabla.Columns["id"].Visible = false;

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de ventas: " + ex); }

        }

    }



}
