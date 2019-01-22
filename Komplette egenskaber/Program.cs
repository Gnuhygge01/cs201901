using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplette_egenskaber
{

    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());

            Vare v1 = new Vare();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        public class Vare
        {
            public Vare()
            {

            }
            public Vare(string navn, int pris)
            {
                this.Pris = pris;
                this.Navn = navn;
            }

            private string  navn;

            public string  Navn
            {
                get {

                    return navn;
                }
                set {

                    navn = value;
                }
            }
             
            private double pris;

            public double Pris
            {
                get
                {
                    return pris; }

                set
                {
                    pris = value; }
            }

            public double PrisMedMoms()
            {
                return this.pris * 1.25;
            }


        }





        
    }
}

