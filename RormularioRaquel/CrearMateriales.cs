using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RormularioRaquel
{
     public static class CrearMateriales
    {
       
        public static IMaterializable aniadirMateriales(string boton)
        {
            

            switch (boton)
            {
                case "Acero": return new Acero( 100); 
                case "Bronce": return new Bronce( 300); 
                case "Chip": return new Chip( 2); 
                case "Escoba": return new Escoba( 20); 
                case "Gominola": return new Gominola( 1);
                case "Higo": return new Higo( 75);
                case "Papel": return new Papel( 3);
                default: return  null;
            }


        }

    }

}