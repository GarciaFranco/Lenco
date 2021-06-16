using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo.Modelo
{
    public class DetalleDevolucion
    {
        private int idDetalleDevolucion;
        private DetalleDevolucion detalle;
        private Producto productoEntrante;
        private Producto productoSaliente;
        private bool cambioProducto;
        private double notaSaliente;

        public DetalleDevolucion(int idDetalleDevolucion, DetalleDevolucion detalle, Producto productoEntrante, Producto productoSaliente, bool cambioProducto, double notaSaliente)
        {
            this.idDetalleDevolucion = idDetalleDevolucion;
            this.detalle = detalle;
            this.productoEntrante = productoEntrante;
            this.productoSaliente = productoSaliente;
            this.cambioProducto = cambioProducto;
            this.notaSaliente = notaSaliente;
        }

        public int pIdDetalleDevolucion { get => idDetalleDevolucion; set => idDetalleDevolucion = value; }
        public Producto pProductoEntrante { get => productoEntrante; set => productoEntrante = value; }
        public Producto pProductoSaliente { get => productoSaliente; set => productoSaliente = value; }
        public bool pCambioProducto { get => cambioProducto; set => cambioProducto = value; }
        public double pNotaSaliente { get => notaSaliente; set => notaSaliente = value; }
        internal DetalleDevolucion pDetalle { get => detalle; set => detalle = value; }
    }
}
