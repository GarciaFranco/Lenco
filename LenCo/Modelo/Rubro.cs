using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Rubro
    {
        private int idRubro;
        private string nombre;


        public Rubro(int idRubro, string nombre)
        {
            this.idRubro = idRubro;
            this.nombre = nombre;
        }
        public Rubro(int idRubro)
        {
            this.idRubro = idRubro;
        }
        public int pIdRubro { get => idRubro; set => idRubro = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}
