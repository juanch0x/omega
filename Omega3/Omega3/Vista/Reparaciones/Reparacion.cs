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
        

        public Reparacion()
        {
            InitializeComponent();
        }


        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            Vista.Reparaciones.BuscarProducto a = new Vista.Reparaciones.BuscarProducto(ref producto, reparacion.lista);

            

            a.ShowDialog();
            lbl_precio.Text = Convert.ToString(producto.Precio_venta);
            lbl_nombre_producto.Text = Convert.ToString(producto.Nombre_producto);
            lbl_stock_actual.Text = Convert.ToString(producto.Cantidad);

            tabla_reparacion.Rows.Add("5","1231","descripcion","15.15","21","10,5",null);

        }

        private void btn_buscar_reparacion_Click(object sender, EventArgs e)
        {
            reparacion.fecha_salida = DateTime.Now;
            BuscarReparacion a = new BuscarReparacion(ref txt_cliente, ref reparacion);
            a.ShowDialog();
            txt_maquina.Text = reparacion.maquina;
            txt_nmotor.Text = reparacion.id_motor;
            txt_trabajo.Text = reparacion.problema;
            txt_fecha.Value = reparacion.fecha_salida;

            MessageBox.Show(Convert.ToString(reparacion.lista));
        }

        private void Reparacion_Load(object sender, EventArgs e)
        {
            ControlReparaciones.armarTablaRepuestos(tabla_reparacion);
            combo_iva.SelectedIndex = combo_iva.FindStringExact("21");
        }

        private void tabla_reparacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tabla_reparacion.Columns[e.ColumnIndex].Name == "Borrar")
            {

                e.Value = Properties.Resources.dgv_tabla_cancelar;
            }
        }
    }
}
