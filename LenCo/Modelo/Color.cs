using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    class Color
    {
        private int idColor;
        private string nombre;


        public Color(int idColor, string nombre)
        {
            this.idColor = idColor;
            this.pNombre = nombre;
        }

        public Color(int idColor)
        {
            this.idColor = idColor;
        }

        public int pIdColor { get => idColor; set => idColor = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}
