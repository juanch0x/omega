using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

    }

}
