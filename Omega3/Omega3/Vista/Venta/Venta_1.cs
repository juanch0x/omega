﻿using System;
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

namespace Omega3.Vista.Venta
{
    public partial class Venta_1 : Form
    {
        bool activo;
        Decimal lista_cliente;
        private List<Producto> lista;
        int elemento_clase;

        List<Detalle_Facturante> listado_articulos;

        public Venta_1()

        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            fecha_pago.Visible = false;
            listado_articulos = new List<Detalle_Facturante>();

            txt_ventas_lista.Text = "10";
            lista = new List<Producto>();
            lista_cliente = new decimal();
            txt_ventas_lista.MaxLength = 5;
            txt_ventas_cantidad.MaxLength = 3;

        }
        //Reescribimos el comportamiento WindProc para que se pueda mover la ventana sin los bordes

        private void Venta_1_Load(object sender, EventArgs e)
        {

            elemento_clase = 0;
            crearColumnasDgv_Tabla();
            DisableTab(tab_venta, false);

            ControlVentas.llenarMedios_de_Pago(combo_pago);

            ControlVenta.llenarClientes(combo_cliente);

            ControlVentas.llenarProductosCombo(combo_producto);


            button5.Enabled = false;
            buscar_cuit.Text = "Buscar por CUIT o DNI";
            buscar_cuit.ForeColor = Color.Gray;
            dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            combo_iva.SelectedIndex = 1;
            txt_ventas_cantidad.Text = "1";

            combo_cliente.ForeColor = Color.Gray;
            combo_cliente.SelectedIndex = -1;
            combo_cliente.Text = "Buscar por Razón Social";

        }


        public void DisableTab(TabPage pagina, bool enable)
        {
            if (!enable)
                panel_principal.TabPages.Remove(pagina);
            else
                if (!activo)
            {
                panel_principal.TabPages.Add(pagina);
                activo = true;
            }

        }

        private void limpiar()
        {

            txt_ventas_cantidad.Text = "1";
            txt_ventas_codigo.Text = "";

            combo_iva.SelectedIndex = 1;
            txt_ventas_precio.Text = "";


        }




        //¿QUE ES ESTO??
        private void button1_Click(object sender, EventArgs e)
        {
            ControlVenta control = new ControlVenta();
            control.Venta();
        }


        private void filtro_cuit_Leave(object sender, EventArgs e)
        {
            if (buscar_cuit.Text == "")
            {
                buscar_cuit.Text = "Buscar por CUIT o DNI";
                buscar_cuit.ForeColor = Color.Gray;
            }
        }

