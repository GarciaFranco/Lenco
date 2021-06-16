using LenCo.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmVenta : Form
    {
        private double montoTotalVenta;

        public frmVenta()
        {
            InitializeComponent();
            mostrarFecha();
            cargarCombo();
            deshabilitarControles();
            actualizarVentas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();

            double cantidadIngresada = Convert.ToDouble(txtCantidad.Text);
            double cantidadMaxima = Convert.ToDouble(lblMaxCant.Text);

            if (cantidadIngresada <= cantidadMaxima)
            {
                try
                {
                    int cantidadDescontada = Convert.ToInt32(txtCantidad.Text);
                    List<Producto> listaProductos = new List<Producto>();
                    string codigo = txtCodigo.Text;

                    Producto productoVenta = gestor.buscarProducto(codigo);
                    listaProductos.Add(productoVenta);

                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        dgvDetalleVenta.Rows.Add(productoVenta.pIdProducto, productoVenta.pArticulo.ToString(), productoVenta.pDescripcion,
                                                 productoVenta.pMarca.pNombre, productoVenta.pRubro.pNombre,
                                                 productoVenta.pTalle.pNombre, productoVenta.pColor.pNombre,
                                                 productoVenta.pPrecioVenta.ToString(), cantidadDescontada);
                    }

                    if (lblMaxCant.Text == "0")
                    {
                        MessageBox.Show("No puedes agregar este producto.");
                        limpiarCampos();
                        txtCodigo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la carga del producto: " + ex.Message);
                }
                finally
                {
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar una cantidad inferior a " + cantidadMaxima);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now; // .Date.ToString("yyyy-MM-dd");
            Gestor gestor = new Gestor();

            try
            {
                Venta venta = new Venta();
                venta.pFechaVenta = Convert.ToDateTime(fecha);
                venta.pIdSucursal = sucursalVenta();
                double montoDescuento = 0;
                if (string.IsNullOrEmpty(txtDescuento.Text))
                {
                    montoDescuento = 0;
                }
                else
                {
                    montoDescuento = Convert.ToDouble(txtDescuento.Text);
                }
                venta.pMontoDescuento = montoDescuento;
                venta.pIdformaPago = Convert.ToInt32(cbFormaPago.SelectedValue);
                gestor.agregarVenta(venta);

                int idVenta = venta.pIdVenta = gestor.nuevoID("idVenta", "Ventas");

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                    DetalleVenta detalle = new DetalleVenta();
                    detalle.pCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                    detalle.pProducto.pIdProducto = idProducto;
                    detalle.pVenta.pIdVenta = idVenta;
                    gestor.agregarDetalleVenta(detalle);

                    int cantidadEnStock = gestor.verStock(idProducto, sucursalVenta());
                    int cantidadEnVenta = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                    int nuevaCantidad = cantidadEnStock - cantidadEnVenta;

                    Stock stock = new Stock();
                    stock.pIdProducto = idProducto;
                    stock.pCantidad = nuevaCantidad;
                    stock.pIdSucursal = sucursalVenta();
                    gestor.modificarStock(stock);
                }
                double interes = tomarInteres();
                double valor = (montoTotalVenta - montoDescuento) * interes;
                MessageBox.Show("Venta cargada con exito! Monto de la venta: $" + valor);
                actualizarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar la venta: " + ex.Message);
            }
            finally
            {
                limpiarCampos();
                dgvDetalleVenta.Rows.Clear();
                deshabilitarControles();
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            int idSucursal = sucursalVenta();

            Gestor gestor = new Gestor();
            int cantidad = gestor.verStock(codigo, idSucursal);

            if (gestor.existeProducto(codigo))
            {
                if (cantidad > 0)
                {
                    txtCantidad.Enabled = true;
                    lblMaxCant.Text = Convert.ToString(cantidad);
                }
                else
                {
                    MessageBox.Show("No existe stock para este producto.");
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe un producto con este codigo.");
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count > 0)
            {
                dgvDetalleVenta.Rows.Clear();
            }
            gbRegistroVenta.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.SelectedRows.Count == 1)
            {
                dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.CurrentRow);
            }
        }

        private void dgvDetalleVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count > 0)
            {
                gbRegistroVenta.Enabled = true;
            }
            else
            {
                gbRegistroVenta.Enabled = false;
            }
        }

        private void dgvDetalleVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            montoTotalVenta = 0;
            double montoParcial;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                double precio = Convert.ToInt32(row.Cells["precioVenta"].Value.ToString());
                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                montoParcial = precio * cantidad;
                montoTotalVenta = montoTotalVenta + montoParcial;
            }
            lblMontoVta.Text = Convert.ToString(montoTotalVenta);
        }

        private void dgvDetalleVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            montoTotalVenta = 0;
            double montoParcial;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                double precio = Convert.ToInt32(row.Cells["precioVenta"].Value.ToString());
                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                montoParcial = precio * cantidad;
                montoTotalVenta = montoTotalVenta + montoParcial;
            }
            lblMontoVta.Text = Convert.ToString(montoTotalVenta);
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuento.Checked)
            {
                txtDescuento.Enabled = true;
            }
            else
            {
                txtDescuento.Enabled = false;
                txtDescuento.Clear();
            }
        }

        private int sucursalVenta()
        {
            int id = 3;
            if (Usuario.pIdUsuario == 3)
            {
                id = 1;
            }
            else if (Usuario.pIdUsuario == 4)
            {
                id = 2;
            }
            return id;
        }
        private void limpiarCampos()
        {
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtDescuento.Clear();
            lblMaxCant.Text = "0";
        }
        private void mostrarFecha()
        {
            var fecha_hora = DateTime.Now;
            var fecha = fecha_hora.Date.ToString("dd-MM-yyyy");
            lblDia.Text = fecha;
        }
        private void cargarCombo()
        {
            Gestor gestor = new Gestor();
            gestor.cargarComboFormasPago(cbFormaPago);
        }
        private void deshabilitarControles()
        {
            gbRegistroVenta.Enabled = false;
            chkDescuento.Checked = false;
            txtDescuento.Enabled = false;
            cbFormaPago.SelectedIndex = -1;
        }
        private double tomarInteres()
        {
            double interes = 1;
            if(cbFormaPago.SelectedIndex == 2)
            {
                interes = 1.10;
            }
            else if(cbFormaPago.SelectedIndex == 3)
            {
                interes = 1.20;
            }
            return interes;
        }
        private void actualizarVentas()
        {
            Gestor gestor = new Gestor();
            DataTable dt = gestor.listadoVentaDiaria();
            dgvVentasDiarias.DataSource = dt;
            dgvVentasDiarias.Columns["ID Venta"].Visible = false;
            dgvVentasDiarias.Columns["Totales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentasDiarias.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentasDiarias.Columns["% Interes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}