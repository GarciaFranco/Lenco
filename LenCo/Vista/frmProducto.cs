using LenCo.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace LenCo
{
    public partial class frmProducto : Form
    {
        private bool accModificar = false;

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
                gbStock.Visible = true;
                cargarDatosAmodificar();
            }
            else
            {
                msg("Debes seleccionar una fila para modificar.");
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
                        limpiar();
                        msg("Producto cargado con exito.");
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
                        limpiar();
                        msg("Producto modificado con exito.");
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
                        limpiar();
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
                msg("Debes seleccionar una fila para eliminar.");
            }
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            int stockN1 = Convert.ToInt32(txtStockN1.Text);
            int stockN2 = Convert.ToInt32(txtStockN2.Text);
            int stockAlmacen = Convert.ToInt32(txtStockAlmacen.Text);
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());

            Stock stockSucursal1 = new Stock(1, idProducto, stockN1);
            Stock stockSucural2 = new Stock(2, idProducto, stockN2);
            Stock stockSucursal3 = new Stock(3, idProducto, stockAlmacen);

            string sucVacio = dgvProductos.CurrentRow.Cells["Negocio"].Value.ToString();
            string stockVacio = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();

            Gestor gestor = new Gestor();
            if (string.IsNullOrEmpty(stockVacio) && string.IsNullOrEmpty(sucVacio))
            {
                gestor.cargarStocks(stockSucursal1);
                gestor.cargarStocks(stockSucural2);
                limpiar();
            }
            else
            {
                gestor.modificarStock(stockSucursal1);
                gestor.modificarStock(stockSucural2);
                gestor.modificarStock(stockSucursal3);
                limpiar();
            }
            cargarListas();
            gbProducto.Visible = false;
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
            txtStockAlmacen.Clear();
            txtStockN1.Clear();
            txtStockN2.Clear();
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

            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());

            Producto producto = gestor.cargarDatosDelProducto(idProducto);
            cargarCombos();
            txtArticulo.Text = producto.pArticulo.ToString();
            txtCodigo.Text = producto.pCodigoProv;
            txtPrecio.Text = producto.pPrecioVenta.ToString();
            txtDescrip.Text = producto.pDescripcion;
            cbRubro.SelectedValue = producto.pRubro.pIdRubro;
            cbMarca.SelectedValue = producto.pMarca.pIdMarca;
            cbTalle.SelectedValue = producto.pTalle.pIdTalle;
            cbColor.SelectedValue = producto.pColor.pIdColor;

            if (producto.pPresent.pIdPresentacion == 1)
            {
                rbIndividual.Select();
            }
            else
            {
                rbPack.Select();
            }
            int cantStockSuc1 = gestor.verStock(idProducto, 1);
            int cantStockSuc2 = gestor.verStock(idProducto, 2);
            int cantStockAlmacen = gestor.verStock(idProducto, 3);

            txtStockN1.Text = cantStockSuc1.ToString();
            txtStockN2.Text = cantStockSuc2.ToString();
            txtStockAlmacen.Text = cantStockAlmacen.ToString();
        }

        private void cargarListas()
        {
            Gestor gestor = new Gestor();
            string sql = "exec TodosLosProductosActivos"; // muestra todos los productos cargados en la BD tengan o no stock

            DataTable productos = gestor.mostrarConsulta(sql);
            dgvProductos.DataSource = productos;
            dgvProductos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ocultarInfoData();

            DataTable reporte = gestor.listadosStockBajo();
            dgvReportePocoStock.DataSource = reporte;
        }

        private void ocultarBotones(bool x)
        {
            gbProducto.Visible = !x;
            gbStock.Visible = !x;
            if (Usuario.pIdRol > 1)
            {
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
        }

        private void msg(string msg)
        {
            MessageBox.Show(msg);
        }

        /* BOTON MODIFICAR ELIMINADO.
         * REALIZAR GESTIONAMIENTO DE STOCK DESDE EL BOTON MODIFICAR
         * CONSULTAR STOCK DEL PRODUCTO */

        //private void btnEditarStock_Click(object sender, EventArgs e)
        //{
        //    if (dgvProductos.SelectedRows.Count > 0)
        //    {
        //        cargarDatosAmodificar();
        //        gbProducto.Visible = true;
        //        gbProducto.Enabled = false;
        //        gbStock.Visible = true;
        //        int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value.ToString());

        //        Gestor gestor = new Gestor();

        //        int stock1 = gestor.verStock(idProducto, 1);
        //        int stock2 = gestor.verStock(idProducto, 2);

        //        txtStockN1.Text = Convert.ToString(stock1);
        //        txtStockN2.Text = Convert.ToString(stock2);
        //    }
        //    else
        //    {
        //        msg("Debes seleccionar una fila para modificar el stock.");
        //    }
        //}
    }
}