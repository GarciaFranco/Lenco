using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmDevoluciones : Form
    {
        private List<string> listaEntrante;
        private List<string> listaSaliente;
        private double montoEntrante;
        public frmDevoluciones()
        {
            InitializeComponent();
            montoEntrante = 0;
            listaEntrante = new List<string>();
            listaSaliente = new List<string>();
            rbProducto.Checked = true;
            txtProductoEntra.Enabled = false;
            txtProductoSale.Enabled = false;
        }

        private void rbNotaCredito_CheckedChanged(object sender, EventArgs e)
        {
            lblSalida.Text = "Nota de credito por:";
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            lblSalida.Text = "Producto Saliente:";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {

            }
        }
        private bool camposCompletos()
        {
            if (txtProductoEntra.Text == "")
            {
                MessageBox.Show("Debes ingresar un producto.");
                txtProductoEntra.Focus();
                return false;
            }
            if(txtProductoSale.Text == "")
            {
                MessageBox.Show("Debes ingresar una salida.");
                txtProductoSale.Focus();
                return false;
            }
            return true;
        }
        private void txtProductoEntra_Enter(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            int codigoVenta = Convert.ToInt32(txtCodigo.Text);
            bool devolucionAprobada = gestor.aprobarDevolucion(codigoVenta);

            if (devolucionAprobada)
            {
                txtProductoEntra.Focus();
            }
            else
            {
                MessageBox.Show("No se pueden devolver productos para esa venta. Se superaron los 7 dias de devolución.");
                txtCodigo.Clear();
                txtProductoEntra.Enabled = false;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtProductoEntra.Enabled = true;
        }

        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            lstEntrante.Items.Clear();
            string codigoProducto = txtProductoEntra.Text;
            double montoEntrante = 0;
            listaEntrante.Add(codigoProducto);
            txtProductoEntra.Clear();

            foreach (var item in listaEntrante)
            {
                lstEntrante.Items.Add(item);
            }
        }
    }
}
