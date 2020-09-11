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
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("\n Összesen: {0}", osszeg);
        }
        private static void Megszamolas()
        {
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
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamolas();
            Console.ReadKey();
        }

       
    }
}
