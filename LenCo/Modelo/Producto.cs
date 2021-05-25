using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Producto
    {
        private int idProducto;
        private string codigoProv;
        private Marca marca;
        private Rubro rubro;
        private int articulo;
        private Talle talle;
        private Color color;
        private Presentacion present;
        private string descripcion;
        private double precioVenta;
        private bool activo;

        public Producto(int idProducto, string codigoProv, Marca marca, Rubro rubro, int articulo, Talle talle, 
                       Color color, Presentacion present, string descripcion, double precioVenta, bool activo)
        {
            this.idProducto = idProducto;
            this.codigoProv = codigoProv;
            this.marca = marca;
            this.rubro = rubro;
            this.articulo = articulo;
            this.talle = talle;
            this.color = color;
            this.present = present;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.activo = activo;
        }

        public Producto(int idProducto, string codigoProv, Marca marca, int articulo, Presentacion present, string descripcion, double precioVenta)
        {
            this.idProducto = idProducto;
            this.codigoProv = codigoProv;
            this.marca = marca;
            this.articulo = articulo;
            this.present = present;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
        }

        public int pIdProducto { get => idProducto; set => idProducto = value; }
        public string pCodigoProv { get => codigoProv; set => codigoProv = value; }
        public int pArticulo { get => articulo; set => articulo = value; }
        public string pDescripcion { get => descripcion; set => descripcion = value; }
        public double pPrecioVenta { get => precioVenta; set => precioVenta = value; }
        public bool pActivo { get => activo; set => activo = value; }
        internal Marca pMarca { get => marca; set => marca = value; }
        internal Rubro pRubro { get => rubro; set => rubro = value; }
        internal Talle pTalle { get => talle; set => talle = value; }
        internal Color pColor { get => color; set => color = value; }
        internal Presentacion pPresent { get => present; set => present = value; }
    }
}
