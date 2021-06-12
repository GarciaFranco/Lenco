namespace LenCo.Modelo
{
    public class Rubro
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

        public Rubro()
        {
            this.idRubro = 0;
            this.nombre = "";
        }

        public int pIdRubro { get => idRubro; set => idRubro = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}