        private void filtro_cuit_Enter(object sender, EventArgs e)
        {
            if (buscar_cuit.Text == "Buscar por CUIT o DNI")
            {
                buscar_cuit.Text = "";
                buscar_cuit.ForeColor = Color.Black;
                combo_cliente.ForeColor = Color.Gray;
                combo_cliente.SelectedIndex = -1;
                combo_cliente.Text = "Buscar por Razón Social";


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Cliente a = new Cliente();

            if (combo_cliente.SelectedIndex == -1)
            {
                if (buscar_cuit.Text != "Buscar por CUIT o DNI" && (buscar_cuit.Text.Trim() != "" || !string.IsNullOrEmpty(buscar_cuit.Text)))
                {
                    if (ControlCliente.validardocumento(long.Parse(buscar_cuit.Text)))
                    {

                        a = ControlVentas.obtenerCliente(long.Parse(buscar_cuit.Text));

                        razon.Text = a.Razon;
                        domicilio.Text = a.Direccion;
                        iva.Text = a.Impositiva;
                        email.Text = a.Mail_contacto;
                        cuit.Text = Convert.ToString(a.Documento);
                        lbl_lista.Text = Convert.ToString(a.Lista);
                        lista_cliente = a.Lista / 100;
                        ControlVentas.llenarComboComprobante(combo_comprobante, a.Impositiva_Id);
                    }
                    else
                    {
                        MessageBox.Show("El documento " + buscar_cuit.Text + " no corresponde a ningún cliente.");
                        iniciarBusquedaCuit();
                        buscar_cuit.Focus();
                    }
                }
                else { MessageBox.Show("Debe seleccionar un cliente, escribir un DNI/C.U.I.T"); }
            }
            else
            {
                a = ControlVentas.obtenerCliente(combo_cliente.Text);
                razon.Text = a.Razon;
                domicilio.Text = a.Direccion;
                iva.Text = a.Impositiva;
                email.Text = a.Mail_contacto;
                cuit.Text = Convert.ToString(a.Documento);
                lbl_lista.Text = Convert.ToString(a.Lista);
                lista_cliente = a.Lista / 100;
                ControlVentas.llenarComboComprobante(combo_comprobante, a.Impositiva_Id);
            }
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DisableTab(tab_venta, true);
            panel_principal.SelectedIndex = 1;


        }



        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow item in this.dgv_tabla.SelectedRows)
            {
                //int a = 0;
                //int b = 0;
                if (e.ColumnIndex == 7) //2nd column - DGV_ImageColumn
                {

                    foreach (var producto in lista)
                    {
                        if (producto.Cod_producto == long.Parse(dgv_tabla.Rows[e.RowIndex].Cells[1].Value.ToString()))
                        {
                            producto.Cantidad += Convert.ToInt32(dgv_tabla.Rows[e.RowIndex].Cells[0].Value.ToString());

                        }


                    }


                    var item_borrar = lista.SingleOrDefault(x => x.Cod_producto == long.Parse(dgv_tabla.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    if (item_borrar != null)
                        lista.Remove(item_borrar);

                    listado_articulos.RemoveAll(x => x.elemento == Convert.ToInt32(dgv_tabla.Rows[e.RowIndex].Cells["Numero"].Value.ToString()));
                    dgv_tabla.Rows.RemoveAt(item.Index);
                    calcularTotalVenta();


                }
            }
        }



        private void btn_no_factura_Click(object sender, EventArgs e)
        {


            if (cuit.Text != "")
            {
                if (dgv_tabla.Rows.Count != 0)
                {
                    Omega3.Modelo.Venta venta = new Modelo.Venta();
                    venta.remito = 0;
                    venta.ordendeCompra = "0";

                    if (txt_remito.Text.Trim() != "" || !string.IsNullOrEmpty(txt_remito.Text))
                    {
                        venta.remito = long.Parse(txt_remito.Text);
                    }
                    if (txt_ordenDeCompra.Text.Trim() != "" || !string.IsNullOrEmpty(txt_ordenDeCompra.Text))
                    {
                        venta.ordendeCompra = txt_ordenDeCompra.Text;
                    }

                    venta.documento = long.Parse(cuit.Text);
                    venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue.ToString());

                    if (combo_pago.Text == "Cheque" || combo_pago.Text == "Cuenta Corriente") 
                    {
                        venta.fecha_vencimiento_cheque = fecha_pago.Value;

                    }

                    venta.nrofactura = "0";
                    venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
                    venta.fecha_venta = DateTime.Now;

                    Factura_Negro factura = new Factura_Negro();
                    factura.Nombre = razon.Text;
                    factura.Documento = cuit.Text;
                    factura.Direccion = domicilio.Text;
                    factura.Fecha = DateTime.Now;


                    panel_principal.SelectedIndex = 0;

                    MessageBox.Show("Venta realizada correctamente!");

                    ControlVentas.AgregarVenta(dgv_tabla, venta);
                    ControlVentas.generarFacturaNegro(dgv_tabla, factura);

                    dgv_tabla.Rows.Clear();
                    dgv_tabla.Refresh();
                    limpiarParteCliente();
                    lista.Clear();
                    this.Close();
                }
                else { MessageBox.Show("No hay ningun producto agregado"); }
            }
            else
            {
                panel_principal.SelectedIndex = 0;
                MessageBox.Show("Aún no se seleccionó un cliente");
            }


        }

