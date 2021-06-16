using LenCo.Modelo;
using System;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cargarUserLog();
            habilitarSubMenu(false);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            habilitarSubMenu(true);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmProducto());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres cerrar sesión?", "warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void abrirFormPanel(object formPanel)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fp = formPanel as Form; // convierto el object en un Form
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill; // se ajustara a panelContenedor
            this.panelContenedor.Controls.Add(fp);
            this.panelContenedor.Tag = fp;
            fp.Show();
        }

        private void cargarUserLog()
        {
            lblUsuarioLog.Text = "Bienvenido " + Usuario.pUsuario + "!";
            if (Usuario.pIdRol > 1)
            {
                btnAdmin.Visible = false;
            }
            else
            {
                btnProductos.Visible = false;
                btnVentas.Visible = false;
                btnDevoluc.Visible = false;
            }
        }

        private void btnAdmProductos_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmProducto());
            habilitarSubMenu(false);
        }

        private void habilitarSubMenu(bool x)
        {
            panelSubMenu.Visible = x;
        }

        private void btnAdmCompras_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmCompra());
            habilitarSubMenu(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres salir?", "warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdmVentas_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmVenta());
            habilitarSubMenu(false);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmVenta());
            habilitarSubMenu(false);
        }

        private void btnAdmDevoluc_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmDevoluciones());
            habilitarSubMenu(false);
        }

        private void btnDevoluc_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmDevoluciones());
            habilitarSubMenu(false);
        }
    }
}