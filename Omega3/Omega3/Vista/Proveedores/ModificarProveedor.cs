﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega3.Modelo;
using Omega3.Controlador;
namespace Omega3.Vista.Proveedores
{
    public partial class ModificarProveedor : Form
    {
        Proveedor proveedor = new Proveedor();

        public ModificarProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            txt_telefono.MaxLength = 15;
            txt_codigo_postal.MaxLength = 6;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Id_proveedor = this.proveedor.Id_proveedor;

            //FALTA VALIDAR Email secundario y terciario (formato)
            if (ControladorFuncVariadas.validarTextBoxVacios(txt_codigo_postal, txt_direccion, txt_proveedor, txt_provincia, txt_telefono))
            {

                proveedor.Nombre_proveedor = txt_proveedor.Text;
                proveedor.Telefono = long.Parse(txt_telefono.Text);
                proveedor.Direccion = txt_direccion.Text;
                proveedor.Provincia = txt_provincia.Text;
                proveedor.Codigo_postal = int.Parse(txt_codigo_postal.Text);
                proveedor.Nombre1 = txt_nombre1.Text;
                proveedor.Nombre2 = txt_nombre2.Text;
                proveedor.Nombre3 = txt_nombre3.Text;
                proveedor.Telefono1 = txt_telefono1.Text;
                proveedor.Telefono2 = txt_telefono2.Text;
                proveedor.Telefono3 = txt_telefono3.Text;

                

                    proveedor.Email = txt_email.Text;
                    proveedor.Email2 = txt_email2.Text;
                    proveedor.Email3 = txt_email3.Text;

                    //proveedor.puntaje = new PuntajeProveedor();

                    //Transporte
                    proveedor.puntaje.transporte_posicion = Convert.ToInt32(combo_transporte_posicion.Text);
                    proveedor.puntaje.transporte_Prestigio = Convert.ToInt32(combo_transporte_prestigio.Text);
                    proveedor.puntaje.transporte_antecedentes = Convert.ToInt32(combo_transporte_antecedentes.Text);
                    proveedor.puntaje.transporte_financiera = Convert.ToInt32(combo_transporte_financiera.Text);
                    proveedor.puntaje.transporte_transporte = Convert.ToInt32(combo_transporte_pais.Text);
                    proveedor.puntaje.transporte_capacidad = Convert.ToInt32(combo_transporte_capacidad.Text);

                    //Calidad
                    proveedor.puntaje.calidad_plazos = Convert.ToInt32(combo_calidad_plazo.Text);
                    proveedor.puntaje.calidad_costo = Convert.ToInt32(combo_calidad_costo.Text);
                    proveedor.puntaje.calidad_cuidado = Convert.ToInt32(combo_calidad_cuidado.Text);

                    //Pagos
                    proveedor.puntaje.pago_plazo = Convert.ToInt32(combo_pagos_plazo.Text);
                    proveedor.puntaje.pago_descuento = Convert.ToInt32(combo_pago_descuento.Text);

                    //Otros
                    proveedor.puntaje.otros_respuesta = Convert.ToInt32(combo_otros_respuesta.Text);
                    proveedor.puntaje.otros_administrativa = Convert.ToInt32(combo_otros_administrativa.Text);
                    proveedor.puntaje.otros_pedidos = Convert.ToInt32(combo_otros_capacidad.Text);

                    
                    if (ControlProveedor.ModificarProveedor(proveedor) == 1)
                    {

                        MessageBox.Show("Se modificó correctamente!");
                        ControladorFuncVariadas.limpiarTextBox(txt_codigo_postal, txt_direccion, txt_email, txt_email2, txt_email3, txt_proveedor, txt_provincia, txt_telefono);
                        this.Close();
                        
                        
                    }
                
                

            }

        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            //Tags
            txt_provincia.Tag = "Provincia";
            txt_telefono.Tag = "Telefono";
            txt_proveedor.Tag = "Proveedor";
            txt_email.Tag = "Email";
            txt_direccion.Tag = "Dirección";
            txt_codigo_postal.Tag = "Codigo Postal";
            
            //Cargo la ventana 1

            proveedor = Omega3.Controlador.ControlProveedor.buscarEmails(proveedor);

            txt_proveedor.Text = proveedor.Nombre_proveedor;
            txt_telefono.Text = Convert.ToString(proveedor.Telefono);
            txt_direccion.Text = proveedor.Direccion;
            txt_provincia.Text = proveedor.Provincia;
            txt_codigo_postal.Text = Convert.ToString(proveedor.Codigo_postal);
            txt_email.Text = proveedor.Email;
            txt_email2.Text = proveedor.Email2;
            txt_email3.Text = proveedor.Email3;
            txt_nombre1.Text = proveedor.Nombre1;
            txt_nombre2.Text = proveedor.Nombre2;
            txt_nombre3.Text = proveedor.Nombre3;
            txt_telefono1.Text = proveedor.Telefono1;
            txt_telefono2.Text = proveedor.Telefono2;
            txt_telefono3.Text = proveedor.Telefono3;


            //Cargo los puntajes

            proveedor.puntaje = new PuntajeProveedor();
            proveedor.puntaje = Controlador.ControlProveedor.buscarPuntajes(proveedor.Id_proveedor);

            //Transporte
            combo_transporte_posicion.SelectedIndex = combo_transporte_posicion.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_posicion));
            combo_transporte_antecedentes.SelectedIndex = combo_transporte_antecedentes.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_antecedentes));
            combo_transporte_capacidad.SelectedIndex = combo_transporte_capacidad.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_capacidad));
            combo_transporte_financiera.SelectedIndex = combo_transporte_financiera.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_financiera));
            combo_transporte_pais.SelectedIndex = combo_transporte_pais.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_transporte));
            combo_transporte_prestigio.SelectedIndex = combo_transporte_prestigio.FindStringExact(Convert.ToString(proveedor.puntaje.transporte_Prestigio));


            //Calidad
            combo_calidad_costo.SelectedIndex = combo_calidad_costo.FindStringExact(Convert.ToString(proveedor.puntaje.calidad_costo));
            combo_calidad_cuidado.SelectedIndex = combo_calidad_cuidado.FindStringExact(Convert.ToString(proveedor.puntaje.calidad_cuidado));
            combo_calidad_plazo.SelectedIndex = combo_calidad_plazo.FindStringExact(Convert.ToString(proveedor.puntaje.calidad_plazos));

            //Pagos
            combo_pagos_plazo.SelectedIndex = combo_pagos_plazo.FindStringExact(Convert.ToString(proveedor.puntaje.pago_plazo));
            combo_pago_descuento.SelectedIndex = combo_pago_descuento.FindStringExact(Convert.ToString(proveedor.puntaje.pago_descuento));

            //Otros
            combo_otros_administrativa.SelectedIndex = combo_otros_administrativa.FindStringExact(Convert.ToString(proveedor.puntaje.otros_administrativa));
            combo_otros_capacidad.SelectedIndex = combo_otros_capacidad.FindStringExact(Convert.ToString(proveedor.puntaje.otros_pedidos));
            combo_otros_respuesta.SelectedIndex = combo_otros_respuesta.FindStringExact(Convert.ToString(proveedor.puntaje.otros_respuesta));

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void txt_codigo_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor a = new Proveedor();
            a.puntaje = new PuntajeProveedor();
            ControlProveedor.ModificarPuntajes(a);
        }

        private void txt_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void txt_telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }

        private void txt_telefono3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControladorFuncVariadas.validarSoloNumeros(sender, e);
        }
    }
}
