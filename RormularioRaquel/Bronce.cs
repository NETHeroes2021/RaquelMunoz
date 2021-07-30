namespace RormularioRaquel
{
    public class Bronce : IMantenible
    {
        public string Nombre;

        public int Peso;

        public Bronce( int peso)
        {
           
            Peso = peso;
        }

      

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}