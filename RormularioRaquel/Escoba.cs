namespace RormularioRaquel
{
    public class Escoba : IMantenible, IInflamable
    {
        public string Nombre;

        public int Peso;

        public Escoba( int peso)
        {
           
            Peso = peso;
        }

      
        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}