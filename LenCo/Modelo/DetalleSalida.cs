using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo.Modelo
{
    public class DetalleSalida
    {
        private int idDetalleSalida;
        private int idTipoSalida;
        private double montoNota;
        private int idProducto;
        private Devolucion devolucion;

        public DetalleSalida(int idDetalleSalida, int idTipoSalida, double monto, int idProducto, Devolucion devolucion)
        {
            this.idDetalleSalida = idDetalleSalida;
            this.idTipoSalida = idTipoSalida;
            this.montoNota = monto;
            this.idProducto = idProducto;
            this.devolucion = devolucion;
        }
        public DetalleSalida()
        {
            this.idDetalleSalida = 0;
            this.idTipoSalida = 0;
            this.montoNota = 0;
            this.idProducto = 0;
            this.devolucion = new Devolucion();
        }

        public int pIdDetalleSalida { get => idDetalleSalida; set => idDetalleSalida = value; }
        public int pIdTipoSalida { get => idTipoSalida; set => idTipoSalida = value; }
        public double pMontoNota { get => montoNota; set => montoNota = value; }
        public int pIdProducto { get => idProducto; set => idProducto = value; }
        public Devolucion pDevolucion { get => devolucion; set => devolucion = value; }
    }
}
