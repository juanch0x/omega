using System;
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
                
                MySqlCommand comando = new MySqlCommand(string.Format("Update Proveedores set proveedor='{1}', telefono='{2}', direccion='{3}', provincia='{4}', codigo_postal='{5}', email='{6}',email2='{7}',email3='{8}' where id_proveedor={0}",
                    proveedor.Id_proveedor, proveedor.Nombre_proveedor, proveedor.Telefono, proveedor.Direccion, proveedor.Provincia, proveedor.Codigo_postal, proveedor.Email,proveedor.Email2,proveedor.Email3), conexion);
                Console.WriteLine(comando.CommandText);
                Console.WriteLine(comando);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error en el metodo ModificarProveedor\n"+ ex); }

            ModificarPuntajes(proveedor);

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
            string sqlSelectAll = "SELECT id_proveedor idprov, proveedor Proveedor, provincia Provincia, direccion 'Dirección', telefono 'Teléfono', email 'Email', (SELECT avg(puntaje) FROM puntaje_proveedor a INNER JOIN aspecto_x_grupo b ON a.aspecto = b.id_aspecto WHERE b.grupo = 'transporte' AND a.id_proveedor = idprov) as 'Transporte', (SELECT avg(puntaje) FROM puntaje_proveedor a INNER JOIN aspecto_x_grupo b ON a.aspecto = b.id_aspecto WHERE b.grupo = 'calidad' AND a.id_proveedor = idprov) as 'Calidad', (SELECT avg(puntaje) FROM puntaje_proveedor a INNER JOIN aspecto_x_grupo b ON a.aspecto = b.id_aspecto WHERE b.grupo = 'pagos' AND a.id_proveedor = idprov) as 'Pagos', (SELECT avg(puntaje) FROM puntaje_proveedor a INNER JOIN aspecto_x_grupo b ON a.aspecto = b.id_aspecto WHERE b.grupo = 'otros' AND a.id_proveedor = idprov) as 'Otros' FROM proveedores";
            try
            {

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, Conexion.ObtenerConexion());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                cuadro.DataSource = bSource;
                cuadro.Columns[0].Visible = false;
            }
            catch (Exception ex) { Console.WriteLine("Hubo un error llenando la tabla de productos: " + ex); }
        }

        public static void AutoFill(DataGridView dgv_tabla)
        {
            dgv_tabla.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_tabla.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

        public static Proveedor buscarEmails(Proveedor proveedor)
        {


            
            MySqlCommand _comando = new MySqlCommand(String.Format(
                 "SELECT email2,email3,codigo_postal from proveedores WHERE proveedores.id_proveedor = {0}", proveedor.Id_proveedor), Conexion.ObtenerConexion());


            try
            {
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    proveedor.Email2 = _reader.GetString(0);

                    proveedor.Email3 = _reader.GetString(1);

                    proveedor.Codigo_postal = _reader.GetInt32(2);
                }
            }catch(MySqlException ex) { Console.WriteLine(ex); }

            
            return proveedor;
        }

        public static PuntajeProveedor buscarPuntajes(long id_proveedor)
        {
            PuntajeProveedor puntos = new PuntajeProveedor();

            MySqlCommand _comando = new MySqlCommand(String.Format(
     "SELECT aspecto,puntaje FROM puntaje_proveedor WHERE id_proveedor = {0} ", id_proveedor), Conexion.ObtenerConexion());


            try
            {
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    switch(_reader.GetInt32(0))
                    {

                        case 1: puntos.transporte_posicion = _reader.GetInt32(1);
                            break;
                        case 2: puntos.transporte_Prestigio = _reader.GetInt32(1);
                            break;
                    case 3: puntos.transporte_antecedentes = _reader.GetInt32(1);
                        break;
                    case 4: puntos.transporte_financiera = _reader.GetInt32(1);
                        break;
                    case 5: puntos.transporte_transporte = _reader.GetInt32(1);
                        break;
                    case 6: puntos.transporte_capacidad = _reader.GetInt32(1);
                        break;
                    case 7: puntos.calidad_plazos = _reader.GetInt32(1);
                        break;
                    case 8: puntos.calidad_costo = _reader.GetInt32(1);
                        break;
                    case 10: puntos.calidad_cuidado = _reader.GetInt32(1);
                        break;
                    case 11: puntos.pago_plazo = _reader.GetInt32(1);
                        break;
                    case 12: puntos.pago_descuento = _reader.GetInt32(1);
                        break;
                    case 14: puntos.otros_respuesta = _reader.GetInt32(1);
                        break;
                    case 15: puntos.otros_administrativa = _reader.GetInt32(1);
                        break;
                    case 16: puntos.otros_pedidos = _reader.GetInt32(1);
                        break;


                    }
                }
            }
            catch (MySqlException ex) { Console.WriteLine(ex); }


            
            return puntos;
        }


        public static void ModificarPuntajes(Proveedor proveedor)
        {
            int retorno = 0;
            

            string update = "INSERT INTO puntaje_proveedor (aspecto,puntaje,id_proveedor) VALUES ";

            //Transporte
            MessageBox.Show(Convert.ToString(proveedor.puntaje.transporte_posicion));
            update += "(1,"+proveedor.puntaje.transporte_posicion+","+proveedor.Id_proveedor+")";
            update += ",(2," + proveedor.puntaje.transporte_Prestigio + "," + proveedor.Id_proveedor + ")";
            update += ",(3," + proveedor.puntaje.transporte_antecedentes + "," + proveedor.Id_proveedor + ")";
            update += ",(4," + proveedor.puntaje.transporte_financiera + "," + proveedor.Id_proveedor + ")";
            update += ",(5," + proveedor.puntaje.transporte_transporte + "," + proveedor.Id_proveedor + ")";
            update += ",(6," + proveedor.puntaje.transporte_capacidad + "," + proveedor.Id_proveedor + ")";
            
            //Plazos

            update += ",(7," + proveedor.puntaje.calidad_plazos + "," + proveedor.Id_proveedor + ")";
            update += ",(8," + proveedor.puntaje.calidad_costo + "," + proveedor.Id_proveedor + ")";
            update += ",(10," + proveedor.puntaje.calidad_cuidado + "," + proveedor.Id_proveedor + ")";

            //Pago
            update += ",(11," + proveedor.puntaje.pago_plazo + "," + proveedor.Id_proveedor + ")";
            update += ",(12," + proveedor.puntaje.pago_descuento + "," + proveedor.Id_proveedor + ")";

            //Otros
            update += ",(14," + proveedor.puntaje.otros_respuesta + "," + proveedor.Id_proveedor + ")";
            update += ",(15," + proveedor.puntaje.otros_administrativa + "," + proveedor.Id_proveedor + ")";
            update += ",(16," + proveedor.puntaje.otros_pedidos + "," + proveedor.Id_proveedor + ")";

            update += " ON DUPLICATE KEY UPDATE puntaje = VALUES(puntaje)";

             
              
                    MySqlCommand restastock = new MySqlCommand(update, Conexion.ObtenerConexion());
                    retorno = restastock.ExecuteNonQuery();
                
            }
        }


    }


