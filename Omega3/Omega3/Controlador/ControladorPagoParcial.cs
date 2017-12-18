﻿using MySql.Data.MySqlClient;
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
                    query = string.Format("Insert into pagosparciales (id_venta,monto,medio_de_pago,fecha,recibo) values ({0},{1},{2},'{3}','{4}')",
                            a.id_venta, a.monto, a.medio_de_pago, fecha,a.recibo);
                }
                else
                {
                    query = string.Format("Insert into pagosparciales (id_venta,monto,medio_de_pago,fecha,comprobante,vencimiento,razon_social,banco,recibo) values ({0},{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}')",
                            a.id_venta, a.monto, a.medio_de_pago, fecha,a.comprobante,vencimiento,a.razon_social,a.banco,a.recibo);
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

        public static int agregarPagoParcialReparacion(PagoParcial a)
        {


            int retorno = 0;
            string query = string.Empty;
            string fecha = ControladorFuncVariadas.convertirFecha(a.fecha);
            string vencimiento = ControladorFuncVariadas.convertirFecha(a.vencimiento);

            try
            {
                if (a.medio_de_pago == 1)
                {
                    query = string.Format("Insert into pagosparciales (monto,medio_de_pago,fecha,id_reparacion,recibo) values ({0},{1},'{2}',{3},'{4}')",
                            a.monto, a.medio_de_pago, fecha,a.id_reparacion,a.recibo);
                }
                else
                {
                    query = string.Format("Insert into pagosparciales (id_reparacion,monto,medio_de_pago,fecha,comprobante,vencimiento,razon_social,banco) values ({0},{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}')",
                            a.id_reparacion, a.monto, a.medio_de_pago, fecha, a.comprobante, vencimiento, a.razon_social, a.banco,a.recibo);
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



        public static void llenarTablaPagosParciales(DataGridView dgv_tabla,long id_venta, long id_reparacion = 0)
        {

            var medio_de_pago = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
            var comprobante = new DataGridViewTextBoxColumn();
            var fecha = new DataGridViewTextBoxColumn();
            var vencimiento = new DataGridViewTextBoxColumn();
            var razon_social = new DataGridViewTextBoxColumn();
            var banco = new DataGridViewTextBoxColumn();
            var recibo = new DataGridViewTextBoxColumn();


            medio_de_pago.HeaderText = "Medio de Pago";
            medio_de_pago.DataPropertyName = "Medio de Pago";
            medio_de_pago.Name = "Medio de Pago";
            medio_de_pago.ReadOnly = true;

            monto.HeaderText = "Monto";
            monto.DataPropertyName = "Monto";
            monto.Name = "Monto";
            monto.ReadOnly = true;

            recibo.HeaderText = "Recibo";
            recibo.DataPropertyName = "Recibo";
            recibo.Name = "Recibo";
            recibo.ReadOnly = true;

            comprobante.HeaderText = "Cheque";
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





            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { medio_de_pago,monto,recibo,comprobante,fecha,vencimiento,razon_social,banco  });


            dgv_tabla.AutoGenerateColumns = false;

            if (id_reparacion == 0)
            {

                llenar_pagosparciales(dgv_tabla, id_venta);
            }
            else { llenar_pagosparciales(dgv_tabla, id_venta, id_reparacion); }
        }

        public static void llenar_pagosparciales(DataGridView dgv_tabla, long id_venta,long id_reparacion = 0)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            string sqlSelectAll = string.Empty;
            if (id_reparacion != 0)
            {
                sqlSelectAll = "SELECT m.descripcion as 'Medio de Pago', monto as 'Monto', comprobante as 'Comprobante', fecha as 'Fecha', vencimiento as 'Vencimiento', razon_social as 'Razon Social', banco as 'Banco',recibo as 'Recibo' FROM pagosparciales p INNER JOIN medio_de_pago m on p.medio_de_pago = m.id WHERE id_reparacion = " + id_reparacion;
            }
            else
            {
                sqlSelectAll = "SELECT m.descripcion as 'Medio de Pago', monto as 'Monto', comprobante as 'Comprobante', fecha as 'Fecha', vencimiento as 'Vencimiento', razon_social as 'Razon Social', banco as 'Banco',recibo as 'Recibo' FROM pagosparciales p INNER JOIN medio_de_pago m on p.medio_de_pago = m.id WHERE id_venta = " + id_venta;
            }
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



        public static int agregarPagoVentaEfectivo(DataGridView dgv_tabla,long id_venta,int medio_de_pago)
        {


            int retorno = 0;
            string query = string.Empty;
            string fecha = ControladorFuncVariadas.convertirFecha(DateTime.Now);
            decimal monto = new decimal(0);

            for (int i = 0; i < dgv_tabla.Rows.Count; ++i)
            {
                monto += Convert.ToDecimal(dgv_tabla.Rows[i].Cells[5].Value);
            }



            try
            {
                
                    query = string.Format("Insert into pagosparciales (id_venta,monto,medio_de_pago,fecha) values ({0},{1},{2},'{3}')",
                            id_venta, monto, medio_de_pago, fecha);
                
                

                MySqlCommand comando = new MySqlCommand(query, Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en agregar pago parcial. ->" + e);

            }



            return retorno;
        }

        public static int agregarPagoReparacionEfectivo(long id_reparacion,int medio_de_pago)
        {
            decimal monto = new decimal(0);
            string consulta = string.Empty;
            int retorno = 0;
            string query = string.Empty;
            string fecha = ControladorFuncVariadas.convertirFecha(DateTime.Now);



            try
            {

                consulta = "SELECT subtotal FROM detalle_reparaciones WHERE id_reparacion = "+id_reparacion;

            MySqlCommand cmd = new MySqlCommand(consulta, Conexion.ObtenerConexion());

            MySqlDataReader _reader = cmd.ExecuteReader();

            while (_reader.Read())
            {
                monto += _reader.GetDecimal(0);
            }
            


                query = string.Format("Insert into pagosparciales (monto,medio_de_pago,fecha,id_reparacion) values ({0},{1},'{2}',{3})",
                        monto, medio_de_pago, fecha,id_reparacion);



                MySqlCommand comando = new MySqlCommand(query, Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en agregar pago parcial (reparacion). ->" + e);

            }

            return retorno;
        }


    }



}
