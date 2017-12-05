using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Controlador;
using Omega3.Modelo;

namespace Omega3.Vista.Reparaciones
{

    public partial class Reparacion : Form
    {
        Omega3.Modelo.Reparacion reparacion = new Modelo.Reparacion();
        Producto producto = new Producto();
        DataGridView tabla_reestablecer_stock = new DataGridView();
        

        public Reparacion()
        {
            InitializeComponent();
            ControlReparaciones.armarTablaRepuestos(tabla_reparacion);
        }


        public Reparacion(long id)
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
               
                c.Enabled = false;
            }
            ControlReparaciones.armarTablaRepuestos(tabla_reparacion);
            cargarReparacionEntregada(id);
        }


        private void Reparacion_Load(object sender, EventArgs e)
        {
           // ControlReparaciones.armarTablaRepuestos(tabla_reparacion);
            ControlReparaciones.armarTablaReestablecerStock(tabla_reestablecer_stock);

            limpiarCampos();
            txt_cantidad.MaxLength = 3;
            txt_descuento.MaxLength = 3;
            btn_buscar_producto.Enabled = false;


        }


        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {

            Vista.Reparaciones.BuscarProducto a = new Vista.Reparaciones.BuscarProducto(ref producto, reparacion.lista, btn_agregar_producto);
            
            a.ShowDialog();
            lbl_precio.Text = Convert.ToString(producto.Precio_venta);
            lbl_nombre_producto.Text = Convert.ToString(producto.Nombre_producto);
            lbl_stock_actual.Text = Convert.ToString(producto.Cantidad);


        }

        private void btn_buscar_reparacion_Click(object sender, EventArgs e)
        {
            reparacion.maquina = string.Empty;

            

            reparacion.fecha_salida = DateTime.Now;
            BuscarReparacion a = new BuscarReparacion(ref txt_cliente, ref reparacion, btn_buscar_producto);
            a.ShowDialog();
            if (reparacion.maquina.Trim() != "" || !string.IsNullOrEmpty(reparacion.maquina))
            {
                txt_maquina.Text = reparacion.maquina;
                txt_nmotor.Text = reparacion.id_motor;
                txt_problema.Text = reparacion.problema;
                txt_fecha.Value = reparacion.fecha_salida;
                ControlReparaciones.llenarComentarios(txt_comentarios, reparacion.id);
                ControlReparaciones.llenarTablaArticulosReparacion(tabla_reparacion, reparacion.id);
             
                    btn_buscar_reparacion.Enabled = false;
            }
            calcularTotal();
           
        }


        private void tabla_reparacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tabla_reparacion.Columns[e.ColumnIndex].Name == "Borrar")
            {

                e.Value = Properties.Resources.dgv_tabla_cancelar;
            }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            decimal precio = new decimal();

            

            if (validarCamposAgregarProducto())
            {

                precio = Convert.ToDecimal(lbl_precio.Text) * Convert.ToDecimal(txt_cantidad.Text);
                precio = precio - (precio * Convert.ToDecimal(txt_descuento.Text) / 100);
                precio = precio * (Convert.ToDecimal(combo_iva.Text) / 100 + 1);

                if (!validarProductoYaAgregado(Convert.ToString(producto.Cod_producto)))
                {
                    tabla_reparacion.Rows.Add(txt_cantidad.Text, producto.Cod_producto, lbl_nombre_producto.Text, lbl_precio.Text, combo_iva.Text, txt_descuento.Text, precio, null, true);
                    limpiarCampos();
                    calcularTotal();
                }
            }
        }

        private void limpiarCampos()
        {
            txt_cantidad.Text = "1";
            txt_descuento.Text = "0";
            combo_iva.SelectedIndex = combo_iva.FindStringExact("21");
            lbl_precio.Text = "";
            lbl_stock_actual.Text = "";
            lbl_nombre_producto.Text = "";
            btn_agregar_producto.Enabled = false;
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }


        private Boolean validarCamposAgregarProducto()
        {
            if (txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo cantidad es obligatorio");
                txt_cantidad.Focus();
                return false;
            }
            else if (txt_descuento.Text.Trim() == "")
            {
                MessageBox.Show("El campo descuento es obligatorio");
                txt_descuento.Focus();
                return false;
            }
            else if (Convert.ToInt32(txt_cantidad.Text) > Convert.ToInt32(lbl_stock_actual.Text))
            {
                MessageBox.Show("Stock insuficiente");
                return false;

            }
            return true;
        }

        private void btn_mano_de_obra_Click(object sender, EventArgs e)
        {
            ManoDeObra a;

            if (!validarManoDeObra())
            {
                a = new ManoDeObra(tabla_reparacion);

                a.ShowDialog();
                calcularTotal();
            }
            else { MessageBox.Show("La mano de obra ya fue agregada, si desea modificarla, elimínela y agréguela nuevamente!"); }

        }

        private Boolean validarManoDeObra()
        {
            String searchValue = "R";
            int rowIndex = -1;
            foreach (DataGridViewRow row in tabla_reparacion.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                //MessageBox.Show("La mano de obra ya fue agregada, si desea modificarla, elimínela y agréguela nuevamente!");
                return true;
            }
            else
                return false;

        }

        private Boolean validarProductoYaAgregado(String cod)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in tabla_reparacion.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString().Equals(cod))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            if (rowIndex != -1)
            {
                MessageBox.Show("El producto que intenta agregar, ya existe en la reparación, para agregar mayor cantidad, debe eliminarlo y agregarlo nuevamente.");
                return true;
            }
            else
                return false;
            

        }

        private void tabla_reparacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.tabla_reparacion.SelectedRows)
            {
                if (e.ColumnIndex == tabla_reparacion.Columns["Borrar"].Index) //2nd column - DGV_ImageColumn
                {

                    if (!Convert.ToBoolean(tabla_reparacion.Rows[tabla_reparacion.CurrentCell.RowIndex].Cells["nuevoitem"].Value))
                    {
                        tabla_reestablecer_stock.Rows.Add(Convert.ToString(tabla_reparacion.Rows[tabla_reparacion.CurrentCell.RowIndex].Cells["Cantidad"].Value), Convert.ToString(tabla_reparacion.Rows[tabla_reparacion.CurrentCell.RowIndex].Cells["Codigo"].Value));
                    }
                    tabla_reparacion.Rows.RemoveAt(item.Index);
                    calcularTotal();                   
                    

                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Modelo.Reparacion reparacion_update = new Modelo.Reparacion();

            

                         if (ControladorFuncVariadas.validarTextBoxVacios(txt_problema) && ControladorFuncVariadas.validarFechaPasada(txt_fecha))
                         {
                             reparacion_update.id = reparacion.id;
                             reparacion_update.problema = txt_problema.Text;
                             reparacion_update.comentarios = txt_comentarios.Text;
                             reparacion_update.fecha_salida = txt_fecha.Value;
                             reparacion_update.entregado = false;

                            ControlReparaciones.sumarStockEliminadoDeDetalle(tabla_reestablecer_stock);
                        if (ControlReparaciones.actualizarReparacion(reparacion_update, tabla_reparacion,nuevasFilas()) == 1)
                             {
                                 MessageBox.Show("Se guardó correctamente");
                                 
                                 ControladorFuncVariadas.limpiarTextBox(txt_cliente, txt_maquina, txt_nmotor, txt_problema, txt_comentarios);
                                 txt_fecha.Value = DateTime.Now;
                                 tabla_reparacion.DataSource = null;
                                 tabla_reparacion.Rows.Clear();
                                 tabla_reestablecer_stock.DataSource = null;
                                 tabla_reestablecer_stock.Rows.Clear();
                                 btn_buscar_producto.Enabled = false;
                                 btn_buscar_reparacion.Enabled = true;
                                txt_maquina.Text = string.Empty;
                }
                             else
                             {
                                 MessageBox.Show("Hubo un error en la base de datos");
                             }
                         }
            Cliente a = new Cliente();
           a =  ControlCliente.obtenerCliente(reparacion.documento);
         

                       

            }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            FinalizarReparacion finalizar;

            if (validarManoDeObra())
            {

                finalizar = new FinalizarReparacion(ControlCliente.obtenerCliente(reparacion.documento), Convert.ToDecimal(lbl_subtotal.Text), tabla_reparacion,reparacion.id,this);
                finalizar.ShowDialog();
            }else { MessageBox.Show("Debe agregar el costo de la mano de obra!"); }
       
        }

        private bool nuevasFilas()
        {
            foreach (DataGridViewRow row in tabla_reparacion.Rows) {


                if(Convert.ToBoolean(row.Cells["nuevoitem"].Value) == true)
                {
                    return true;
                }

                

            }
            return false;
        }
                
        private void calcularTotal()
        {
         
            decimal a = new decimal(0);
            
            foreach (DataGridViewRow row in tabla_reparacion.Rows)
            {
                a += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lbl_subtotal.Text = Convert.ToString(a);
        }

        private void cargarReparacionEntregada(long id)
        {

            //Hacer los botones invisibles.
            ControladorFuncVariadas.cambiarVisibilidadBoton(false,btn_buscar_reparacion,btn_buscar_producto,btn_agregar_producto,txt_guardar,button1,btn_mano_de_obra);
            ControladorFuncVariadas.cambiarVisibilidadLabel(false, lbl_nombre_producto, lbl_stock_actual, lbl_precio, label5, label6, label7, label3, label4, label2);
            ControladorFuncVariadas.cambiarVisibilidadTextBox(false, txt_cantidad, txt_descuento);
            ControladorFuncVariadas.cambiarVisibilidadCombos(false, combo_iva);
            Modelo.Reparacion modelo = new Modelo.Reparacion();

            modelo = ControlReparaciones.obtenerReparacion(id);

            txt_cliente.Text = modelo.razon_social;
            txt_fecha.Value = modelo.fecha_salida;
            txt_maquina.Text = modelo.maquina;
            txt_comentarios.Text = modelo.comentarios;
            txt_problema.Text = modelo.problema;
            txt_nmotor.Text = modelo.id_motor;

            tabla_reparacion.Enabled = true;
            ControlReparaciones.llenarTablaArticulosReparacion(tabla_reparacion, id);
            tabla_reparacion.Columns.Remove("Borrar");
            calcularTotal();

        }
        
    }
}
