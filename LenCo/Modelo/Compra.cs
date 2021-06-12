using System;

namespace LenCo.Modelo
{
    public class Compra
    {
        private int idCompra;
        private int nroComprobante;
        private DateTime fecha_compra;
        private int idProveedor;

        public Compra(int idCompra, int nroComprobante, DateTime fecha_compra, int idProveedor)
        {
            this.idCompra = idCompra;
            this.nroComprobante = nroComprobante;
            this.fecha_compra = fecha_compra;
            this.idProveedor = idProveedor;
        }

        public Compra(int idCompra)
        {
            this.idCompra = idCompra;
        }

        public int pIdCompra { get => idCompra; set => idCompra = value; }
        public int pNroComprobante { get => nroComprobante; set => nroComprobante = value; }
        public DateTime pFecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public int pIdProveedor { get => idProveedor; set => idProveedor = value; }
    }
}