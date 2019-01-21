using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrøvIgen();
            }
            catch (NullReferenceException ex)
            {


            }
            catch (Exception ex)
            {
                Console.Beep();
                
                Console.WriteLine($"der er sket en fejl igen og Chefen er tilkaldt" + ex.Message);
            }
            
            if (System.Diagnostics.Debugger.IsAttached)

            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
        static void PrøvIgen()
        {
            int prøvAntalGange = 3;
            int antal = 0;
            while (antal < prøvAntalGange)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    Console.Beep();
                    Console.WriteLine("Der er sket en fejl for sidste gang, du skal nu gå op til kontoret for en medarbejdersamtale, Direktøren er informeret " +  ex.Message);
                    antal++;
                }
            }



        }
    }
}