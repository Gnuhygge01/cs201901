using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler2
{
    class Program
    {
        static void Main(string[] args)
        {


            System.DateTime c = new DateTime();

            Console.WriteLine(c);

            System.DateTime d = DateTime.Now;


            //string sti = "c:\\temp\\test";

            String sti = @"c:\temp\test.dk";
            Console.WriteLine(sti);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
