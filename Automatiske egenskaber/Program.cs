using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatiske_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "gert";
            p.Efternavn = "er tilbage og har bent med";
            Console.WriteLine(p.Fuldtnavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
    class Person
    {

        public string Fornavn { get; set; }


        private string efternavn;

        public string Efternavn
        {
            get
            {
                
                return efternavn;
            }

            set
            {
                if (value.Length < 3)
                {
                     
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
                 
            }
        }
        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;

        }






    }

}
