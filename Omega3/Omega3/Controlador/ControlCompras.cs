using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using Omega3.Controlador;
using System.Windows.Forms;
using System.Data;

namespace Omega3.Controlador
{
    class ControlCompras
    {

        public static int Insertarnuevacompra(ComprasaProveedores compras)
        {

            int retorno = 0;
            int pagada = 0;
            DateTime fechapago1 = DateTime.Now;
            if (compras.Pagada) { pagada = 1; }
            string fecha = ControladorFuncVariadas.convertirFecha(compras.Vencimiento);
            string fechapago = ControladorFuncVariadas.convertirFecha(fechapago1);

            MessageBox.Show(Convert.ToString(fechapago));
            

            try
            {

                if (pagada == 1)
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into compras (proveedor,motivo,vencimiento,monto,pagada,detalle,comprobante,iva,razon,fecha_pago) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}')",
                 compras.Proveedor, compras.Motivo, fecha, compras.Monto, pagada, compras.Detalle, compras.Comprobante, compras.Iva, compras.Razon, fechapago), Conexion.ObtenerConexion());

                    retorno = comando.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into compras (proveedor,motivo,vencimiento,monto,pagada,detalle,comprobante,iva,razon) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}')",
                    compras.Proveedor, compras.Motivo, fecha, compras.Monto, pagada, compras.Detalle, compras.Comprobante, compras.Iva, compras.Razon), Conexion.ObtenerConexion());

                    retorno = comando.ExecuteNonQuery();

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }

            return retorno;


        }

        public static void construirTablacomprasrealizadas(DataGridView dgv_tabla)
        {

            var id = new DataGridViewTextBoxColumn();
            var proveedor = new DataGridViewTextBoxColumn();
            var motivo = new DataGridViewTextBoxColumn();
            var vencimiento = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
            var pagada = new DataGridViewCheckBoxColumn();
            var detalle = new DataGridViewTextBoxColumn();
            var modificar = new DataGridViewImageColumn();
            var ingreso = new DataGridViewTextBoxColumn(); 
            var comprobante = new DataGridViewTextBoxColumn();
            var iva = new DataGridViewTextBoxColumn();
            var razon = new DataGridViewTextBoxColumn();
            var pago = new DataGridViewTextBoxColumn();


            proveedor.HeaderText = "Proveedor";
            proveedor.DataPropertyName = "Proveedor";
            proveedor.Name = "Proveedor";
            proveedor.ReadOnly = true;
            proveedor.Width = 200;


            motivo.HeaderText = "Motivo";
            motivo.Name = "Motivo";
            motivo.ReadOnly = true;
            motivo.DataPropertyName = "Motivo";


            vencimiento.HeaderText = "Vencimiento";
            vencimiento.Name = "Vencimiento";
            vencimiento.DataPropertyName = "Vencimiento";
            vencimiento.ReadOnly = true;
            //             tipo.Width = 45;

            monto.HeaderText = "Monto";
            monto.Name = "Monto";
            monto.DataPropertyName = "Monto";
            monto.ReadOnly = true;

            pagada.HeaderText = "Pagada";
            pagada.Name = "Pagada";
            pagada.DataPropertyName = "Pagada";
            pagada.ReadOnly = true;

            detalle.HeaderText = "Detalle";
            detalle.Name = "Detalle";
            detalle.DataPropertyName = "Detalle";
            detalle.ReadOnly = true;

            modificar.HeaderText = "Modificar";
            modificar.Name = "Modificar";
            modificar.DataPropertyName = "Modificar";
            modificar.ReadOnly = true;
            modificar.Visible = true;

            iva.HeaderText = "Iva";
            iva.Name = "Iva";
            iva.DataPropertyName = "Iva";
            iva.ReadOnly = true;

            comprobante.HeaderText = "Comprobante";
            comprobante.Name = "Comprobante";
            comprobante.DataPropertyName = "Comprobante";
            //cobrada.Visible = false;
            comprobante.ReadOnly = true;

            razon.HeaderText = "Razon Social";
            razon.Name = "Razon Social";
            razon.DataPropertyName = "Razon Social";
            razon.ReadOnly = true;

            pago.HeaderText = "Fecha Pago";
            pago.Name = "Fecha Pago";
            pago.DataPropertyName = "Fecha Pago";
            pago.ReadOnly = true;

            id.HeaderText = "Id";
            id.Name = "Id";
            id.DataPropertyName = "Id";
            id.ReadOnly = true;
            id.Visible = false;
            

            ingreso.Name = "Fecha Ingreso";
            ingreso.HeaderText = "Fecha Ingreso";
            ingreso.DataPropertyName = "Fecha Ingreso";
            ingreso.ReadOnly = true;

            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { id, proveedor, motivo, vencimiento, monto, pagada, detalle, razon, iva, pago, comprobante, ingreso, modificar });


            dgv_tabla.AutoGenerateColumns = false;

            llenar_compras_realizadas(dgv_tabla);


        }

        public static void llenar_compras_realizadas(DataGridView dgv_tabla)

        {


            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            string sqlSelectAll = "SELECT id as Id, proveedor as Proveedor, motivo as Motivo, vencimiento as Vencimiento, monto as Monto, pagada as Pagada, detalle as Detalle, dia_ingreso as 'Fecha Ingreso', comprobante as Comprobante, iva as Iva, razon as 'Razon Social', fecha_pago as 'Fecha Pago' FROM compras";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgv_tabla.DataSource = bSource;

                

            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de ventas: " + ex); }

        }

        public static ComprasaProveedores modificarCompra (long id)
        {
           

            
            ComprasaProveedores compra = new ComprasaProveedores();

            
            compra.Id = id;

            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT id, proveedor, motivo, vencimiento, monto, pagada, detalle, dia_ingreso, comprobante, iva, razon, fecha_pago FROM compras WHERE id={0}", id), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                compra.Id = long.Parse(_reader.GetString(0));
                compra.Proveedor = _reader.GetString(1);
                compra.Motivo = _reader.GetString(2);
                compra.Vencimiento = _reader.GetDateTime(3);
                compra.Monto = _reader.GetDecimal(4);
                compra.Pagada = _reader.GetBoolean(5);
                compra.Detalle = _reader.GetString(6);
                compra.Diaingreso = _reader.GetDateTime(7);
                compra.Comprobante = _reader.GetString(8);
                compra.Iva = _reader.GetDecimal(9);
                compra.Razon = _reader.GetString(10);
                compra.Fechapago = _reader.GetDateTime(11);


            }


            return compra;
        }

        public static int modificarCompra(ComprasaProveedores compra) {


            int retorno = 0;
           

            try
            {

                if (compra.Pagada)
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE compras SET proveedor='{0}',motivo='{1}',vencimiento='{2}',monto={3},pagada='{4}',detalle='{5}',comprobante='{7}',iva={8},razon='{9}',fecha_pago='{10}' WHERE id ='{11}'",
                 compra.Proveedor,compra.Motivo,Omega3.Controlador.ControladorFuncVariadas.convertirFecha(compra.Vencimiento),compra.Monto,1,compra.Detalle,compra.Comprobante,compra.Iva,compra.Razon,Omega3.Controlador.ControladorFuncVariadas.convertirFecha(DateTime.Now),compra.Id), Conexion.ObtenerConexion());

                    retorno = comando.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE compras SET proveedor='{0}',motivo='{1}',vencimiento='{2}',monto={3},pagada='{4}',detalle='{5}',comprobante='{6}',iva={7},razon='{8}' WHERE id ='{9}'",
                    compra.Proveedor, compra.Motivo, Omega3.Controlador.ControladorFuncVariadas.convertirFecha(compra.Vencimiento), compra.Monto, 0, compra.Detalle, compra.Comprobante, compra.Iva, compra.Razon, compra.Id), Conexion.ObtenerConexion());

                    retorno = comando.ExecuteNonQuery();

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }

            return retorno;




        }



    }
}
