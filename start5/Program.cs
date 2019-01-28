using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start5  
{
    class Program
    {
        static void Main(string[] args)
        {
            Person o1 = new Person() { Fornavn = "krølle", Efternavn = "bølle" };
            Elev o2 = new Elev() { Efternavn = "ert", Fornavn = "Lasse", KlasseLokale = "A14" };
            Instruktør o3 = new Instruktør() { Efternavn = "tre ur", Fornavn = "surt", NøgleId = 1 };
            Console.WriteLine(o1.FuldtNavn());
            Console.WriteLine(o2.FuldtNavn());
            Console.WriteLine(o3.FuldtNavn());


            Console.ReadKey();
        }
    }
    class Person {

        public string Fornavn
        {
            get;
            set;
        }
        public string Efternavn
        {
            get; set;
        }

        public String FuldtNavn ()
        {

            return $"{Fornavn}  {Efternavn}";
        }
    }


    class Elev :Person
    {
        public string KlasseLokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

    }



}
