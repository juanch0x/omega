﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega3.Modelo;
using System.Windows.Forms;
using Omega3.Vista;
using Omega3.Controlador;

namespace Omega3.Controlador
{
    class ControlPresupuesto
    {

        public static List<EArticulo> FillDgv()
        {
            //
            //Cree una lista generica de la entidad EArticulo
            //
            List<EArticulo> listaArticulos = new List<EArticulo>();

            //
            //Instancie la clase EArticulo para agregar datos a la lista
            //
            EArticulo item = new EArticulo
            {
                //Establezca valores a cada una de las propiedades
                Numero = 1,
                Cod = "7501020405680",
                Descripcion = "Descripción del artículo 1",
                Cantidad = 6,
                Precio = new decimal(12.50),
                Importe = (decimal)(6 * 12.5),
            };
            //
            //Agregamos el Item a la lista
            //
            listaArticulos.Add(item);

            EArticulo item1 = new EArticulo
            {
                Numero = 2,
                Cod = "7501040805610",
                Descripcion = "Descripción del artículo 2",
                Cantidad = 3,
                Precio = new decimal(22.50),
                Importe = (decimal)(3 * 22.5),
            };
            listaArticulos.Add(item1);

            EArticulo item2 = new EArticulo
            {
                Numero = 3,
                Cod = "0412200805610",
                Descripcion = "Descripción del artículo 3",
                Cantidad = 20,
                Precio = new decimal(52.80),
                Importe = (decimal)(20 * 52.80),
            };
            listaArticulos.Add(item2);
            
            return listaArticulos;
        }

        private static int GenerateNumber()
        {
            Random rdm = new Random();

            return rdm.Next();
        }

        public static void InvoiceGenerate(DataGridView dgvdetalle)
        {
            //
            //Hacemos una instancia de la clase EFactura para
            //llenarla con los valores contenidos en los controles del Formulario
            EFactura Cabecera = new EFactura();
            Cabecera.Numero = Convert.ToInt32(1);
            Cabecera.Nombre = "Martín Mestre";
            Cabecera.Documento = "2234755449222";
            Cabecera.Direccion = "Av. Siempre Viva 289381 Perón";
            Cabecera.FechaFacturacion = DateTime.Now;
            Cabecera.Subtotal = Convert.ToDecimal("22.2");
            Cabecera.Iva = Convert.ToDecimal("21");
            Cabecera.Total = Convert.ToDecimal("44");

            //Recorremos los Rows existentes actualmente en el control DataGridView
            //para asignar los datos a las propiedades
            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {
                EArticulo article = new EArticulo();
                //
                //Vamos tomando los valores de las celdas del row que estamos 
                //recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
                //
                article.Numero = Convert.ToInt32(row.Cells[0].Value);
                article.Cod = Convert.ToString(row.Cells[1].Value);
                article.Descripcion = Convert.ToString(row.Cells[2].Value);
                article.Cantidad = Convert.ToDecimal(row.Cells[3].Value);
                article.Precio = Convert.ToDecimal(row.Cells[4].Value);
                article.Importe = Convert.ToDecimal(row.Cells[5].Value);

                //
                //Vamos agregando el Item a la lista del detalle
                //
                Cabecera.Detail.Add(article);
            }

            //
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
            Vista.Presupuesto.Informe frm = new Vista.Presupuesto.Informe();
            
            //
            //Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
            //que se mostrara en los parametros creados en el LocalReport, para este ejemplo
            //estamos Seteando los valores directamente pero usted puede usar algun control
            //
         
            //
            //Recuerde que invoice es una Lista Generica declarada en el FacturaRtp, es una lista
            //porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
            //implementen IEnumerable.
            //
            //Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
            frm.Cabecera.Add(Cabecera);
            //
            //Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
            //es un lista del tipo EArticulo bastara con igualarla
            //
            frm.Detalle = Cabecera.Detail;
            frm.Show();

        }
    }
}


