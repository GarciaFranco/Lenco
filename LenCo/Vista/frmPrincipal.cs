using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenCo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cargarUserLog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmAdmin());
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

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres salir?", "warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
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
        }
    }
}
