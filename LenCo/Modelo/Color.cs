namespace LenCo.Modelo
{
    public class Color
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

        public Color()
        {
            this.idColor = 0;
            this.pNombre = "";
        }

        public int pIdColor { get => idColor; set => idColor = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}