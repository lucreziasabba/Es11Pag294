using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEsercizio;

namespace ConsoleEsercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANTI = 10;
            Random r = new Random();
            int[] array = new int[TANTI];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= r.Next(1,10);
            }
            Console.WriteLine("Random: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            array = Classe.Ordinato(array);
            Console.WriteLine("\nOrdinato:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
