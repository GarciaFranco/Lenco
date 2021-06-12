using LenCo.Vista;
using System;
using System.Windows.Forms;

namespace LenCo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();

            string usuario = txtUser.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(usuario) || !string.IsNullOrEmpty(usuario))
            {
                if (gestor.existeUsuario(usuario, password))
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    principal.FormClosed += Logout; // al cerrar sesion, me abre el formLogin, no cierra la aplicacion.
                    this.Hide();
                }
                else
                {
                    msgError("Usuario y/o Contraseña incorrecto.");
                }
            }
            else
            {
                msgError("Ingrese un usuario y contraseña.");
            }
            limpiarCampos();
        }

        private void msgError(string msg)
        {
            lblMsgError.Text = msg;
            lblMsgError.Visible = true;
        }

        private void limpiarCampos()
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            limpiarCampos();
            lblMsgError.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}