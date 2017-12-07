using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega3.Controlador
{
    class ControladorFuncVariadas
    {
        public static bool AccesoInternet()
        {

            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;

            }
            catch (Exception es)
            {
                Console.Write(es);
                return false;
            }

        }

        public static void validarSoloNumeros(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }


        }

        public static void validarNumerosConComas(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||
            e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back)
            )
                e.Handled = false;
            else
                e.Handled = true;

            if (e.KeyChar == '.'
             && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        public static String convertirFecha(DateTime dt)
        {
            string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return fecha;
        }


        //AutoCompleteSource para los combos

        public static void autoCompletarCombo(object sender, KeyPressEventArgs e, ComboBox combo_producto)
        {
            //ComboBox cb = (ComboBox)sender;
            combo_producto.DroppedDown = true;
            string strFindStr = "";
            if (e.KeyChar == (char)8)
            {
                if (combo_producto.SelectionStart <= 1)
                {
                    combo_producto.Text = "";
                    return;
                }

                if (combo_producto.SelectionLength == 0)
                    strFindStr = combo_producto.Text.Substring(0, combo_producto.Text.Length - 1);
                else
                    strFindStr = combo_producto.Text.Substring(0, combo_producto.SelectionStart - 1);
            }
            else
            {
                if (combo_producto.SelectionLength == 0)
                    strFindStr = combo_producto.Text + e.KeyChar;
                else
                    strFindStr = combo_producto.Text.Substring(0, combo_producto.SelectionStart) + e.KeyChar;
            }
            int intIdx = -1;
            // Search the string in the ComboBox list.
            intIdx = combo_producto.FindString(strFindStr);
            if (intIdx != -1)
            {
                combo_producto.SelectedText = "";
                combo_producto.SelectedIndex = intIdx;
                combo_producto.SelectionStart = strFindStr.Length;
                combo_producto.SelectionLength = combo_producto.Text.Length;
                e.Handled = true;
            }
            else
                e.Handled = true;
        }

        public static bool validarEmail(string mail)
        {
            try
            {
                var test = new MailAddress(mail);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }


//Funcion para fijarme que no haya ningun combo abierto para cerrar la ventana al apretar escape
        public static bool comboBoxAbierto(params ComboBox[] lista)
        {
           for(int i = 0; i< lista.Length; i++)
            {

                if (lista[i].DroppedDown == true)
                    return false;
                //Si está con el filtro activo no funciona, asi que la primera vez que aprieta escape estando en un combo abierto lo manda al siguiente foco
                //y despues efectivamente manda el true para cerrar la ventana
                else if (lista[i].DropDownStyle == ComboBoxStyle.DropDown && lista[i].ContainsFocus == true)
                {
                    SendKeys.Send("{TAB}");
                    return false;
                }
            }
            return true;
        }

        public static bool validarTextBoxVacios(params TextBox[] lista)
        {
            for(int i = 0; i<lista.Length; i++)
            {
                if(lista[i].Text.Trim() == "")
                {
                    MessageBox.Show("El campo " + lista[i].Tag + " es obligatorio");
                    lista[i].Focus();
                    
                    return false;
                }
            }

            return true;
        }

        public static bool validarFechaPasada(params DateTimePicker[] lista)
        {

            for(int i = 0; i<lista.Length; i++)
            {
               if(lista[i].Value <= DateTime.Now)
                {
                    MessageBox.Show("La fecha de entrega debe ser no puede ser anterior a la fecha actual");
                    lista[i].Focus();
                    return false;
                }
            }

            return true;
        }

        public static void limpiarTextBox(params TextBox[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i].Text = "";
        }

        public static bool chequearComprobante(string id_comprobante)
        {
           string url = Path.GetTempPath() + "Comprobante_" + id_comprobante + ".pdf";
            if (new FileInfo(url).Length == 0)
            {
                Console.WriteLine(url);
                return false;
            }
            System.Diagnostics.Process.Start(Path.GetTempPath() + "Comprobante_" + id_comprobante + ".pdf");
            Console.WriteLine(url);
            return true;

        }

        public static bool nuevoChequearComprobante(string id_comprobante)
        {
            using (WebClient obj = new WebClient())
            using (Stream s = obj.OpenRead(id_comprobante))
                if (long.Parse(obj.ResponseHeaders["Content-Length"].ToString()) > 0)
                {
                    return true;
                }
                else { return false; }
                
            
        }

        public static void cambiarVisibilidadBoton(bool estado,params Button[] botones)

        {

            foreach(Button btn in botones)
            {

                btn.Visible = estado;

            }


        }

        public static void cambiarVisibilidadLabel(bool estado,params Label[] etiquetas)
        {
            foreach (Label label in etiquetas)
            {
                label.Visible = estado;
            }
        }

        public static void cambiarVisibilidadTextBox(bool estado,params TextBox[] textbox) {

            foreach(TextBox txt in textbox)
            {
                txt.Visible = estado;
            }

        }

        public static void cambiarVisibilidadCombos(bool estado, params Control[] controls)
        {
            foreach(Control control in controls)
            {
                control.Visible = estado;
            }
        }

        public static string filtro_desde_hasta(DateTimePicker txt_desde, DateTimePicker txt_hasta)
        {

            string desde = String.Format("#" + "{0:MM/dd/yyyy}" + "#", txt_desde.Value.Date);
            string hasta = String.Format("#" + "{0:MM/dd/yyyy}" + "#", txt_hasta.Value.Date);

            string filter = "Fecha >= " + desde + " and Fecha <= " + hasta;

            return filter;
        }

    }


    }


