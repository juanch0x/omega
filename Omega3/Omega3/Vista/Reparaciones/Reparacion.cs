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

        public Reparacion()
        {
            InitializeComponent();
        }

        private void Reparacion_Load(object sender, EventArgs e)
        {
            ControlReparaciones.armarTablaRepuestos(tabla_reparacion);
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
            reparacion.fecha_salida = DateTime.Now;
            BuscarReparacion a = new BuscarReparacion(ref txt_cliente, ref reparacion, btn_buscar_producto);
            a.ShowDialog();
            txt_maquina.Text = reparacion.maquina;
            txt_nmotor.Text = reparacion.id_motor;
            txt_problema.Text = reparacion.problema;
            txt_fecha.Value = reparacion.fecha_salida;
            ControlReparaciones.llenarComentarios(txt_comentarios, reparacion.id);

           
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
                
                tabla_reparacion.Rows.Add(txt_cantidad.Text, producto.Cod_producto, lbl_nombre_producto.Text, lbl_precio.Text, combo_iva.Text, txt_descuento.Text, precio, null);
                limpiarCampos();
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
            if(txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("El campo cantidad es obligatorio");
                txt_cantidad.Focus();
                return false;                
            }
            else if(txt_descuento.Text.Trim() == "")
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
            }

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
                MessageBox.Show("La mano de obra ya fue agregada, si desea modificarla, elimínela y agréguela nuevamente!");
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
                                       
                    tabla_reparacion.Rows.RemoveAt(item.Index);
                    
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Modelo.Reparacion reparacion_update = new Modelo.Reparacion();

            

            if(ControladorFuncVariadas.validarTextBoxVacios(txt_problema,txt_comentarios) && ControladorFuncVariadas.validarFechaPasada(txt_fecha))
            {
                reparacion_update.id = reparacion.id;
                reparacion_update.problema = txt_problema.Text;
                reparacion_update.comentarios = txt_comentarios.Text;
                reparacion_update.fecha_salida = txt_fecha.Value;
                reparacion_update.entregado = true;

                if (ControlReparaciones.actualizarReparacion(reparacion_update) == 1)
                {
                    MessageBox.Show("Se guardó correctamente");
                    ControladorFuncVariadas.limpiarTextBox(txt_cliente, txt_maquina, txt_nmotor, txt_problema, txt_comentarios);
                    txt_fecha.Value = DateTime.Now;
                    tabla_reparacion.DataSource = null;
                    tabla_reparacion.Rows.Clear();
                    btn_buscar_producto.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hubo un error en la base de datos");
                }
            }
        }
    }
}
