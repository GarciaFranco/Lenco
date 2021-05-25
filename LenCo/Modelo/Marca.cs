using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Marca
    {
        private int idMarca;
        private string nombre;


        public Marca(int idMarca, string nombre)
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
        }
        public Marca(int idMarca)
        {
            this.idMarca = idMarca;
        }

        public int pIdMarca { get => idMarca; set => idMarca = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}
