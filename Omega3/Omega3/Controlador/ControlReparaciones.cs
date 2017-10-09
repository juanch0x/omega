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
    class ControlReparaciones
    {
   
        public static void llenarTablaClientes(DataGridView cuadro)
        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT documento as Documento, razon_social as 'Nombre del Cliente' FROM cliente";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;
                
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Clientes: " + ex); }
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

        public static int AgregarReparacion(Reparacion a)
        {
          
            int retorno = 0;

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO reparaciones (documento, problema, fecha_salida, id_motor, maquina, comentarios) VALUES('{0}','{1}','{2}', '{3}','{4}','{5}')",
                               a.documento, a.problema, ControladorFuncVariadas.convertirFecha(a.fecha_salida), a.id_motor, a.maquina, a.comentarios), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }

            return retorno;
        }


        public static void llenarTablaReparaciones(DataGridView cuadro)
        {

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT c.documento, c.razon_social as 'Cliente', problema as 'Problema', fecha_salida as 'Fecha de Salida' , id_motor as 'Num. Motor', maquina as 'Maquina',id as ID, c.lista FROM reparaciones r LEFT JOIN cliente c ON r.documento = c.documento WHERE r.entregado = 0";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;

                cuadro.Columns[1].Visible = false;

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Reparaciones: " + ex); }

        }

        public static void llenarTablaProducto(DataGridView cuadro, Omega3.Modelo.Reparacion reparacion)
        {

            Decimal lista = reparacion.lista / 100 + 1;
            
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT cod_producto as Cod, producto as Producto, ROUND(((IF( dolar = 1, precio_compra * (SELECT valor FROM valor_dolar WHERE id = 1), precio_compra))*1.21)*"+lista+",2) AS Precio FROM productos";
            Console.WriteLine(sqlSelectAll);
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;

                
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de Productos: " + ex); }


        }

    }
}
