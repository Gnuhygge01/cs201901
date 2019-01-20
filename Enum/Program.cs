using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    enum KortKulør

    {
        Spar,

        Hjerter,

        Ruder,

        Klør
    }


    class Program
    {
        static void Main(string[] args)
        {
            int kort1Værdi = 2;

            KortKulør kort2Kulør = KortKulør.Hjerter;



            // Skriver værdi og nummer ud

            Console.WriteLine(kort2Kulør.ToString());

            Console.WriteLine((int)kort1Værdi);



            int kort2Værdi = 4;

            KortKulør kort3Kulør = KortKulør.Ruder;

            Console.WriteLine(kort3Kulør.ToString());

            Console.WriteLine((int)kort2Værdi);



            int kort3Værdi = 13;

            KortKulør kort1Kulør = KortKulør.Spar;

            Console.WriteLine(kort1Kulør.ToString());

            Console.WriteLine((int)kort3Værdi);




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
