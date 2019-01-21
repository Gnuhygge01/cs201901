using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statisk_metode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "a";
            p.Alder = 11;
            p.Udskriv();

            bool res = Person.ValiderCpr("11111111");


        
    
        }
    }


    struct Person
    {

        public string Navn;
        public int Alder;


        public void Udskriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {Alder} ");

        }

        public static bool ValiderCpr(string cpr)
        {
            return true;

        }
    }


}
