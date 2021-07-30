namespace RormularioRaquel
{
    public class Higo : ICaducable, IMantenible
    {
        public string Nombre;

        public int Peso;



        public Higo( int peso)
        {
           
            Peso = peso;
        }



       

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}