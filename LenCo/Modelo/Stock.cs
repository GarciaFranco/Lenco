using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo.Modelo
{
    class Stock
    {
        private int idStock;
        private int idSucursal;
        private int idProducto;
        private int cantidad;

        public Stock(int idSucursal, int idProducto, int cantidad)
        {
            this.idSucursal = idSucursal;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }

        public int pIdStock { get => idStock; set => idStock = value; }
        public int pIdSucursal { get => idSucursal; set => idSucursal = value; }
        public int pCantidad { get => cantidad; set => cantidad = value; }
        public int pIdProducto { get => idProducto; set => idProducto = value; }
    }
}
