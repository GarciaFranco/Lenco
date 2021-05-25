using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Presentacion
    {
        private int idPresentacion;
        private string nombre;


        public Presentacion(int idPresentacion, string nombre)
        {
            this.idPresentacion = idPresentacion;
            this.nombre = nombre;
        }
        public Presentacion(int idPresentacion)
        {
            this.idPresentacion = idPresentacion;
        }
        public int pIdPresentacion { get => idPresentacion; set => idPresentacion = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}
