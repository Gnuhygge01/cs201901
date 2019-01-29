using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 15; x++)
            {
                Console.WriteLine("værdi af x : {0}",x);
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
