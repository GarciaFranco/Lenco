namespace LenCo.Modelo
{
    public class Marca
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

        public Marca()
        {
            this.idMarca = 0;
            this.nombre = "";
        }

        public int pIdMarca { get => idMarca; set => idMarca = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}