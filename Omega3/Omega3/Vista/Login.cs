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

            this.Hide();

            Usuario user = new Usuario();
            user.User = txt_usuario.Text;
            user.Password = txt_pwd.Text;

            ControlUsuario login = new ControlUsuario();
            login.login(user);

            f1.MenuVentas.Visible = true;

        }
    }
}
