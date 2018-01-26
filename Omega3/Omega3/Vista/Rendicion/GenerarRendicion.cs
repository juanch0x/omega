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

namespace Omega3.Vista.Rendicion
{
    public partial class GenerarRendicion : Form
    {
        string usuario;
        DateTime desde;
        DateTime hasta;

        public GenerarRendicion(string usuario, DateTime desde, DateTime hasta)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.desde = desde;
            this.hasta = hasta;
            iniciar();
        }

        private void GenerarRendicion_Load(object sender, EventArgs e)
        {
            

        }

        private void iniciar()
        {
            string query_ventas = string.Empty;
            string query_reparacion = string.Empty;

            query_ventas = "SELECT " +
                                "venta.id as 'Id Venta', " +
                                "date(venta.fecha_venta) as 'Fecha', " +
                                "venta.usuario as 'Vendedor', " +
                                "(SELECT razon_social FROM cliente where documento = venta.cliente_documento) as 'Cliente', " +
                                "(SELECT sum(subtotal) from detalle_venta where id_venta = venta.id) as 'Monto', " +
                                "if (venta.cobrada = 1, " +
                                "(SELECT sum(subtotal) from detalle_venta where id_venta = venta.id AND date(fecha)), " +
                                "(SELECT sum(monto) FROM pagosparciales where id_venta = venta.id AND date(fecha))) as 'Cobrado' " +
                            "FROM venta " +
                            "WHERE venta.usuario = '" + usuario + "' AND date(fecha_venta) BETWEEN '" + desde.ToString("yy-MM-dd") + "' AND '" + hasta.ToString("yy-MM-dd") + "'";
            Console.WriteLine(query_ventas);
            construirTabla(true, query_ventas);

            query_reparacion = "SELECT " +
                                    "reparaciones.id as 'Id Venta', " +
                                    "reparaciones.fecha_pago as Fecha, " +
                                    "reparaciones.usuario as Vendedor, " +
                                    "(SELECT razon_social FROM cliente where documento = reparaciones.documento) as 'Cliente', " +
                                    "(SELECT sum(subtotal) from detalle_reparaciones where reparaciones.id = detalle_reparaciones.id_reparacion) as 'Monto', " +
                                    "if (reparaciones.cobrada = 1, " +
                                      "(SELECT sum(subtotal) from detalle_reparaciones where reparaciones.id = detalle_reparaciones.id_reparacion), " +
                                      "(SELECT sum(monto) FROM pagosparciales WHERE id_reparacion = reparaciones.id)) as 'Cobrado' " +
                                    "FROM reparaciones " +
                                    "WHERE reparaciones.usuario = '" + usuario + "' AND date(fecha_pago) BETWEEN '" + desde.ToString("yy-MM-dd") + "' AND '" + hasta.ToString("yy-MM-dd") + "'";
            Console.WriteLine("reparacion ->" + query_reparacion);
            construirTabla(false, query_reparacion);

            ControlRendiciones.armarExcelRendiciones(dgv_tabla_ventas, dgv_tabla_reparacion, desde, hasta, usuario);
        }

        private void construirTabla(bool ventas, string query)
        {

            var id_venta = new DataGridViewTextBoxColumn();
            var fecha = new DataGridViewTextBoxColumn();
            var vendedor = new DataGridViewTextBoxColumn();
            var cliente = new DataGridViewTextBoxColumn();
            var monto = new DataGridViewTextBoxColumn();
            var cobrado = new DataGridViewTextBoxColumn();


            id_venta.HeaderText = "Id Venta";
            id_venta.DataPropertyName = "Id Venta";
            id_venta.Name = "Id Venta";
            id_venta.ReadOnly = true;

            fecha.HeaderText = "Fecha";
            fecha.DataPropertyName = "Fecha";
            fecha.Name = "Fecha";
            fecha.ReadOnly = true;

            vendedor.HeaderText = "Vendedor";
            vendedor.DataPropertyName = "Vendedor";
            vendedor.Name = "Vendedor";
            vendedor.ReadOnly = true;

            cliente.HeaderText = "Cliente";
            cliente.DataPropertyName = "Cliente";
            cliente.Name = "Cliente";
            cliente.ReadOnly = true;

            monto.HeaderText = "Monto";
            monto.DataPropertyName = "Monto";
            monto.Name = "Monto";
            monto.ReadOnly = true;

            cobrado.HeaderText = "Cobrado";
            cobrado.DataPropertyName = "Cobrado";
            cobrado.Name = "Cobrado";
            cobrado.ReadOnly = true;

            if (ventas)
            {
                dgv_tabla_ventas.Columns.AddRange(id_venta,fecha,vendedor,cliente,monto,cobrado);
                ControlRendiciones.llenar_reparaciones_realizadas(dgv_tabla_ventas, query);
            }
            else
            {
                dgv_tabla_reparacion.Columns.AddRange(id_venta, fecha, vendedor, cliente, monto, cobrado);
                ControlRendiciones.llenar_reparaciones_realizadas(dgv_tabla_reparacion, query);
            }

        }

    }
}
