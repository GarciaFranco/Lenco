using System;
using System.Data;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
            rbSi.Checked = true;
            cargarProveedores();
            cargarDetalleCompra();
            cargarCompras();
        }

        private void btnCargarDetalle_Click(object sender, EventArgs e)
        {
            if (controlarCarga())
            {
                DateTime fechaCompra = dtpFechCompra.Value;
                int nroComprobante = 0;
                int factura;
                if (rbSi.Checked)
                {
                    nroComprobante = Convert.ToInt32(txtComprobante.Text);
                    factura = 1;
                }
                else
                {
                    factura = 0;
                }
                int itemCombo = Convert.ToInt32(cbProveedores.SelectedValue);

                frmDetalleCompra detalle = new frmDetalleCompra(fechaCompra, factura, nroComprobante, itemCombo);
                detalle.ShowDialog();
                cargarDetalleCompra();
                cargarCompras();
                limpiarCampos();
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            txtComprobante.Enabled = false;
            txtComprobante.Text = "";
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            txtComprobante.Enabled = true;
        }

        private bool controlarCarga()
        {
            if (rbSi.Checked && string.IsNullOrEmpty(txtComprobante.Text))
            {
                MessageBox.Show("Debes ingresar un numero de comprobante.");
                txtComprobante.Focus();
                return false;
            }
            if (cbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un proveedor.");
                cbProveedores.Focus();
                return false;
            }
            return true;
        }

        private void cargarProveedores()
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbProveedores, "Proveedores");
        }

        private void cargarDetalleCompra()
        {
            Gestor gestor = new Gestor();
            DataTable dt = gestor.listadoDetalleCompras();
            dgvDetalleCompra.DataSource = dt;
            dgvDetalleCompra.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleCompra.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void cargarCompras()
        {
            Gestor gestor = new Gestor();
            DataTable dt = gestor.listadoCompras();
            dgvCompras.DataSource = dt;
            dgvCompras.Columns["Total de la compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lblTotalCompra.Text = Convert.ToString(gestor.calcularMontoUltimaCompra());
        }

        private void limpiarCampos()
        {
            rbSi.Checked = true;
            rbNo.Checked = false;
            txtComprobante.Clear();
            cbProveedores.SelectedIndex = -1;
        }
    }
}