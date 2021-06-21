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
        private Producto productoDevuelto;
        private Devolucion devolucion;

        public DetalleDevolucion(int idDetalleDevolucion, Producto productoDevuelto, Devolucion devolucion)
        {
            this.idDetalleDevolucion = idDetalleDevolucion;
            this.productoDevuelto = productoDevuelto;
            this.devolucion = devolucion;
        }

        public DetalleDevolucion()
        {
            this.idDetalleDevolucion = 0;
            this.productoDevuelto = new Producto();
            this.devolucion = new Devolucion();
        }

        public int pIdDetalleDevolucion { get => idDetalleDevolucion; set => idDetalleDevolucion = value; }
        public Producto pProductoDevuelto { get => productoDevuelto; set => productoDevuelto = value; }
        public Devolucion pDevolucion { get => devolucion; set => devolucion = value; }
    }
}
