namespace LenCo.Modelo
{
    public class DetalleCompra
    {
        private int idDetalle;
        private Producto producto;
        private int cantidadUnit;
        private double precioUnit;
        private Compra compra;

        public DetalleCompra(int idDetalle, Producto producto, int cantidadUnit, double precioUnit, Compra compra)
        {
            this.idDetalle = idDetalle;
            this.producto = producto;
            this.cantidadUnit = cantidadUnit;
            this.precioUnit = precioUnit;
            this.compra = compra;
        }

        public DetalleCompra()
        {
            this.idDetalle = 0;
            this.producto = null;
            this.cantidadUnit = 0;
            this.precioUnit = 0;
            this.compra = null;
        }

        public DetalleCompra(int idDetalle, Producto producto, int cantidadUnit, double precioUnit)
        {
            this.idDetalle = idDetalle;
            this.producto = producto;
            this.cantidadUnit = cantidadUnit;
            this.precioUnit = precioUnit;
        }

        public int pIdDetalle { get => idDetalle; set => idDetalle = value; }
        public Producto pProducto { get => producto; set => producto = value; }
        public int pCantidadUnit { get => cantidadUnit; set => cantidadUnit = value; }
        public double pPrecioUnit { get => precioUnit; set => precioUnit = value; }
        public Compra pCompra { get => compra; set => compra = value; }

        public override string ToString()
        {
            return
                   "Producto: " + pProducto.pArticulo + "\n" +
                   "Cantidad: " + pCantidadUnit + "\n" +
                   "Precio: " + pPrecioUnit;
        }
    }
}