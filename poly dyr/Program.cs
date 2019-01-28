using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund() { Navn = "fido" };
            h.SigerNoget();
            Console.WriteLine();

            Kat k = new Kat() { Navn = "Pussy" };
            k.SigerNoget();
            Console.WriteLine();

            Dyr f = new Kat() { Navn = "rytt" };
                f.SigerNoget();


            Console.WriteLine();

            List<Dyr> zoo = new List<Dyr>();
            zoo.Add(new Hund() { Navn = "peto" });
            zoo.Add(new Hund() { Navn = "pettto" });
            Console.WriteLine();


           

            foreach (Dyr dyr in zoo)
            {
                dyr.SigerNoget();
            }
            Console.ReadKey();
        }
         

    }
    abstract class Dyr
    {
        public string Navn { get; set; }
        public virtual void SigerNoget()
        {
            Console.WriteLine("dd");
            Console.WriteLine("Jeg er et dyr og hedder" + Navn);
        }
        
    }
    class Hund : Dyr
    {
        public override void SigerNoget()
        {
            Console.WriteLine("vov");
            Console.WriteLine("Jeg er en hund og hedder " + Navn );
        }

    }
    class Kat : Dyr
    {
        public override void SigerNoget()

        {
            Console.WriteLine("miauuw");
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }

}
