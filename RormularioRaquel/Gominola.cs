namespace RormularioRaquel
{
    public class Gominola : ICaducable, IInflamable
    {
        public string Nombre;

        public int Peso;

        public Gominola( int peso)
        {
           
            Peso = peso;
        }

      

        public int DevuelvePeso()
        {
            return Peso;
        }
    }
}



