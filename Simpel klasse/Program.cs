using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "Knutsson";
            p1.Fornavn = "Henrik";
            p1.Fødselsår = 1972;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("mikkel", "cronberg", 2006);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            Person p3 = new Person("kurt", "fjort", 1789);
            Console.WriteLine(p3.FuldtNavn());
            Console.WriteLine(p3.EstimeretAlder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
    public class Person
    {

        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {

            return $"{Fornavn} {Efternavn}";

        
        }
        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;

        }
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";


        }
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;


        }
    }





}
