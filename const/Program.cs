using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @const
{
    class Program
    {
        static void Main(string[] args)
        {
            // var i = 1223;
            // finder selv ud af variabel int i = 1223; .... ved at kigge på højre side af =
             

            for (var i = 1220; i < 1234; i++)
                Console.WriteLine(i);
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("tester om farven er god");
                Console.WriteLine($"int min: {System.Int32.MinValue}");
                Console.WriteLine($"int max: {System.Int32.MaxValue}");
                Console.WriteLine(DateTime.Now);
                var e = DateTime.Now.AddDays(2);    // DateTime
                Console.WriteLine(e);
                int i = 10;
                Console.WriteLine($"i = {i}");
                i++;
                Console.WriteLine($"i = {i.ToString()}");

            }
            {
                int x = 15;
                    int y = 6;
                    x %= y;
                Console.WriteLine(x);//brug af %rest finder
            }
            {
                double b3 = (10 - 5) / 5;
                Console.WriteLine($"Alex er nummer = {b3}");

                int f = 1;
                if (f++ == 1)
                {
                    Console.WriteLine($"f = 1");
                }
                // nu er f = 2

                if (--f == 1)   // f = 1 igen (før check)
                {
                    Console.WriteLine($"f = 1");
                }
                double pct = 0.25;
                Console.WriteLine(pct.ToString("P2"));
                var e = DateTime.Now.AddDays(1);    // DateTime
                Console.WriteLine(e);
            }

            //cd +tab+tab

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
