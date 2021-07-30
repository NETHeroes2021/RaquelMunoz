namespace RormularioRaquel
{
    public class Acero : IMantenible
    {
        public string Nombre;

        public int Peso;

        public Acero( int peso)
        {
           
            Peso = peso;
        }

       

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}