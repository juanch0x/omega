﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Omega3.Modelo;
using System.Data;
using System.Windows.Forms;


namespace Omega3.Controlador
{
    class ControlProveedor
    {
        public static int AgregarProveedor(Proveedor proveedor)
        {

            int retorno = 0;
            
            try
            {

                        

                Console.WriteLine(proveedor.Codigo_postal);
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into Proveedores (proveedor, telefono, direccion, provincia, codigo_postal, email, email2, email3) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    proveedor.Nombre_proveedor, proveedor.Telefono, proveedor.Direccion, proveedor.Provincia, proveedor.Codigo_postal, proveedor.Email, proveedor.Email2, proveedor.Email3), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error agregando el proveedor: "+ ex); }

            insertarPuntajes(proveedor);
      
            return retorno;
        }


        public static int ModificarProveedor(Proveedor proveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            try
            {
                
                MySqlCommand comando = new MySqlCommand(string.Format("Update Proveedores set proveedor='{1}', telefono='{2}', direccion='{3}', provincia='{4}', codigo_postal='{5}', email='{6}' where id_proveedor={0}",
                    proveedor.Id_proveedor, proveedor.Nombre_proveedor, proveedor.Telefono, proveedor.Direccion, proveedor.Provincia, proveedor.Codigo_postal, proveedor.Email), conexion);
                Console.WriteLine(comando.CommandText);
                Console.WriteLine(comando);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error en el metodo ModificarProveedor\n"+ ex); }
            return retorno;


        }
        public static int EliminarProveedor(Proveedor proveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Proveedores where id_proveedor='{0}'",
                proveedor.Id_proveedor), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static void llenarTabla(DataGridView cuadro)
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT id_proveedor AS Codigo, proveedor AS Proveedor, direccion AS Direccion, provincia AS Provincia, telefono AS Telefono, email AS Email FROM proveedores";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de productos: " + ex); }
        }

        public static void AutoFill(DataGridView dgv_tabla)
        {
            dgv_tabla.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int i;
            for (i = 0; i <= dgv_tabla.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dgv_tabla.Columns[i].Width;
                //remove autosizing
                dgv_tabla.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dgv_tabla.Columns[i].Width = colw;
            }

        }

        public static void validarCaracteresNumerosyLetras(KeyPressEventArgs e)
        {

            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;

            }

        }

        public static void validarCaracteresNumericos(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }
        public static void validarCaracteresLetras(KeyPressEventArgs e) {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                return;
                }

        }

        public static void validarTextboxVacio(string campo)
        {
            MessageBox.Show("El campo " + campo + " es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }


        public static int insertarPuntajes(Proveedor proveedor)
        {
            int retorno = 0;
            string consulta;

            consulta = "INSERT INTO puntaje_proveedor ( aspecto,puntaje,id_proveedor ) VALUES";
            consulta += "(1," + proveedor.puntaje.transporte_posicion + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(2," + proveedor.puntaje.transporte_Prestigio + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(3," + proveedor.puntaje.transporte_antecedentes + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(4," + proveedor.puntaje.transporte_financiera + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(5," + proveedor.puntaje.transporte_transporte + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(6," + proveedor.puntaje.transporte_capacidad + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(7," + proveedor.puntaje.calidad_plazos + ",(select max(id_proveedor) from proveedores))";
            consulta += ",(8," + proveedor.puntaje.calidad_costo+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(9," + proveedor.puntaje.calidad_cuidado+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(10," + proveedor.puntaje.pago_plazo+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(11," + proveedor.puntaje.pago_descuento+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(12," + proveedor.puntaje.otros_respuesta+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(13," + proveedor.puntaje.otros_administrativa+ ",(select max(id_proveedor) from proveedores))";
            consulta += ",(14," + proveedor.puntaje.otros_pedidos+ ",(select max(id_proveedor) from proveedores))";
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }catch (MySqlException e) { Console.WriteLine(e); }
            return retorno;

        }

    }
}

