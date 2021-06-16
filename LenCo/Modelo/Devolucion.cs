using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace LenCo.Modelo
{
    public class Devolucion
    {
        private int idDevolucion;
        private DateTime fecha_devolucion;
        private string descripcion;

        public Devolucion(int idDevolucion, DateTime fecha_devolucion, string descripcion)
        {
            this.idDevolucion = idDevolucion;
            this.fecha_devolucion = fecha_devolucion;
            this.descripcion = descripcion;
        }

        public Devolucion()
        {
            this.idDevolucion = 0;
            this.fecha_devolucion = DateTime.Now;
            this.descripcion = "";
        }

        public int pIdDevolucion { get => idDevolucion; set => idDevolucion = value; }
        public DateTime pFecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public string pDescripcion { get => descripcion; set => descripcion = value; }
    }
}
