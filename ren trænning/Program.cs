using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ren_trænning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv noget og tryk enter");
             
            string tea = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(tea);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(tea);
            






            Console.ReadKey();





        }
    }
}
