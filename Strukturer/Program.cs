﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturer
{


    struct Vare
    {
        public int Id;
        public string Navn;
        public string Beskrivelse;
        public double Pris;


    }



    class Program
    {
         


        static void Main(string[] args)
        {


            Vare v1 = new Vare();

            v1.Id = 1;

            v1.Navn = "Frikadeller #1";

            v1.Beskrivelse = " Cool shops Frikadeller #1";

            v1.Pris = 100;

            Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2}");



            Vare v2 = new Vare();
            v2.Id = 2;
            v2.Navn = "Vare #2";
            v2.Beskrivelse = "Min beskrivelsetil #2";
            v2.Pris = 200;
            Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2}");


            Vare v3 = new Vare();

            v3.Id = 3;

            v3.Navn = "sugerør #3";

            v3.Beskrivelse = " Cool shops Frikadeller #3";

            v3.Pris = 120;

            Console.WriteLine($"{v3.Navn} koster {v3.Pris:N2}");



            Vare v2Kopi = v3;

            Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2}");

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
