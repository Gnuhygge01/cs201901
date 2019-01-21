using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursiv_metode_Løkke
{
    class Program
    {
        static void Main(string[] args)
        {

            LøkkeSomMetode(1, 10);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        public static void LøkkeSomMetode(int start, int stop)

           
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            LøkkeSomMetode(start, stop);
        }
    }

}
