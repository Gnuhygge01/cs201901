using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_og_enum_kortspil
{
    class Program
    {

        enum Kulør
        {
            Spar,
            Hjerter,
            Ruder,
            Klør
        }

        struct SpilleKort
        {
            public int Værdi;
            public Kulør Kulør;
        }


        static void Main(string[] args)
        {

            SpilleKort s1 = new SpilleKort();
            s1.Værdi = 3;
            s1.Kulør = Kulør.Spar;
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            SpilleKort s2 = new SpilleKort();
            s2.Værdi = 9;
            s2.Kulør = Kulør.Hjerter;
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");

            SpilleKort s3 = new SpilleKort();
            s3.Værdi = 5;
            s3.Kulør = Kulør.Klør;
            Console.WriteLine($"{s3.Kulør} {s3.Værdi}");


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }




        }

    }
}
