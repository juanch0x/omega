using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Vista.Proveedores
{
    public partial class ABMProveedores : Form
    {
        public ABMProveedores()
        {
            InitializeComponent();
        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {
            //Lleno los datos del datagridview
            Omega3.Controlador.ControlProveedor.llenarTabla(tabla_proveedores);


            //Hago que solo se pueda seleccionar la fila completa
            tabla_proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //Acomodo el tamaño de las cabaceras al tamaño del datagridview
            Omega3.Controlador.ControlProveedor.AutoFill(tabla_proveedores);

            //Pongo el boton al fondo
            tabla_proveedores.Columns[3].HeaderText = "Dirección";
            tabla_proveedores.Columns[4].HeaderText = "Teléfono";
        }

        private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)tabla_proveedores.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("Proveedor like '%{0}%'", txt_filtro_nombre.Text.Trim().Replace("'", "''"));
            tabla_proveedores.Refresh();

            Omega3.Controlador.ControlProveedor.AutoFill(tabla_proveedores);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProveedores a = new AgregarProveedores();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
            Controlador.ControlProveedor.llenarTabla(tabla_proveedores);
            Controlador.ControlProveedor.AutoFill(tabla_proveedores);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            if (tabla_proveedores.SelectedRows.Count > 0)
            {
                
                Omega3.Modelo.Proveedor proveedor = new Modelo.Proveedor();
                proveedor.Id_proveedor = Convert.ToInt32(Convert.ToString(tabla_proveedores.CurrentRow.Cells[0].Value));
                proveedor.Nombre_proveedor = Convert.ToString(tabla_proveedores.CurrentRow.Cells[1].Value);
                proveedor.Direccion = Convert.ToString(tabla_proveedores.CurrentRow.Cells[3].Value);
                proveedor.Provincia = Convert.ToString(tabla_proveedores.CurrentRow.Cells[2].Value);
                proveedor.Telefono = long.Parse(Convert.ToString(tabla_proveedores.CurrentRow.Cells[4].Value));
                proveedor.Email = Convert.ToString(tabla_proveedores.CurrentRow.Cells[5].Value);


                ModificarProveedor modificarproducto = new ModificarProveedor(proveedor);
                modificarproducto.StartPosition = FormStartPosition.CenterScreen;
                modificarproducto.ShowDialog();
                Omega3.Controlador.ControlProveedor.llenarTabla(tabla_proveedores);
                txt_filtro_nombre.Text = "";
            }
            else { MessageBox.Show("Ningun registro fue seleccionado, seleccione uno e intentelo de nuevo"); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Omega3.Modelo.Proveedor proveedor = new Modelo.Proveedor();
            proveedor.Id_proveedor = long.Parse(Convert.ToString(tabla_proveedores.CurrentRow.Cells[0].Value));
            DialogResult boton = MessageBox.Show("¿Realmente desea eliminar el proveedor?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                Omega3.Controlador.ControlProveedor.EliminarProveedor(proveedor);
                Omega3.Controlador.ControlProveedor.llenarTabla(tabla_proveedores);
                txt_filtro_nombre.Text = "";
                Controlador.ControlProveedor.AutoFill(tabla_proveedores);
                MessageBox.Show("El producto se eliminó correctamente.");
            }

        }

        private void txt_filtro_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.ControlProveedor.validarCaracteresNumerosyLetras(e);
        }
    }
}
