﻿using System;
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
            Console.WriteLine("\n {0}", osszeg);
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Console.ReadKey();
        }

        
    }
}
