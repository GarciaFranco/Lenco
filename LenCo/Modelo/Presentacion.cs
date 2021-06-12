namespace LenCo.Modelo
{
    public class Presentacion
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

        public Presentacion()
        {
            this.idPresentacion = 0;
            this.nombre = "";
        }

        public int pIdPresentacion { get => idPresentacion; set => idPresentacion = value; }
        public string pNombre { get => nombre; set => nombre = value; }
    }
}