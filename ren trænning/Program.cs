using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ren_trænning
{
    class Program
    {
        public static object N2 { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("skriv noget og tryk enter");
             
            string tea = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(tea);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(tea);

            int var = (34);
            Console.WriteLine(var);

            string var2 = ("erklæret string");
            Console.WriteLine(var2);

            int a;
            a = 10;
            Console.WriteLine(a + " simpel variabel");
            a = a + 1;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);

            double kommatal = 12.5;
            kommatal++;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(kommatal);
            kommatal--;
            kommatal *= 2;
            Console.WriteLine($"Kommatal = {kommatal}");


            Console.WriteLine("indtast et tal");
             
            string tal1 = Console.ReadLine();

            Console.WriteLine("indtast et tal");
             
            string tal2 = Console.ReadLine();

            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);

            double res = t1 + t2;
            Console.WriteLine("resultat");
            Console.WriteLine(res.ToString("N2"));


            {
                int nummer = 0;
                nummer++;
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine($"skriver a igen {a}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        
    }
}
