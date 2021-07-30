namespace RormularioRaquel
{
    public class Chip : IMantenible
    {
        public string Nombre;

        public int Peso;

        public Chip( int peso)
        {

            Peso = peso;
        }

     

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}