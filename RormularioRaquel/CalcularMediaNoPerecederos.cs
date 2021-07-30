using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RormularioRaquel
{
   
    public class CalcularMediaNoPerecederos
    {

        /// <summary>
        /// metodo para calcular la cantidad media de los no perecederos
        /// </summary>
        /// <param name="Materiales"> lista donde se almacenan los materiales</param>
        /// <returns>devuelve la media de los materiales no perecederos respecto al total</returns>
        public static decimal CalcularMediaNP(List<IMaterializable> Materiales)
        {
            int totalalmacen = Materiales.Count;
            decimal MaterialesNP = 0.00m;

            foreach (var item in Materiales)
            {
                if (!(item is ICaducable))
                {

                    MaterialesNP++;
                }
            }

            return Decimal.Round((MaterialesNP / totalalmacen) * 100, 2);

        }
    }
}