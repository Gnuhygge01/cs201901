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
                if (i % 3 != 0)
                    continue;

                if (i > 15)
                    break;

                Console.WriteLine(i);
            }

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();






            }
        }
    }
}
