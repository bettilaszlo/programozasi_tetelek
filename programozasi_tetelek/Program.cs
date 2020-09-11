using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozasi_tetelek
{
    class Program
    {
        static int[] tomb = new int[10]{12, 7, 2, 4, 45, 99, 1, 8, 95, 50};
        private static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
            
        }
        private static void Osszegzes()
        {
            Console.WriteLine("\n Összegzés tétele");
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine(" {0}", osszeg);
        }
        private static void Megszamolas()
        {
            Console.WriteLine("Megszámlálás tétele");
            int x = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    x++;
                }
                
            }
            Console.WriteLine("{0} db 3-mal osztható szám van", x);
        }
        private static void Eldontes()
        {
            Console.WriteLine("Eldöntés tétele");

            int i = 0;

            while (i < tomb.Length && tomb[i] != 69)
            {
                i++;
            }
                if (i < tomb.Length)
                {
                    Console.WriteLine("Van a tömbben 69!");
                }
                else
                {
                    Console.WriteLine("Nincs a tömbben 69!");
                }
        }
        private static void Kivalasztas()
        {
            int ki = 0;
            while (tomb[ki] != 50)
            {
                ki++;
            }
            Console.WriteLine("A tömb {0}. indexű helyén van az 50",ki);
        }
        private static void Kereses()
        {
            int ker = 0;
            while (ker< tomb.Length && tomb[ker] != 50)
            {
                ker++;
            }
            if (ker < tomb.Length)
            {
                Console.WriteLine("Benne van az 50 a {0}. helyen /{1}. indexű helyen", ker,ker+1);
            }
            else
            {
                Console.WriteLine("Nincs benne 50");
            }
        }

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamolas();
            Eldontes();
            Kivalasztas();
            Kereses();
            Console.ReadKey();
        }

       
    }
}
