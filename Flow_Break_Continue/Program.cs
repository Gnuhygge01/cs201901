using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 19; i++)
            {
                if (i % 3 != 0) //her laves modulus med 3 
                    continue;

                if (i > 15) //her sørger koden for at der ikke tælles 18 med
                    break;

                Console.WriteLine(i);
            }
 
            // det er bare sjovt ;-)

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();






            }
        }
    }
}
