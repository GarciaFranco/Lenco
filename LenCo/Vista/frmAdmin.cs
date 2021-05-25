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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            abrirFormPanel(new frmProducto());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new frmProducto());
        }
        private void abrirFormPanel(object formPanel)
        {
            if (this.panelGestiones.Controls.Count > 0)
                this.panelGestiones.Controls.RemoveAt(0);
            Form fp = formPanel as Form; // convierto el object en un Form
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill; // se ajustara a panelContenedor
            this.panelGestiones.Controls.Add(fp);
            this.panelGestiones.Tag = fp;
            fp.Show();
        }
    }
}
