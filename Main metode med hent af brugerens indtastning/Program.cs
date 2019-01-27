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

            
            Console.WriteLine("Skriv din nye adgangskode og tryk Enter");
            String tmp = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Du skrev " + tmp +"\t\r\n" +"tak for det");
            DateTime b = DateTime.Now;
            Console.WriteLine( b);
            b = b.AddDays(1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("tak for det igen");
            Console.WriteLine(b);

            //gå tilbage og find \t\n\r og brug det :-)
            //Console.WriteLine(fornavn + "\t\r\n" + efternavn);


            Console.ReadKey();


        }
    }
}
