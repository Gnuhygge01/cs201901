using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    enum KortKulør

    { Spar,

        Hjerter,

        Ruder,

        Klør
    }


    class Program
    {
        static void Main(string[] args)
        {
            int kort1Værdi = 2;

            KortKulør kort1Kulør = KortKulør.Hjerter;



            // Skriver værdi og nummer ud

            Console.WriteLine(kort1Kulør.ToString());

            Console.WriteLine((int)kort1Kulør);



            int kort2Værdi = 2;

            KortKulør kort2Kulør = KortKulør.Ruder;

            Console.WriteLine(kort2Kulør.ToString());

            Console.WriteLine((int)kort2Kulør);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
