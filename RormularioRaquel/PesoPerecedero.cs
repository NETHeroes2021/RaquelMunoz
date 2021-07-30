using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RormularioRaquel
{
    public class PesoPerecedero
    {

        /// <summary>
        /// metodo para calcular el peso de los materiales perecedero no inflamables.
        /// </summary>
        /// <param name="Materiales"> lista donde almacena los materiales recividos</param>
        /// <returns> devuelve el peso segun añades materiales</returns>
        public static string calcularPesoPerecedero(List<IMaterializable> Materiales)
        {
            int totalalmacen = Materiales.Count;
            int Peso = 0;

            foreach (var item in Materiales)
            {
                if ((item is ICaducable) && (item is IMantenible))
                {
                    Peso += (item as ICaducable).DevuelvePeso();
                }

            }
            return Peso.ToString();

        }
    }

}