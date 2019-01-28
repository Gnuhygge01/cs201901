using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øve_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning();
            t2.Skriv();
            for (var i = 0; i < 10; i++)
            {
                t2.Ryst();
                t2.Skriv();
            }
             

            Console.ReadKey();


        }
    }
    public class Terning
    {
        private static Random rnd = new Random();
        private int værdi;

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");

        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }

}
