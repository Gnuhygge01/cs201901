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
            var i = 1223;
            // finder selv ud af variabel int i = 1223; .... ved at kigge på højre side af =

            var e = DateTime.Now.AddDays(1);    // DateTime
            Console.WriteLine(e);
            var t = DateTime.Now;
            Console.WriteLine(t);

                


            //cd +tab+tab

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
