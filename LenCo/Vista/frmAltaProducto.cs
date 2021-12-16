using LenCo.Modelo;
using System;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto(int itemcMarca, int itemcRubro, int itemcTalle, int itemcColor)
        {
            InitializeComponent();
            Gestor gestor = new Gestor();

            gestor.cargarCombo(cbMarca, "Marcas");
            gestor.cargarCombo(cbRubro, "Rubros");
            gestor.cargarCombo(cbTalle, "Talles");
            gestor.cargarCombo(cbColor, "Colores");

            cbMarca.SelectedValue = itemcMarca;
            cbRubro.SelectedValue = itemcRubro;
            cbTalle.SelectedValue = itemcTalle;
            cbColor.SelectedValue = itemcColor;
            bloquearCombos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Gestor gestor = new Gestor();

                string codProv = txtCodigo.Text;
                int art = Convert.ToInt32(txtArticulo.Text);
                int idMarca = Convert.ToInt32(cbMarca.SelectedValue);
                int idRubro = Convert.ToInt32(cbRubro.SelectedValue);
                int idColor = Convert.ToInt32(cbColor.SelectedValue);
                int idTalle = Convert.ToInt32(cbTalle.SelectedValue);
                int present;
                if (rbIndividual.Checked)
                {
                    present = 1;
                }
                else
                {
                    present = 2;
                }
                double preVta = Convert.ToDouble(txtPrecio.Text);
                string descrip = txtDescrip.Text;
                bool activo = true;

                Marca marca = new Marca(idMarca);
                Rubro rubro = new Rubro(idRubro);
                Presentacion pres = new Presentacion(present);
                Talle talle = new Talle(idTalle);
                Color color = new Color(idColor);

                Producto cargado = new Producto(0, codProv, marca, rubro, art, talle, color, pres, descrip, preVta, activo);
                gestor.cargarProducto(cargado);
                if (cargado != null)
                {
                    MessageBox.Show("Producto cargado con exito.");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message);
            }
        }

        private void bloquearCombos()
        {
            cbMarca.Enabled = false;
            cbRubro.Enabled = false;
            cbTalle.Enabled = false;
            cbColor.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            func_soloNumeros(txtArticulo);
        }
        private void func_soloNumeros(TextBox textbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números enteros.");
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}