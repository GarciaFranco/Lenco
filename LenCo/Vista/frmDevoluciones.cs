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

namespace LenCo.Vista
{
    public partial class frmDevoluciones : Form
    {
        private List<string> listaEntrante;
        private List<string> listaSaliente;
        private double montoEntrante;
        private double montoSaliente;
        private double montoRestante;

        public frmDevoluciones()
        {
            InitializeComponent();
            montoEntrante = 0;
            listaEntrante = new List<string>();
            listaSaliente = new List<string>();
            txtProductoEntra.Enabled = false;
            txtProductoSale.Enabled = false;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idSucursal = sucursalVenta();
            int cantidadAumentada = 1;
            int cantidadDescontada = 1;
            string descrip = txtDescripDevolucion.Text;
            if(string.IsNullOrEmpty(descrip))
            {
                descrip = "";
            }
            string descripcion = descrip;
            try
            {
                if (cargaCompleta())
                {
                    Gestor gestor = new Gestor();
                    Devolucion nueva = new Devolucion();
                    nueva.pFecha_devolucion = DateTime.Now;
                    nueva.pDescripcion = descripcion;
                    gestor.agregarDevolucion(nueva);

                    int idDevolucion = nueva.pIdDevolucion = gestor.nuevoID("idDevolucion", "Devoluciones");

                    if (listaEntrante.Count > 0)
                    {
                        foreach (var codigo in listaEntrante)
                        {
                            Producto producto = gestor.buscarProducto(codigo);
                            int idProducto = producto.pIdProducto;

                            // INSERT EN DetallesDevolucion
                            DetalleDevolucion detalle = new DetalleDevolucion();
                            detalle.pDevolucion.pIdDevolucion = idDevolucion;
                            detalle.pProductoDevuelto.pIdProducto = idProducto;
                            gestor.agregarDetalleDevolucion(detalle);

                            // IMPACTO EN STOCK
                            int cantidadEnStock = gestor.verStock(codigo, idSucursal);
                            int nuevaCantidad = cantidadEnStock + cantidadAumentada;
                            gestor.modificarStock(codigo, nuevaCantidad, idSucursal);
                        }
                    }
                    if (listaSaliente.Count > 0)
                    {
                        foreach (var codigo in listaSaliente)
                        {
                                Producto producto = gestor.buscarProducto(codigo);
                                int idProducto = producto.pIdProducto;
                                int stockMinimo = 1;

                                if (gestor.verStock(codigo, idSucursal) >= stockMinimo)
                                {
                                // INSERT EN DetallesSaliente
                                DetalleSalida det = new DetalleSalida();
                                det.pIdTipoSalida = 1;
                                det.pIdProducto = idProducto;
                                det.pDevolucion.pIdDevolucion = idDevolucion;
                                det.pDevolucion.pIdDevolucion = idDevolucion;
                                det.pMontoNota = 0;
                                gestor.agregarDetalleSalida(det);

                                // IMPACTO EN STOCK
                                int cantidadEnStock = gestor.verStock(codigo, idSucursal);
                                int nuevaCantidad = cantidadEnStock - cantidadDescontada;
                                gestor.modificarStock(codigo, nuevaCantidad, idSucursal);
                                }
                            else
                            {
                                MessageBox.Show("El Producto con CODIGO : " + codigo + " no posee stock");
                            }
                        }
                        if (montoRestante > 0)
                        {
                            MessageBox.Show("Entregar NOTA DE CREDITO [ID: " + idDevolucion + "] por: $ " + montoRestante);
                        }
                        else
                        {
                            MessageBox.Show("Monto a abonar por el cliente: $" + montoRestante * (-1));
                        }
                    }
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la devolucion: " + ex);
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
            txtProductoSale.Enabled = true;
        }
        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            lstEntrante.Items.Clear();
            if (aprobarEntrada())
            {
                string codigoProducto = txtProductoEntra.Text;
                string codigoVenta = txtCodigo.Text;
                double montoProducto = gestor.tomarPrecioVendido(codigoProducto, codigoVenta);
                montoEntrante = montoEntrante + montoProducto;
                listaEntrante.Add(codigoProducto);
                txtProductoEntra.Clear();
            }

            foreach (var item in listaEntrante)
            {
                lstEntrante.Items.Add(item);
            }
            lblEntrante.Text = "$ " + Convert.ToString(montoEntrante);

            montoRestante = montoEntrante - montoSaliente;
            lblRestante.Text = "$ " + Convert.ToString(montoRestante);
        }
        public bool aprobarEntrada()
        {
            bool aprobado = false;

            Gestor gestor = new Gestor();
            string codigoProducto = txtProductoEntra.Text;
            string codigoVenta = txtCodigo.Text;
            if (!string.IsNullOrEmpty(codigoProducto))
            {
                aprobado = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un codigo de producto");
                txtProductoEntra.Focus();
            }
            if (gestor.existeEnVenta(codigoProducto, codigoVenta))
            {
                aprobado = true;
            }
            else
            {
                aprobado = false;
                MessageBox.Show("No existe el producto para la venta ingresada. Verifique el codigo.");
                txtProductoEntra.Focus();
            }
            return aprobado;
        }
        public bool aprobarSalida()
        {
            bool aprobada = false;

            Gestor gestor = new Gestor();
            string codigoProducto = txtProductoSale.Text;

            if (!string.IsNullOrEmpty(txtProductoSale.Text))
            {
                aprobada = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un codigo de producto");
                txtProductoSale.Focus();
            }
            if (gestor.existeProducto(codigoProducto))
            {
                aprobada = true;
            }
            else
            {
                aprobada = false;
                MessageBox.Show("No existe el producto ingresado.");
                txtProductoSale.Focus();
            }
            return aprobada;
        }
        private bool cargaCompleta()
        {
            Gestor gestor = new Gestor();
            if (lstEntrante.Items.Count == 0)
            {
                MessageBox.Show("Debes ingresar al menos un producto entrante.");
                return false;
            }
            return true;
        }
        private void btnAñadirSalida_Click(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            lstSaliente.Items.Clear();
            if (aprobarSalida())
            {
                string codigoProducto = txtProductoSale.Text;
                double montoProducto = gestor.tomarPrecioProducto(codigoProducto);
                montoSaliente = montoSaliente + montoProducto;
                listaSaliente.Add(codigoProducto);
                txtProductoSale.Clear();
            }

            foreach (var item in listaSaliente)
            {
                lstSaliente.Items.Add(item);
            }
            lblSaliente.Text = "$ " + Convert.ToString(montoSaliente);

            montoRestante = montoEntrante - montoSaliente;
            lblRestante.Text = "$ " + Convert.ToString(montoRestante);
        }
        private void limpiarCampos()
        {
            txtDescripDevolucion.Clear();
            txtCodigo.Clear();
            txtProductoEntra.Clear();
            txtProductoSale.Clear();
            lstEntrante.Items.Clear();
            lstSaliente.Items.Clear();
        }
    }
}