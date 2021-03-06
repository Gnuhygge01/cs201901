﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_simple
{
    class Program
    {
        static void Main(string[] args)
        {

            int slutres = LægSammen(4, 5);
            Console.WriteLine(slutres);
       
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.5398

            Udskriv("Dette er en test"); // Dette er en test
            Double Moms = BeregnMoms(1100, 0.25);
            Console.WriteLine(Moms);


            Er("prøv igen");


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        static double BeregnMoms(double tal, double momsPct)
        {
            return tal * momsPct;
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double radius)
        {
            return (radius * radius) * 3.1415;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }

        static void Er(string text)

        {
            Console.WriteLine(text);

        }

    }
    
}
