using LenCo.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmVenta : Form
    {
        private double montoTotalVenta;

        public frmVenta()
        {
            InitializeComponent();
            cargarCombo();
            mostrarFecha();
            gbRegistroVenta.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();

            int cantidadDescontada = Convert.ToInt32(txtCantidad.Text);
            List<Producto> listaProductos = new List<Producto>();
            string codigo = txtCodigo.Text;

            Producto productoVenta = gestor.buscarProducto(codigo);
            listaProductos.Add(productoVenta);

            for (int i = 0; i < listaProductos.Count; i++)
            {
                dgvDetalleVenta.Rows.Add(productoVenta.pArticulo.ToString(), productoVenta.pDescripcion,
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
            limpiarCampos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now.Date.ToString("dd-MM-yyyy");

            Gestor gestor = new Gestor();
            Venta venta = new Venta();
            venta.pFechaVenta = Convert.ToDateTime(fecha);
            venta.pIdSucursal = sucursalVenta();
            venta.pMontoDescuento = Convert.ToDouble(txtDescuento.Text);
            //venta.pIdformaPago = cbFormaPago.SelectedItem;
            gestor.agregarVenta(venta);

            int idVenta = venta.pIdVenta;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                DetalleVenta detalle = new DetalleVenta();
                detalle.pCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                detalle.pProducto.pIdProducto = idProducto;
                detalle.pVenta.pIdVenta = idVenta;
                gestor.agregarDetalleVenta(detalle);
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.SelectedRows.Count == 1)
            {
                dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.CurrentRow);
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

        public void mostrarFecha()
        {
            var fecha_hora = DateTime.Now;
            var fecha = fecha_hora.Date.ToString("dd-MM-yyyy");
            lblDia.Text = fecha;
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

        private void cargarCombo()
        {
            Gestor gestor = new Gestor();
            gestor.cargarCombo(cbFormaPago, "FormasPago");
        }
    }
}