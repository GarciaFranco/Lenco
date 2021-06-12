using System;

namespace LenCo.Modelo
{
    public class Venta
    {
        private int idVenta;
        private DateTime fechaVenta;
        private int idSucursal;
        private double montoDescuento;
        private int idFormaPago;

        public int pIdVenta { get => idVenta; set => idVenta = value; }
        public DateTime pFechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public int pIdSucursal { get => idSucursal; set => idSucursal = value; }
        public double pMontoDescuento { get => montoDescuento; set => montoDescuento = value; }
        public int pIdformaPago { get => idFormaPago; set => idFormaPago = value; }

        public Venta(int idVenta, DateTime fechaVenta, int idSucursal, double montoDescuento, int formaPago)
        {
            this.idVenta = idVenta;
            this.fechaVenta = fechaVenta;
            this.idSucursal = idSucursal;
            this.montoDescuento = montoDescuento;
            this.idFormaPago = formaPago;
        }

        public Venta()
        {
            this.idVenta = 0;
            this.fechaVenta = DateTime.Now;
            this.idSucursal = 0;
            this.montoDescuento = 0;
            this.idFormaPago = 0;
        }
    }
}