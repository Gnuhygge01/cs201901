using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            String tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal2");
            String tal2 = Console.ReadLine();

            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);

            double resultat = t1 + t2;
            Console.WriteLine("Resultatet er");
            Console.WriteLine(resultat.ToString("F2"));



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
