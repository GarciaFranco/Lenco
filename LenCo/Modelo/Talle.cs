namespace LenCo.Modelo
{
    public class Talle
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

        public Talle()
        {
            this.idTalle = 0;
            this.pNombre = "";
        }

        public int pIdTalle { get => idTalle; set => idTalle = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}