using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEsercizio
{
    public class Classe
    {
        public static int[] Ordinato(int[] array)
        {
            int[] arrayOrdinato = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int c = 0;
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[i] > array[y])
                    {
                        c++;
                    }
                }
                arrayOrdinato[c] =array[i];
            }
            for (int i = 0; i < arrayOrdinato.Length; i++)
            {
                if (arrayOrdinato[i] == 0)
                {
                    arrayOrdinato[i] = arrayOrdinato[i - 1];
                }
            }
            return arrayOrdinato;
        }
    }
}
