using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_metode_med_hent_af_brugerens_indtastning
{
    class Program
    {
        static void Main(string[] args)
        {

            String tmp = "";
            Console.WriteLine("Skriv en test og tryk Enter");
            tmp = Console.ReadLine();
            Console.WriteLine("Du skrev " + tmp);
            Console.WriteLine("tak for det");
            //gå tilbage og find \t\n\r og brug det :-)



            Console.ReadKey();


        }
    }
}
