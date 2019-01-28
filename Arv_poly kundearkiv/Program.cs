using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_poly_kundearkiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura() { Nr = 1, Kunde = "abc", Dato = DateTime.Now.Date };
            Console.WriteLine(f);


        }
    }
    class Faktura
    {
        public int nr { get; set; }
        public string Kunde{ get; set; }
        public DateTime Dato { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}.";
        }


    }



}
