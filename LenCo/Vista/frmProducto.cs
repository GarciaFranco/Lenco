using LenCo.Modelo;
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
    public partial class frmProducto : Form
    {
        bool accModificar = false;
        public frmProducto()
        {
            InitializeComponent();
            cargarListas();
            cargarCombos();
            ocultarBotones(true);
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            limpiar();
            ocultarBotones(false);
            gbStock.Visible = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                accModificar = true;
                gbProducto.Enabled = true;
                gbProducto.Visible = true;
                gbStock.Visible = false;
                cargarDatosAmodificar();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar.");
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {

            Gestor gestor = new Gestor();
            try
            {
                string codProv = txtCodigo.Text;
                int art = Convert.ToInt32(txtArticulo.Text);
                double preVta = Convert.ToDouble(txtPrecio.Text);
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
                string descrip = txtDescrip.Text;
                bool activo = true;

                Marca marca = new Marca(idMarca);
                Rubro rubro = new Rubro(idRubro);
                Presentacion pres = new Presentacion(present);
                Talle talle = new Talle(idTalle);
                Color color = new Color(idColor);

                if (accModificar == false)
                {
                    Producto cargado = new Producto(0, codProv, marca, rubro, art, talle, color, pres, descrip, preVta, activo);
                    gestor.cargarProducto(cargado);
                    if (cargado != null)
                    {
                        msg("Producto cargado con exito.");
                        limpiar();
                    }
                }
                else
                {
                    cargarDatosAmodificar();

                    int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());
                    Producto modificado = new Producto(id, codProv, marca, rubro, art, talle, color, pres, descrip, preVta, activo);
                    gestor.modificarProducto(modificado);
                    if (modificado != null)
                    {
                        msg("Producto modificado con exito.");
                        limpiar();
                        ocultarBotones(true);
                        accModificar = false;
                    }
                }
                cargarListas();
            }
            catch (Exception ex)
            {
                msg("Hubo un error: " + ex);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Estas seguro de desea eliminar este producto? Esta accion no se podra deshacer", "warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Gestor gestor = new Gestor();
                    try
                    {
                        int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());
                        gestor.eliminarProducto(idProducto);
                        msg("Producto eliminado con exito");
                        cargarListas();
                    }
                    catch (Exception ex)
                    {
                        msg("Hubo un error al eliminar el producto: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar.");
            }
        }
        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            int stockN1 = Convert.ToInt32(txtStockN1.Text);
            int stockN2 = Convert.ToInt32(txtStockN2.Text);
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());

            Stock stockSucursal1 = new Stock(1, idProducto, stockN1);
            Stock stockSucural2 = new Stock(2, idProducto, stockN2);

            string vacioSuc = dgvProductos.CurrentRow.Cells["Negocio"].Value.ToString();
            string vacioStock = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();

            Gestor gestor = new Gestor();
            if (string.IsNullOrEmpty(vacioStock) && string.IsNullOrEmpty(vacioSuc))
            { 
                gestor.cargarStocks(stockSucursal1);
                gestor.cargarStocks(stockSucural2);
            }
            else
            {
                gestor.modificarStock(stockSucursal1);
                gestor.modificarStock(stockSucural2);
 
            }
            cargarListas();
        }
        private void limpiar()
        {
            txtArticulo.Clear();
            txtCodigo.Clear();
            txtDescrip.Clear();
            txtPrecio.Clear();
            cbTalle.SelectedIndex = -1;
            cbColor.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbRubro.SelectedIndex = -1;
            rbIndividual.Checked = false;
            rbPack.Checked = false;
        }
        private void cargarCombos()
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbColor, "Colores");
            gestor.cargarCombo(cbMarca, "Marcas");
            gestor.cargarCombo(cbRubro, "Rubros");
            gestor.cargarCombo(cbTalle, "Talles");
        }
        private void cargarDatosAmodificar()
        {
            Gestor gestor = new Gestor();
            // DATOS DEL PRODUCTO 
            cargarCombos();
            txtArticulo.Text = dgvProductos.CurrentRow.Cells["Articulo"].Value.ToString();
            int talle = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Talle"].Value.ToString());
            cbTalle.SelectedValue = talle;
            int marca = Convert.ToInt32(dgvProductos.CurrentRow.Cells["MarcaID"].Value.ToString());
            cbMarca.SelectedValue = marca;
            int rubro = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Rubro"].Value.ToString());
            cbRubro.SelectedValue = rubro;
            int color = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Color"].Value.ToString());
            cbColor.SelectedValue = color;
            txtCodigo.Text = dgvProductos.CurrentRow.Cells["Cod Producto"].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
            txtDescrip.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
            if (dgvProductos.CurrentRow.Cells["Presentacion"].Value.ToString() == "Individual")
            {
                rbIndividual.Select();
            }
            else
            {
                rbPack.Select();
            }
        }
        private void cargarListas()
        {
            Gestor gestor = new Gestor();
            string sql = "exec AllProducts"; // muestra todos los productos cargados en la BD tengan o no stock

            DataTable productos = gestor.mostrarConsulta(sql);
            dgvProductos.DataSource = productos;
            ocultarInfoData();
        }
        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                cargarDatosAmodificar();
                gbProducto.Visible = true;
                gbProducto.Enabled = false;
                gbStock.Visible = true;
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());

                Gestor gestor = new Gestor();

                int stock1 = gestor.verStock(idProducto, 1);
                int stock2 = gestor.verStock(idProducto, 2);

                txtStockN1.Text = Convert.ToString(stock1);
                txtStockN2.Text = Convert.ToString(stock2);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar.");
            }
        }

        private void ocultarBotones(bool x)
        {
            gbProducto.Visible = !x;
            gbStock.Visible = !x;
            if (Usuario.pIdRol > 1)
            {
                btnAlta.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
            }
        }
        private void ocultarInfoData()
        {
            dgvProductos.Columns["ID"].Visible = false;
            dgvProductos.Columns["Talle"].Visible = false;
            dgvProductos.Columns["Color"].Visible = false;
            dgvProductos.Columns["Rubro"].Visible = false;
            dgvProductos.Columns["MarcaID"].Visible = false;
        }
        private void msg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