        private void txt_ventas_codigo_KeyDown(object sender, KeyEventArgs e)
        {

            if (txt_ventas_codigo.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Producto a = new Producto();
                    a = ControlVentas.llenarInformacionProducto(txt_ventas_codigo.Text);

                    combo_producto.Text = a.Nombre_producto;
                    txt_ventas_precio.Text = a.Precio_venta.ToString();
                    calcularSubtotal();
                    button1.Focus();

                }

            }
            else
            {

                MessageBox.Show("El campo código no puede estar vacío");
                txt_ventas_codigo.Focus();
            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            long valor_codigo;
            Decimal valor_bonificacion;
            int valor_cantidad;
            string valor_producto;
            Decimal valor_iva;
            Decimal valor_iva_cero;
            Decimal valor_precio;
            Decimal valor_lista;
            Decimal valor_subtotal;

            if (txt_ventas_codigo.Text.Trim() != "" || !string.IsNullOrEmpty(txt_ventas_codigo.Text))
            {
                valor_codigo = long.Parse(txt_ventas_codigo.Text);
                valor_bonificacion = Convert.ToDecimal(txt_ventas_lista.Text);
                valor_cantidad = Convert.ToInt32(txt_ventas_cantidad.Text);
                valor_producto = combo_producto.Text;
                valor_iva = Convert.ToDecimal(combo_iva.Text);
                valor_iva_cero = valor_iva;
                //if (valor_iva == 0) { valor_iva_cero = 1; }
                valor_precio = Convert.ToDecimal(txt_ventas_precio.Text);
                valor_lista = Convert.ToDecimal(lbl_lista.Text);
                valor_subtotal = Convert.ToDecimal(txt_ventas_subtotal.Text);

                

                Producto a = new Producto();
                bool aux = false;

                if (combo_producto.SelectedIndex != -1)
                {

                    foreach (var producto in lista)
                    {
                        if (producto.Cod_producto == valor_codigo)
                        {

                            MessageBox.Show("El producto que intenta agregar, ya se encuentra en la venta.");
                            aux = true;
                            calcularSubtotal();


                        }

                    }

                    if (!aux)
                    {
                        if (ControlVentas.chequearStock(valor_codigo) >= valor_cantidad)
                        {
                            
                            lista.Add(new Producto { Cod_producto = valor_codigo, Cantidad = (ControlVentas.chequearStock(valor_codigo)) - (valor_cantidad) });
                            dgv_tabla.Rows.Add(txt_ventas_cantidad.Text, valor_codigo, valor_producto, txt_ventas_precio.Text, combo_iva.Text, txt_ventas_subtotal.Text, txt_ventas_lista.Text, null, Convert.ToString(elemento_clase));
                            calcularTotalVenta();


                            listado_articulos.Add(new Detalle_Facturante
                            {
                                elemento = elemento_clase,
                                Bonificacion = valor_bonificacion,
                                cantidad = valor_cantidad,
                                codigo = valor_codigo.ToString(),
                                detalle = valor_producto,
                                gravado = true,
                                iva = valor_iva,
                                /*precio_unitario = valor_precio * (valor_lista / 100 + 1),
                                total = valor_precio * (valor_lista / 100 + 1) * Convert.ToDecimal(txt_ventas_cantidad.Text)*/
                                precio_unitario = (valor_subtotal / (valor_iva_cero / 100 + 1)) / valor_cantidad,
                                total = valor_subtotal / (valor_iva_cero / 100 + 1)



                            });
                            elemento_clase++;
                            limpiarCamposCabecera();
                        }
                        else
                        {
                            DialogResult dialogresult = MessageBox.Show("\t No se dispone del stock suficiente\n ¿Desea agregar el producto a la venta de todas maneras?",
                                "¡Alerta!",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);

                            if (dialogresult == DialogResult.Yes)
                            {
                                dgv_tabla.Rows.Add(txt_ventas_cantidad.Text, valor_codigo, valor_producto, txt_ventas_precio.Text, combo_iva.Text, txt_ventas_subtotal.Text, txt_ventas_lista.Text, null, Convert.ToString(elemento_clase));
                                calcularTotalVenta();


                                listado_articulos.Add(new Detalle_Facturante
                                {
                                    elemento = elemento_clase,
                                    Bonificacion = valor_bonificacion,
                                    cantidad = valor_cantidad,
                                    codigo = valor_codigo.ToString(),
                                    detalle = valor_producto,
                                    gravado = true,
                                    iva = valor_iva,
                                    //precio_unitario = valor_precio * (valor_lista / 100 + 1),
                                    //total = valor_precio * (valor_lista / 100 + 1) * Convert.ToDecimal(txt_ventas_cantidad.Text)
                                    precio_unitario = (valor_subtotal / (valor_iva_cero / 100 + 1)) / valor_cantidad,
                                    total = valor_subtotal / (valor_iva_cero / 100 + 1)
                             

                                });
                                elemento_clase++;
                                limpiarCamposCabecera();

                            }
                            else if (dialogresult == DialogResult.No)
                            {
                                MessageBox.Show("El producto no fue agregado");
                            }
                        }
                    }





                    txt_ventas_codigo.Focus();
                    txt_ventas_subtotal.Text = "";
                }
                else { MessageBox.Show("Debe seleccionar un producto"); }
            }
        }

