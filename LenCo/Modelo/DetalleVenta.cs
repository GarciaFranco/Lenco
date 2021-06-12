namespace LenCo.Modelo
{
    public class DetalleVenta
    {
        private int idDetalle;
        private Producto producto;
        private int cantidad;
        private Venta venta;

        public int pIdDetalle { get => idDetalle; set => idDetalle = value; }
        public Producto pProducto { get => producto; set => producto = value; }
        public int pCantidad { get => cantidad; set => cantidad = value; }
        public Venta pVenta { get => venta; set => venta = value; }

        public DetalleVenta(int idDetalle, Producto producto, int cantidad, Venta venta)
        {
            this.idDetalle = idDetalle;
            this.producto = producto;
            this.cantidad = cantidad;
            this.venta = venta;
        }

        public DetalleVenta()
        {
            this.idDetalle = 0;
            this.producto = new Producto();
            this.cantidad = 0;
            this.venta = new Venta();
        }
    }
}