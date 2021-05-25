using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Talle
    {
        private int idTalle;
        private string nombre;


        public Talle(int idTalle, string nombre)
        {
            this.idTalle = idTalle;
            this.pNombre = nombre;
        }
        public Talle(int idTalle)
        {
            this.idTalle = idTalle;
        }
        public int pIdTalle { get => idTalle; set => idTalle = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}
