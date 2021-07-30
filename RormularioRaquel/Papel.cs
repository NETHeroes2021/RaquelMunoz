namespace RormularioRaquel
{
    public class Papel : IMantenible, IInflamable
    {

        public string Nombre;

        public int Peso;

        public Papel( int peso)
        {
           
            Peso = peso;
        }

      

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}