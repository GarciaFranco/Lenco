namespace LenCo.Modelo
{
    public class DetalleVenta
    {
        private int idDetalle;
        private Producto producto;
        private double precioVenta;
        private int cantidad;
        private Venta venta;

        public int pIdDetalle { get => idDetalle; set => idDetalle = value; }
        public Producto pProducto { get => producto; set => producto = value; }
        public double PprecioVenta { get => precioVenta; set => precioVenta = value; }
        public int pCantidad { get => cantidad; set => cantidad = value; }
        public Venta pVenta { get => venta; set => venta = value; }

        public DetalleVenta(int idDetalle, Producto producto, double precioVenta, int cantidad, Venta venta)
        {
            this.idDetalle = idDetalle;
            this.producto = producto;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.venta = venta;
        }

        public DetalleVenta()
        {
            this.idDetalle = 0;
            this.producto = new Producto();
            this.precioVenta = 0;
            this.cantidad = 0;
            this.venta = new Venta();
        }
    }
}