        private void panel_principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel_principal.SelectedIndex == 1)
            {
                txt_ventas_codigo.Focus();

                combo_producto.SelectedIndex = -1;
                txt_ventas_codigo.Text = "";
                txt_ventas_lista.Text = "";
            }
        }

        private void txt_ventas_cantidad_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
            if (Convert.ToInt32(txt_ventas_cantidad.Text.Trim()) <= 0)
                txt_ventas_cantidad.Text = "1";
        }

        private void calcularSubtotal()
        {


            decimal iva;
            decimal lista;
            int cantidad;
            decimal precio_venta, total;
            decimal subtotal;
            int id_categoria = 0;

            if (txt_ventas_codigo.Text.Trim() != "")
            {
                id_categoria = Omega3.Controlador.ControlVentas.obtenerCategoria(long.Parse(txt_ventas_codigo.Text));

            }

            //if (txt_ventas_cantidad.Text.Trim() != "" || txt_ventas_precio.Text.Trim() != "")
            if (combo_producto.SelectedIndex != -1)
            {



                iva = (Convert.ToDecimal(combo_iva.Text)) / 100 + 1;
                lista = (Convert.ToDecimal(txt_ventas_lista.Text)) / 100;
                cantidad = Convert.ToInt32(txt_ventas_cantidad.Text);
                precio_venta = Convert.ToDecimal(txt_ventas_precio.Text);

                if (id_categoria != 1)
                {
                    subtotal = Math.Round((precio_venta * iva * cantidad - (precio_venta * lista) * lista_cliente), 3);
                    total = (((precio_venta + (precio_venta * lista_cliente)) * iva) * cantidad);
                    subtotal = total - (total * lista);
                }
                else
                {
                    subtotal = Math.Round((precio_venta * iva * cantidad - (precio_venta * lista)), 3);
                    total = (((precio_venta + (precio_venta)) * iva) * cantidad);

                }

                // = total - (total * lista);
                txt_ventas_subtotal.Text = subtotal.ToString();
            }



        }

        private void txt_ventas_iva_Leave(object sender, EventArgs e)
        {
            calcularSubtotal();
        }

        private void combo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combo_pago.Text == "Cheque" || combo_pago.Text == "Cuenta Corriente")
            {
                fecha_pago.Visible = true;

            }
            else { fecha_pago.Visible = false; }
        }

        private void combo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto a = new Producto();

            if (combo_producto.SelectedIndex != -1)
            {

                txt_ventas_codigo.Text = combo_producto.SelectedValue.ToString();
                a = ControlVentas.llenarInformacionProducto(combo_producto.SelectedValue.ToString());
                combo_producto.Text = a.Nombre_producto;
                txt_ventas_precio.Text = a.Precio_venta.ToString();
                calcularSubtotal();
            }
        }

        private void Venta_1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape && ControladorFuncVariadas.comboBoxAbierto(combo_cliente, combo_comprobante, combo_iva, combo_pago, combo_producto))
            {
                this.Close();
            }


            if (e.KeyCode == Keys.F6)
            {

                if (!btn_no_factura.Visible)
                    btn_no_factura.Visible = true;
                else
                    btn_no_factura.Visible = false;
            }
        }

        private void txt_ventas_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void limpiarParteCliente()
        {

            razon.Text = "Razón Social";
            cuit.Text = "";
            email.Text = "";
            domicilio.Text = "";
            iva.Text = "";
            lbl_lista.Text = "";

        }



        private void btn_presupuesto_Click(object sender, EventArgs e)
        {

            if (cuit.Text != "")
            {
                if (dgv_tabla.Rows.Count != 0)
                {
                    Omega3.Modelo.Venta venta = new Modelo.Venta();

                    venta.documento = long.Parse(cuit.Text);
                    venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue.ToString());

                    if (combo_pago.Text == "Cheque")
                    {
                        venta.fecha_vencimiento_cheque = fecha_pago.Value;

                    }

                    venta.nrofactura = "0";
                    venta.tipo_factura = "";
                    venta.fecha_venta = DateTime.Now;

                    Factura_Negro factura = new Factura_Negro();
                    factura.Nombre = razon.Text;
                    factura.Documento = cuit.Text;
                    factura.Direccion = domicilio.Text;
                    factura.Fecha = DateTime.Now;


                    panel_principal.SelectedIndex = 0;

                    MessageBox.Show("Presupuesto realizado correctamente!");

                    // ControlVentas.AgregarVenta(dgv_tabla, venta);
                    ControlVentas.generarFacturaNegro(dgv_tabla, factura);

                    dgv_tabla.Rows.Clear();
                    dgv_tabla.Refresh();
                    limpiarParteCliente();
                    lista.Clear();
                }
                else { MessageBox.Show("No hay ningun producto agregado"); }
            }
            else
            {
                panel_principal.SelectedIndex = 0;
                MessageBox.Show("Aún no se seleccionó un cliente");
            }

        }

        private void txt_ventas_lista_TextChanged(object sender, EventArgs e)
        {
            if (txt_ventas_lista.Text.Trim() == "" || txt_ventas_lista.Text.Trim() == ".")
            {
                txt_ventas_lista.Text = "0";
                txt_ventas_lista.SelectionStart = 0;
                txt_ventas_lista.SelectionLength = txt_ventas_lista.Text.Length;
            }
            else
            {

                calcularSubtotal();

            }
        }

        private void txt_ventas_lista_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarNumerosConComas(sender, e);
        }

        private void txt_ventas_lista_Enter(object sender, EventArgs e)
        {
            txt_ventas_lista.SelectionStart = 0;
            txt_ventas_lista.SelectionLength = txt_ventas_lista.Text.Length;
        }


        private void combo_iva_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularSubtotal();
        }

        private void txt_ventas_cantidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_ventas_cantidad.Text.Trim() == "")
            {
                txt_ventas_cantidad.Text = "1";
                txt_ventas_cantidad.SelectionStart = 0;
                txt_ventas_cantidad.SelectionLength = txt_ventas_cantidad.Text.Length;
            }
            else
            {

                calcularSubtotal();

            }
        }

        private void txt_ventas_cantidad_Enter(object sender, EventArgs e)
        {
            txt_ventas_cantidad.SelectionStart = 0;
            txt_ventas_cantidad.SelectionLength = txt_ventas_cantidad.Text.Length;
        }

        private void combo_producto_Leave(object sender, EventArgs e)
        {

        }


        private void crearColumnasDgv_Tabla()
        {
            // I created these columns at function scope but if you want to access 
            // easily from other parts of your class, just move them to class scope.
            // E.g. Declare them outside of the function...
            var cantidad = new DataGridViewTextBoxColumn();
            var codigo = new DataGridViewTextBoxColumn();
            var descripcion = new DataGridViewTextBoxColumn();
            var precio = new DataGridViewTextBoxColumn();
            var iva = new DataGridViewTextBoxColumn();
            var subtotal = new DataGridViewTextBoxColumn();
            var lista = new DataGridViewTextBoxColumn();
            var borrar = new DataGridViewImageColumn();
            var elemento = new DataGridViewTextBoxColumn();
            var descuento = new DataGridViewTextBoxColumn();

            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "Cantidad";

            codigo.HeaderText = "Código";
            codigo.Name = "Codigo";

            descripcion.HeaderText = "Descripción";
            descripcion.Name = "Descripcion";

            precio.HeaderText = "Precio";
            precio.Name = "precio";

            iva.HeaderText = "IVA";
            iva.Name = "iva";

            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "Subtotal";

            lista.HeaderText = "Lista";
            lista.Name = "Lista";
            lista.Visible = false;

            borrar.HeaderText = "Borrar";
            borrar.Name = "Borrar";

            elemento.HeaderText = "Numero";
            elemento.Name = "Numero";
            elemento.Visible = false;


            dgv_tabla.Columns.AddRange(new DataGridViewColumn[] { cantidad, codigo, descripcion, precio, iva, subtotal, lista, borrar, elemento });
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            long ultimoid;
            ultimoid = guardarVentaEnBlanco();

            ControlVentas controlventas = new ControlVentas();
            Cliente cliente = new Cliente();
            Omega3.Modelo.Venta venta = new Omega3.Modelo.Venta();
            ControlVenta control = new ControlVenta();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ultimoid != 0)
                {
                    venta.remito = 0;
                    venta.ordendeCompra = "0";
                    venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
                    venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue);
                    if (txt_remito.Text.Trim() != "" || !string.IsNullOrEmpty(txt_remito.Text))
                    {
                        venta.remito = long.Parse(txt_remito.Text);
                    }
                    if (txt_ordenDeCompra.Text.Trim() != "" || !string.IsNullOrEmpty(txt_ordenDeCompra.Text))
                    {
                        venta.ordendeCompra = txt_ordenDeCompra.Text;
                    }
                    cliente = ControlCliente.obtenerCliente(long.Parse(cuit.Text));
                    cliente.Documento = long.Parse(cuit.Text);



                    string id_comprobante = string.Empty;

                    id_comprobante = control.Facturar(venta, cliente, listado_articulos);

                    
                    var task = Task.Factory.StartNew(() => controlventas.ActualizarFacturaYUrl(id_comprobante, ultimoid));

                    limpiarParteCliente();
                    lista.Clear();

                    elemento_clase = 0;

                    this.Close();


                }
                else { MessageBox.Show("Hubo un error al insertar en la base de datos."); }
            }
            catch (Exception ex) { MessageBox.Show("Hubo un error", Convert.ToString(ex)); }
            finally { Cursor.Current = Cursors.Default; }
        }



        private void dgv_tabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_tabla.Columns[e.ColumnIndex].Name == "Borrar")
            {
                e.Value = Properties.Resources.dgv_tabla_cancelar;
            }
        }

        private void calcularTotalVenta()
        {

            decimal totalVenta = new decimal(0);
            foreach (DataGridViewRow row in dgv_tabla.Rows)
            {
                totalVenta += Convert.ToDecimal(row.Cells["Subtotal"].Value);

            }
            lbl_ventas_total.Text = Convert.ToString(totalVenta);
        }

        private void limpiarCamposCabecera()
        {
            txt_ventas_cantidad.Text = "1";
            txt_ventas_codigo.Text = "";
            combo_producto.SelectedIndex = -1;
            txt_ventas_precio.Text = "";
            txt_ventas_lista.Text = "0";
        }

        private void combo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {

            ControladorFuncVariadas.autoCompletarCombo(sender, e, combo_producto);
            //var a = new ControladorFuncVariadas();
            //a.AutoComplete(combo_producto, e);

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Vista.Clientes.CrearCliente a = new Vista.Clientes.CrearCliente(ref combo_cliente);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void combo_cliente_Enter(object sender, EventArgs e)
        {
            combo_cliente.Text = "";
            combo_cliente.ForeColor = Color.Black;

            iniciarBusquedaCuit();

        }

        private void combo_cliente_Leave(object sender, EventArgs e)
        {
            //if (combo_cliente.SelectedIndex == -1)
            if(combo_cliente.Text.Trim() == "" || string.IsNullOrEmpty(combo_cliente.Text))
            {
                combo_cliente.ForeColor = Color.Gray;
                combo_cliente.SelectedIndex = -1;
                combo_cliente.Text = "Buscar por Razón Social";
            }
        }
        private void inicializarBusquedasRazon()
        {


            combo_cliente.ForeColor = Color.Gray;
            combo_cliente.SelectedIndex = -1;
            combo_cliente.Text = "Buscar por Razón Social";


        }

        private void iniciarBusquedaCuit()
        {
            buscar_cuit.Text = "Buscar por CUIT o DNI";
            buscar_cuit.ForeColor = Color.Gray;
        }

        private long guardarVentaEnBlanco()
        {
            long lastinserted = 0;
            if (cuit.Text != "")
            {
                if (dgv_tabla.Rows.Count != 0)
                {
                    Omega3.Modelo.Venta venta = new Modelo.Venta();
                    venta.ordendeCompra = "0";
                    venta.remito = 0;
                    if (txt_ordenDeCompra.Text.Trim() != "" || !string.IsNullOrEmpty(txt_ordenDeCompra.Text))
                    {
                        venta.ordendeCompra = txt_ordenDeCompra.Text;
                    }
                    if (txt_remito.Text.Trim() != "" || !string.IsNullOrEmpty(txt_remito.Text))
                    {
                        venta.remito = long.Parse(txt_remito.Text);
                    }
                    venta.documento = long.Parse(cuit.Text);
                    venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue.ToString());

                    if (combo_pago.Text == "Cheque" || combo_pago.Text == "Cuenta Corriente") 
                    {
                        venta.fecha_vencimiento_cheque = fecha_pago.Value;

                    }

                    venta.nrofactura = "0";
                    venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
                    venta.fecha_venta = DateTime.Now;



                    panel_principal.SelectedIndex = 0;

                    MessageBox.Show("Venta realizada correctamente!");

                    lastinserted = ControlVentas.AgregarVenta(dgv_tabla, venta);


                    dgv_tabla.Rows.Clear();
                    dgv_tabla.Refresh();
                    //limpiarParteCliente();
                    //lista.Clear();
                }
                else { MessageBox.Show("No hay ningun producto agregado"); }
            }
            else
            {
                panel_principal.SelectedIndex = 0;
                MessageBox.Show("Aún no se seleccionó un cliente");
            }
            return lastinserted;
        }

        private void btn_presupuesto_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (cuit.Text != "")
                {
                    if (dgv_tabla.Rows.Count != 0)
                    {
                        Omega3.Modelo.Venta venta = new Modelo.Venta();

                        venta.documento = long.Parse(cuit.Text);
                        venta.medio_de_pago = Convert.ToInt32(combo_pago.SelectedValue.ToString());

                        if (combo_pago.Text == "Cheque" || combo_pago.Text == "Cuenta Corriente") 
                        {
                            venta.fecha_vencimiento_cheque = fecha_pago.Value;

                        }

                        venta.nrofactura = "0";
                        venta.tipo_factura = Convert.ToString(combo_comprobante.SelectedValue);
                        venta.fecha_venta = DateTime.Now;

                        Factura_Negro factura = new Factura_Negro();
                        factura.Nombre = razon.Text;
                        factura.Documento = cuit.Text;
                        factura.Direccion = domicilio.Text;
                        factura.Fecha = DateTime.Now;


                        panel_principal.SelectedIndex = 0;

                        //MessageBox.Show("Venta realizada correctamente!");
                        long lastidventa;
                        lastidventa = ControlVentas.AgregarVenta(dgv_tabla, venta, 1);
                        Informes.Presupuesto presupuesto = new Informes.Presupuesto(lastidventa);
                        presupuesto.WindowState = FormWindowState.Maximized;
                        presupuesto.ShowDialog();

                        dgv_tabla.Rows.Clear();
                        dgv_tabla.Refresh();
                        limpiarParteCliente();
                        lista.Clear();
                        this.Close();
                    }
                    else { MessageBox.Show("No hay ningun producto agregado"); }
                }
                else
                {
                    panel_principal.SelectedIndex = 0;
                    MessageBox.Show("Aún no se seleccionó un cliente");
                }

            }
            catch (Exception ex) { MessageBox.Show("Hubo un error, contactar con el administrador: " + ex.ToString()); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //MessageBox.Show(lista.Count.ToString());
        }

        private void txt_remito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            foreach (Producto producto in lista)
            {
                MessageBox.Show(producto.Cod_producto.ToString() + " " + producto.Cantidad);
            }
        }

        private void combo_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            var a = new ControladorFuncVariadas();
            a.AutoComplete(combo_cliente, e);

        }
    }
}

