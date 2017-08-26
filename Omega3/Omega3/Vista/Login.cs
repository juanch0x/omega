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

namespace Omega3.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Principal f1 = (Principal)this.MdiParent;
            f1.menu.Visible = true;

            //this.Hide();

            Boolean logueocorrecto = false;
            
            Usuario.User = txt_usuario.Text;
            Usuario.Password = txt_pwd.Text;

            ControlUsuario login = new ControlUsuario();

            logueocorrecto = login.login();
            this.Visible = false;
                if (logueocorrecto){

                this.Hide();

                                    }

                else {
                
                    this.Visible = true;
                    txt_usuario.Text = "";
                    txt_pwd.Text = "";
                    txt_usuario.Focus();
                    }

            f1.MenuVentas.Visible = true;
            f1.MenuProducto.Visible = true;

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_login_Click(sender,e);
            }
        }
    }
}
