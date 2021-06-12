namespace LenCo.Modelo
{
    public class Stock
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

        public Stock()
        {
            this.idProducto = 0;
            this.idStock = 0;
            this.cantidad = 0;
            this.idSucursal = 0;
        }

        public int pIdStock { get => idStock; set => idStock = value; }
        public int pIdSucursal { get => idSucursal; set => idSucursal = value; }
        public int pCantidad { get => cantidad; set => cantidad = value; }
        public int pIdProducto { get => idProducto; set => idProducto = value; }
    }
}