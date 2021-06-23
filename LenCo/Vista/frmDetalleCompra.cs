using LenCo.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmDetalleCompra : Form
    {
        private List<DetalleCompra> lista = new List<DetalleCompra>();
        private int itemSeleccionado;

        private int num_comprobante;
        private int tieneFactura;
        private int idProveedor;
        private DateTime fechaCompra;

        public frmDetalleCompra(DateTime fecha, int factura, int nroComprobante, int itemCombo)
        {
            fechaCompra = fecha;
            tieneFactura = factura;
            num_comprobante = nroComprobante;
            idProveedor = itemCombo;
            InitializeComponent();
            cargarCombos();
            habilitarControles(true);
            dgvDetalleCompra.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public frmDetalleCompra()
        {
            InitializeComponent();
            cargarCombos();
            habilitarControles(true);
        }

        private void cbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbRubro, "Rubros");

            int item = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            itemSeleccionado = item;
        }

        private void cbRubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbTalle, "Talles");

            int item = Convert.ToInt32(cbRubro.SelectedValue.ToString());
            itemSeleccionado = item;
        }

        private void cbTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbColor, "Colores");

            int item = Convert.ToInt32(cbTalle.SelectedValue.ToString());
            itemSeleccionado = item;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAlDetalle.Rows.Count > 0)
            {
                dgvProductosAlDetalle.DataSource = null;
            }

            if (cbMarca.SelectedIndex != -1 && cbRubro.SelectedIndex != -1 && cbTalle.SelectedIndex != -1 && cbColor.SelectedIndex != -1)
            {
                try
                {
                    Gestor gestor = new Gestor();

                    int marca = Convert.ToInt32(cbMarca.SelectedValue.ToString());
                    int rubro = Convert.ToInt32(cbRubro.SelectedValue.ToString());
                    int talle = Convert.ToInt32(cbTalle.SelectedValue.ToString());
                    int color = Convert.ToInt32(cbColor.SelectedValue.ToString());

                    string sql = @"SELECT idProducto 'ID', pd.articulo 'Articulo', pd.descripcion 'Descripcion' , m.nombre 'Marca', t.nombre 'Talle', pr.nombre 'Presentacion'
                                FROM Productos pd
                                JOIN Presentaciones pr on pd.idPresentacion = pr.idPresentacion
                                JOIN Marcas m on pd.idMarca = m.idMarca
                                JOIN Talles t on pd.idTalle = t.idTalle
                                WHERE pd.idMarca = " + marca +
                                    " and  pd.idRubro = " + rubro +
                                    " and  pd.idColor = " + color +
                                    " and  pd.idTalle = " + talle;

                    DataTable productos = gestor.mostrarConsulta(sql);

                    if (productos.Rows.Count > 0)
                    {
                        dgvProductosAlDetalle.Rows.Clear();
                        dgvProductosAlDetalle.DataSource = productos;
                        ocultarInfoData();
                    }
                    else
                    {
                        dgvProductosAlDetalle.Rows.Clear();
                        lblError.Visible = true;
                        btnCargar.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos a completar. Intenta nuevamente");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool cargaRealizada = false;

            Gestor gestor = new Gestor();
            int maxIDProd = gestor.ultimoIDCargado();

            int marca = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            int rubro = Convert.ToInt32(cbRubro.SelectedValue.ToString());
            int talle = Convert.ToInt32(cbTalle.SelectedValue.ToString());
            int color = Convert.ToInt32(cbColor.SelectedValue.ToString());

            frmAltaProducto datos = new frmAltaProducto(marca, rubro, talle, color);
            datos.ShowDialog();

            lblError.Visible = false;
            btnCargar.Visible = false;
            int idProducto = gestor.ultimoIDCargado(); // Devuelve el ultimo idProducto que se cargo en la BD.

            if (maxIDProd != idProducto)
            {
                cargaRealizada = true;
            }
            if (cargaRealizada)
            {
                string sql = @"SELECT pd.idProducto 'ID', pd.articulo 'Articulo', pd.descripcion 'Descripcion' , m.nombre 'Marca', t.nombre 'Talle', pr.nombre 'Presentacion'
                            FROM Productos pd
                            JOIN Presentaciones pr on pd.idPresentacion = pr.idPresentacion
                            JOIN Marcas m on pd.idMarca = m.idMarca
                            JOIN Talles t on pd.idTalle = t.idTalle
                            WHERE pd.idProducto = " + idProducto;

                DataTable resultado = gestor.mostrarConsulta(sql);
                dgvProductosAlDetalle.DataSource = resultado;
                ocultarInfoData();
            }
        }

        private void dgvProductosAlDetalle_SelectionChanged(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            txtPrecioCompra.Enabled = true;
            btnAñadir.Enabled = true;
            lblError.Visible = false;
            btnCargar.Visible = false;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();

            if (!string.IsNullOrEmpty(txtCantidad.Text) || !string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                if (dgvProductosAlDetalle.SelectedRows.Count > 0)
                {
                    int idProducto = Convert.ToInt32(dgvProductosAlDetalle.CurrentRow.Cells["ID"].Value.ToString());

                    Producto producto = new Producto();
                    producto.pIdProducto = Convert.ToInt32(dgvProductosAlDetalle.CurrentRow.Cells["ID"].Value.ToString());
                    producto.pArticulo = Convert.ToInt32(dgvProductosAlDetalle.CurrentRow.Cells["Articulo"].Value.ToString());
                    producto.pDescripcion = dgvProductosAlDetalle.CurrentRow.Cells["Descripcion"].Value.ToString(); ;

                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    double precio = Convert.ToDouble(txtPrecioCompra.Text);

                    DetalleCompra detalle = new DetalleCompra();
                    detalle.pCantidadUnit = cantidad;
                    detalle.pPrecioUnit = Math.Round(precio, 2);

                    lista.Add(detalle);

                    dgvDetalleCompra.Rows.Add(idProducto, producto.pArticulo.ToString(), producto.pDescripcion, detalle.pCantidadUnit.ToString(), (decimal)detalle.pPrecioUnit);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila para añadir.");
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un precio y una cantidad [Minimo: 1]");
            }
            /*
             * Dar funcionalidad al boton confirmar y cancelar
             * Hacer el INSERT de compras y Detalle */
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            bool existeCompra = gestor.existeCompra(num_comprobante, fechaCompra, idProveedor);

            if (!existeCompra)
            {
                try
                {
                    traerDatosCompra(num_comprobante, tieneFactura, fechaCompra, idProveedor);
                    Compra compra = new Compra(0, num_comprobante, fechaCompra, idProveedor);
                    gestor.cargarCompra(compra);

                    compra.pIdCompra = gestor.nuevoID("idCompra", "Compras");

                    foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                    {
                        int idProducto = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                        int cant = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                        double pre = Convert.ToDouble(row.Cells["Precio"].Value.ToString());

                        Producto producto = new Producto(idProducto);
                        DetalleCompra detalle = new DetalleCompra(0, producto, cant, pre, compra);
                        gestor.cargarDetalleCompra(detalle);

                        int cantidadStock = gestor.verStock(idProducto, 3);

                        if (gestor.primeraCarga(idProducto))
                        {
                            Stock stockAlmacen = new Stock();
                            stockAlmacen.pCantidad = cant;
                            stockAlmacen.pIdProducto = idProducto;
                            stockAlmacen.pIdSucursal = 3;
                            gestor.cargarStocks(stockAlmacen);
                        }
                        else
                        {
                            int nuevaCantidad = (cantidadStock + cant);

                            Stock stockAlmacen = new Stock();
                            stockAlmacen.pCantidad = nuevaCantidad;
                            stockAlmacen.pIdProducto = idProducto;
                            stockAlmacen.pIdSucursal = 3;
                            gestor.modificarStock(stockAlmacen);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                MessageBox.Show("Ya cargaste esta compra");
            }
            this.Close();
        }

        private void traerDatosCompra(int nroComprobante, int factura, DateTime fecha, int proveedor)
        {
            fechaCompra = fecha;
            tieneFactura = factura;
            num_comprobante = nroComprobante;
            idProveedor = proveedor;
        }

        private void habilitarControles(bool x)
        {
            lblError.Visible = !x;
            btnCargar.Visible = !x;
            txtCantidad.Enabled = !x;
            txtPrecioCompra.Enabled = !x;
            btnAñadir.Enabled = !x;
        }

        private void limpiar()
        {
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            dgvProductosAlDetalle.DataSource = null;
            cbMarca.SelectedIndex = -1;
            cbRubro.SelectedIndex = -1;
            cbTalle.SelectedIndex = -1;
            cbColor.SelectedIndex = -1;
            habilitarControles(true);
        }

        private void cargarCombos()
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbMarca, "Marcas");
        }

        private void ocultarInfoData()
        {
            dgvProductosAlDetalle.Columns["ID"].Visible = false;
            dgvProductosAlDetalle.Columns["Descripcion"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProductosAlDetalle.Rows.Clear();
            dgvDetalleCompra.Rows.Clear();
            this.Close();
        }
    }
}